using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleChat.data.db3model;
using SimpleChat.pub;

namespace SimpleChat.data
{
    public class StyleConfigManager : DBBase
    {
        public static void AddConfig(StyleConfig ur)
        {
            SQLiteConnection conn = new SQLiteConnection(connStr);
            try
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO StyleConfig(userid,color,size,fontFamily,fontStyle)VALUES(@userid,@color,@size,@fontFamily,@fontStyle)";
                    cmd.Parameters.AddWithValue("@userid", ur.UserId);
                    cmd.Parameters.AddWithValue("@color", ur.Color);
                    cmd.Parameters.AddWithValue("@size", ur.Size);
                    cmd.Parameters.AddWithValue("@fontFamily", ur.FontFamily);
                    cmd.Parameters.AddWithValue("@fontStyle", ur.FontStyle);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                LogManager.WriteLog(LogManager.LOGERROR, "AddConfig:" + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        public static Tuple<Font,Color> GetStyleConfig(int userid)
        {
            LogManager.WriteLog(LogManager.LOGINFO, "userid:" + userid);
            SQLiteConnection conn = new SQLiteConnection(connStr);
            LogManager.WriteLog(LogManager.LOGINFO, "connStr:" + connStr);
            Tuple<Font, Color> tuple = null;
            try
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM StyleConfig WHERE userid = @userid";
                    cmd.Parameters.AddWithValue("@userid", userid);
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            tuple = new Tuple<Font, Color>(new Font(reader.GetString(3), reader.GetFloat(2), (FontStyle)reader.GetInt32(4)), Color.FromArgb(reader.GetInt32(1)));
                        }
                    }
                    reader.Close();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                LogManager.WriteLog(LogManager.LOGERROR, "GetStyleConfig:" + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return tuple;
        }

        public static void UpdateFont(Font font,int id)
        {
           
            SQLiteConnection conn = new SQLiteConnection(connStr);
            
            try
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "UPDATE StyleConfig SET size=@size,fontFamily=@fontFamily,fontStyle=@fontStyle WHERE userid=@userid";
                    cmd.Parameters.AddWithValue("@userid", id);
                    cmd.Parameters.AddWithValue("@size", font.Size);
                    cmd.Parameters.AddWithValue("@fontFamily", font.FontFamily.Name);
                    cmd.Parameters.AddWithValue("@fontStyle", (int)font.Style);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                LogManager.WriteLog(LogManager.LOGERROR, "UpdateFont:" + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        public static void UpdateColor(int color,int id)
        {
            SQLiteConnection conn = new SQLiteConnection(connStr);
            try
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "UPDATE StyleConfig SET color=@color WHERE userid=@userid";
                    cmd.Parameters.AddWithValue("@userid", id);
                    cmd.Parameters.AddWithValue("@color", color);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                LogManager.WriteLog(LogManager.LOGERROR, "UpdateColor:" + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
