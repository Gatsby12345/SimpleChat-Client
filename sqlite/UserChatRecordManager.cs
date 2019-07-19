using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleChat.data.db3model;
using SimpleChat.model;
using SimpleChat.pub;

namespace SimpleChat.data
{
    public class UserChatRecordManager :DBBase
    {
        public static void AddRecord(UserChatRecord ur)
        {
            SQLiteConnection conn = new SQLiteConnection(connStr);
            try
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO UserChatRecord (myid,userid,time,content,style,role)VALUES(@myid,@userid,@time,@content,@style,@role)";
                    cmd.Parameters.AddWithValue("@myid", ur.MyId);
                    cmd.Parameters.AddWithValue("@userid", ur.UserId);
                    cmd.Parameters.AddWithValue("@time", ur.Time);
                    cmd.Parameters.AddWithValue("@content", ur.Content);
                    cmd.Parameters.AddWithValue("@style", ur.Style);
                    cmd.Parameters.AddWithValue("@role", ur.Role);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                LogManager.WriteLog(LogManager.LOGERROR, "AddRecord:" + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        public static Tuple<List<int>, List<DateTime>, List<int>> GetUserIdList(int myid,string ids,string content)
        {
            SQLiteConnection conn = new SQLiteConnection(connStr);
            List<int> idList = new List<int>();
            List<DateTime> timeList = new List<DateTime>();
            List<int> countList = new List<int>();
            try
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT userid,MAX(time),COUNT(userid) FROM UserChatRecord WHERE myid = @myid";
                    if(!string.IsNullOrEmpty(ids))
                    {
                        cmd.CommandText += " AND userid IN (" + ids + ")";
                    }
                    if(!string.IsNullOrEmpty(ids))
                    {
                        cmd.CommandText += " AND content LIKE '%"+ content +"%'";
                    }
                    cmd.CommandText += " GROUP BY userid ORDER BY userid ASC";
                    cmd.Parameters.AddWithValue("@myid", myid);
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            idList.Add(reader.GetInt32(0));
                            timeList.Add(reader.GetDateTime(1));
                            countList.Add(reader.GetInt32(2));
                        }
                    }
                    reader.Close();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                LogManager.WriteLog(LogManager.LOGERROR, "GetUserIdList:" + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return new Tuple<List<int>, List<DateTime>, List<int>>(idList,timeList,countList);
        }

        public static UserChatRecord GetUserChatRecordFromReader(SQLiteDataReader reader)
        {
            UserChatRecord ur = new UserChatRecord();
            ur.MyId = reader.GetInt32(0);
            ur.UserId = reader.GetInt32(1);
            ur.Time = reader.GetDateTime(2);
            ur.Content = reader.GetString(3);
            ur.Style = reader.GetString(4);
            ur.Role = reader.GetInt32(5);
            return ur;
        }

        public static int GetChatRecordListCount(int userid, string content,int myid)
        {
            SQLiteConnection conn = new SQLiteConnection(connStr);
            int count = 0;
            try
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT COUNT(userid) FROM UserChatRecord WHERE myid=@myid AND userid = @userid";
                    cmd.Parameters.AddWithValue("@userid", userid);
                    if(!string.IsNullOrEmpty(content))
                    {
                        cmd.CommandText += " AND content LIKE '%@"+ content +"%'";
                    }
                    cmd.Parameters.AddWithValue("@myid", myid);
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            count = reader.GetInt32(0);
                        }
                    }
                    reader.Close();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                LogManager.WriteLog(LogManager.LOGERROR, "GetChatRecordListCount:" + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return count;
        }

        public static List<UserChatRecord> GetChatRecordList(int userid,int page,int size, string content,int myid)
        {
            SQLiteConnection conn = new SQLiteConnection(connStr);
            List<UserChatRecord> list = new List<UserChatRecord>();
            try
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM UserChatRecord WHERE myid=@myid AND userid = @userid";
                    if(!string.IsNullOrEmpty(content))
                    {
                        cmd.CommandText += " AND content LIKE '%"+ content +"%'";
                    }
                    cmd.CommandText += " ORDER BY time ASC LIMIT @page,@size";
                    cmd.Parameters.AddWithValue("@myid", myid);
                    cmd.Parameters.AddWithValue("@userid", userid);
                    cmd.Parameters.AddWithValue("@page", (page - 1)*size);
                    cmd.Parameters.AddWithValue("@size", size);
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserChatRecord ur = GetUserChatRecordFromReader(reader);
                            list.Add(ur);
                        }
                    }
                    reader.Close();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                LogManager.WriteLog(LogManager.LOGERROR, "GetChatRecordList:" + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return list;
        }

        public static List<List<UserChatRecord>> GetAllRecord(int id,List<User> userList)
        {
            SQLiteConnection conn = new SQLiteConnection(connStr);
            List<List<UserChatRecord>> list = new List<List<UserChatRecord>>();
            try
            {
                conn.Open();
                foreach(User user in userList)
                {
                    List<UserChatRecord> recordList = new List<UserChatRecord>();
                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "SELECT * FROM UserChatRecord WHERE myid=@myid AND userid = @userid";
                        cmd.Parameters.AddWithValue("@myid", id);
                        cmd.Parameters.AddWithValue("@userid", user.Id);
                        SQLiteDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                UserChatRecord ur = GetUserChatRecordFromReader(reader);
                                recordList.Add(ur);
                            }
                        }
                        reader.Close();
                        cmd.Dispose();
                        list.Add(recordList);
                    }
                }
                
            }
            catch (Exception ex)
            {
                LogManager.WriteLog(LogManager.LOGERROR, "GetAllRecord:" + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return list;
        }

    }
}
