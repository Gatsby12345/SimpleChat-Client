using Newtonsoft.Json.Linq;
using SimpleChat.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleChat.model
{
    public class FriendsReq
    {
        public int userid
        {
            get; set;
        }

        public int destid
        {
            get; set;
        }

        public DateTime time
        {
            get; set;
        }

        public int status
        {
            get; set;
        }

        public string groupname
        {
            get; set;
        }

        public User DestUser
        {
            get;
            set;
        }

        public static List<FriendsReq> GetListByStr(string str)
        {
            List<FriendsReq> list = new List<FriendsReq>();
            JArray jArray = JArray.Parse(str);
            if (jArray.Count > 0)
            {
                for (int i = 0; i < jArray.Count; i++)
                {
                    FriendsReq fr = new FriendsReq()
                    {
                        userid = int.Parse((string)jArray[i]["userid"]),
                        destid = int.Parse((string)jArray[i]["destid"]),
                        time = DateTime.Parse((string)jArray[i]["time"]),
                        status = int.Parse((string)jArray[i]["status"]),
                        groupname = (string)jArray[i]["groupname"]
                    };
                    list.Add(fr);
                }
            }
            return list;
        }
    }
}
