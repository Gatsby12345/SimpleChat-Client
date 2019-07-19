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
using SimpleChat.http;
using SimpleChat.model;
using SimpleChat.pub;

namespace SimpleChat.window
{
    public partial class AddFriendsForm : Form
    {
        public AddFriendsForm()
        {
            InitializeComponent();
        }

        private List<User> list;

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchStr;
            if (searchTB.ForeColor == Color.LightGray)
                searchStr = "";
            else
                searchStr = searchTB.Text;
            string sex = sexCB.Text;
            string age = ageCB.Text;
            bool online = onlineCheckBox.Checked;

            JObject obj = new JObject();
            obj.Add("searchStr", searchStr);
            obj.Add("sex", sex);
            obj.Add("age", age);
            obj.Add("online", online);
            obj.Add("id", GlobalClass.CurrentUser.Id.ToString());
            obj.Add("notids", Util.GetIdInFriends());
            string usersStr = HTTPUtil.SendPostRequest(Util.GetHttpUrl() +"/searchusers",obj.ToString());
            FillDataGrid(usersStr);
        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            string accTBStr = searchTB.Text;
            if (accTBStr != "")
            {
                if ((accTBStr = Util.CheckSpecialChar(accTBStr)) != null)
                {
                    searchTB.Text = accTBStr;
                    searchTB.Select(accTBStr.Length, 0);
                }
            }
        }

        private void FillDataGrid(string usersStr)
        {
            dataGrid.Visible = true;
            JArray array = JArray.Parse(usersStr);
            list = new List<User>();
            for(int i=0; i< array.Count; i++)
            {
                User user = new User()
                {
                    Id = int.Parse((string)array[i]["id"]),
                    Account = (string)array[i]["account"],
                    Name = (string)array[i]["name"],
                    Birthday = DateTime.Parse((string)array[i]["birthday"]),
                    Sex = char.Parse((string)array[i]["sex"]),
                    Online = (bool)array[i]["online"] ? "在线" : "离线"
                };
                list.Add(user);
            }
            dataGrid.AutoGenerateColumns = false;
            dataGrid.DataSource = list;
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 5 && e.RowIndex != -1)
            {
                int destId = list[e.RowIndex].Id;
                GroupSelectForm gf = new GroupSelectForm(GlobalClass.CurrentUser.Id, destId, 1);
                gf.Init();
                gf.ShowDialog();
                
            }
        }

        private void searchTB_Enter(object sender, EventArgs e)
        {
            if(searchTB.ForeColor == Color.LightGray)
            {
                searchTB.Text = "";
            }
            searchTB.ForeColor = Color.Black;
        }

        private void searchTB_Leave(object sender, EventArgs e)
        {
            if(searchTB.Text == "")
            {
                searchTB.Text = "可输入账号、昵称等进行查询";
                searchTB.ForeColor = Color.LightGray;
            }
        }
    }
}
