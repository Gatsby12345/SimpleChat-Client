using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleChat.model
{
    public class User
    {
        public int Id
        {
            get;
            set;
        }

        public string Account
        {
            get;
            set;
        }

        public string Password
        {
            get;
            set;
        }

       

        public string Name
        {
            get;
            set;
        }

        

        public DateTime Birthday
        {
            get;
            set;
        }

        

        public string Headimage
        {
            get;
            set;
        }

        

        public char Sex
        {
            get;
            set;
        }

       

        public string Friends
        {
            get;
            set;
        }

        

        public string Groups
        {
            get;
            set;
        }

        public string Online
        {
            set;
            get;
        }
        
        public static User GetUserByStr(string result)
        {
            JObject userObj = JObject.Parse(result);
            User user = new User()
            {
                Id = int.Parse(userObj["id"].ToString()),
                Account = userObj["account"].ToString(),
                Password = userObj["password"].ToString(),
                Name = userObj["name"].ToString(),
                Birthday = DateTime.Parse(userObj["birthday"].ToString()),
                Headimage = userObj["headimage"].ToString(),
                Sex = char.Parse(userObj["sex"].ToString()),
                Friends = (string)userObj["friends"],
                Groups = (string)userObj["groups"]
            };
            return user;
        }

    }
}
