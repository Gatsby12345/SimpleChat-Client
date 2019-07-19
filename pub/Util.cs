using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using SimpleChat.model;
using SimpleChat.window;
using System.Windows.Forms;
using SimpleChat.server;

namespace SimpleChat.pub
{
    public class Util
    {
        
        //检验特殊字符并且返回正确的字符串
        public static string CheckSpecialChar(string name)
        {
            char[] chArray = name.ToCharArray();
            Regex rg = new Regex("^[\u4e00-\u9fa5]$");  //正则表达式
            string result = null;
            foreach (char c in chArray)
            {
                if (rg.IsMatch(c.ToString()) || (c <= 'Z' && c >= 'A') || (c <= 'z' && c >= 'a') || (c <= '9' && c >= '0'))
                {
                    continue;
                }
                else
                {
                    result = name.Replace(c.ToString(), "");
                }
            }

            return result;
        }

        public static bool CheckChar(string Str)
        {
            char[] chArray = Str.ToCharArray();
            Regex rg = new Regex("^[\u4e00-\u9fa5]$");  //正则表达式
            foreach (char c in chArray)
            {
                if (rg.IsMatch(c.ToString()) || (c <= 'Z' && c >= 'A') || (c <= 'z' && c >= 'a') || (c <= '9' && c >= '0'))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        //判断文件大小并将文件转为base64字符串
        public static Tuple<bool,string> GetBase64StrByImage(string filePath)
        {
            FileInfo info = new FileInfo(filePath);
            string base64Str = "";
            bool outnumber = false;
            if (info.Length <= 65535)  //blob字段最大存储65535个字节
            {
                byte[] zipdata = File.ReadAllBytes(filePath);
                base64Str = Convert.ToBase64String(zipdata);
            }
            else
                outnumber = true;
            return Tuple.Create(outnumber, base64Str);
        }

        //base64编码的字符串转为图片
        public static Bitmap GetImageByBase64Str(string strbase64)
        {
            try
            {
                byte[] arr = Convert.FromBase64String(strbase64);
                MemoryStream ms = new MemoryStream(arr);
                Bitmap bmp = new Bitmap(ms);
                ms.Close();
                return bmp;
            }
            catch (Exception ex)
            {
                LogManager.WriteLog(LogManager.LOGERROR, "GetImageByBase64Str:" + ex.ToString());
                return null;
            }
        }

        public static string GetHttpUrl()
        {
            return "http://" + GlobalClass.ip + ":" + GlobalClass.httpport;
        }

        public static List<string> GetGroups(string Friends)
        {
            List<string> list = new List<string>();
            if (string.IsNullOrEmpty(Friends))
                return list;
            JArray array = JArray.Parse(Friends);
            for(int i=0;i<array.Count;i++)
            {
                list.Add((string)array[i]["name"]);
            }
            return list;
        }

        public static string GetIdInFriends()
        {
            JArray jArray = new JArray();
            List<List<User>> list = MainForm.Group_Users.Values.ToList();
            foreach(List<User> userList in list)
            {
                foreach(User user in userList)
                {
                    jArray.Add(user.Id);
                }
            }
            return jArray.ToString();
        }

        public static void OpenTheFrqForm()
        {
            string frStr = HTTPUtil.SendGetRequest(Util.GetHttpUrl() + "/friendsreq/getall/" + GlobalClass.CurrentUser.Id);
            List<FriendsReq> frList = FriendsReq.GetListByStr(frStr);
            CheckFriendsReqForm fr = new CheckFriendsReqForm();
            fr.Init(frList);
            fr.ShowDialog();
            string result = HTTPUtil.SendGetRequest(Util.GetHttpUrl() + "/getfriendsbyid/" + GlobalClass.CurrentUser.Id);
            if (result != "获取失败！")
            {
                GlobalClass.CurrentUser.Friends = result;
                GlobalClass.Groups = Util.GetGroups(result);
                GlobalClass.mf.Invoke((MethodInvoker)delegate
                {
                    GlobalClass.mf.InitTree();
                });
            }
        }

        public static void Exit()
        {
            foreach (int i in MainForm.Id_Chat.Keys)
            {
                MainForm.Id_Chat.TryRemove(i, out Chat chat);
                chat.Close();
            }
            Environment.Exit(0);
        }

    }
}
