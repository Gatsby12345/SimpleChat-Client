using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleChat.data;
using SimpleChat.data.db3model;
using SimpleChat.http;
using SimpleChat.model;
using SimpleChat.pub;
using SimpleChat.window.custom;

namespace SimpleChat.window
{
    public partial class CheckFriendsReqForm : Form
    {
        public CheckFriendsReqForm()
        {
            InitializeComponent();
        }

        public void Init(List<FriendsReq> list)
        {
            if (list.Count == 0)
            {
                tip.Visible = true;
                return;
            }
            int[] array = new int[list.Count];
            for(int i=0;i<list.Count;i++)
            {
                if(list[i].destid == GlobalClass.CurrentUser.Id)
                    array[i] = list[i].userid;
                else
                    array[i] = list[i].destid;
            }
            string str = string.Join(",", array);
            string usersStr = HTTPUtil.SendGetRequest(Util.GetHttpUrl() + "/getUsersByUserid/" + str);

            JArray usersArray = JArray.Parse(usersStr);
            for (int k = 0; k < list.Count; k++)
            {
                for(int i = 0;i < usersArray.Count; i++)
                {
                    int id = int.Parse((string)usersArray[i]["id"]);
                    if(array[k] == id)
                    {
                        User destUser = new User()
                        {
                            Id = id,
                            Name = (string)usersArray[i]["name"],
                            Account = (string)usersArray[i]["account"],
                            Sex = char.Parse((string)usersArray[i]["sex"]),
                            Birthday = DateTime.Parse((string)usersArray[i]["birthday"]),
                            Headimage = (string)usersArray[i]["headimage"]
                        };
                        FriendsReq fr = list[k];
                        fr.DestUser = destUser;
                        GroupList g = new GroupList();
                        g.fr = fr;
                        g.Init();
                        g.Dock = DockStyle.Top;
                        this.Controls.Add(g);
                        break;
                    }
                }
            }
            
        }
    }
}
