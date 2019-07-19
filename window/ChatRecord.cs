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

namespace SimpleChat.window
{
    public partial class ChatRecord : Form
    {
        public ChatRecord()
        {
            InitializeComponent();
        }

        private List<User> userList;

        private int CurrentUserId;

        private int CurrentPage;

        private int TotalPage;

        private new const int Size = 20;

        private string Ids = "";

        public void Init() 
        {
            Tuple<List<int>, List<DateTime>, List<int>> list = UserChatRecordManager.GetUserIdList(GlobalClass.CurrentUser.Id,Ids, contentTB.Text);
            if(list.Item1.Count > 0)
            {
                string ids = string.Join(",", list.Item1);
                string Users = HTTPUtil.SendGetRequest(Util.GetHttpUrl() + "/getUsersByUserid/" + ids);
                JArray usersArray = JArray.Parse(Users);
                userList = new List<User>();
                for (int i = 0; i < usersArray.Count; i++)
                {
                    User user = new User()
                    {
                        Id = int.Parse((string)usersArray[i]["id"]),
                        Name = (string)usersArray[i]["name"],
                        Account = (string)usersArray[i]["account"],
                        Headimage = (string)usersArray[i]["headimage"]
                    };
                    userList.Add(user);
                    Image image = string.IsNullOrEmpty(user.Headimage) ? Properties.Resources.defalut : Util.GetImageByBase64Str(user.Headimage);
                    imageList.Images.Add(i.ToString(),image);
                }
                for(int i = 0; i < userList.Count; i++)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.ImageIndex = i;     //通过与imageList绑定，显示imageList中第i项图标 
                    lvi.Text = userList[i].Name + "(" + userList[i].Account + ")";
                    lvi.SubItems.Add(list.Item2[i].ToString("yyyy-MM-dd HH:mm:ss"));
                    lvi.SubItems.Add(list.Item3[i].ToString());
                    this.listView.Items.Add(lvi);
                }
                this.listView.Items[0].Selected = true;
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listView.FocusedItem != null)
            {
                recordRichTB.Clear();
                string info = this.listView.FocusedItem.Text;
                int startindex = info.IndexOf('(');
                int endindex = info.IndexOf(')');
                string account = info.Substring(startindex + 1, endindex - startindex - 1);
                int id = 0;
                userList.ForEach(user => { if (user.Account == account) id = user.Id;});
                CurrentUserId = id;
                int totalRecord = UserChatRecordManager.GetChatRecordListCount(CurrentUserId,contentTB.Text, GlobalClass.CurrentUser.Id);
                CurrentPage = 1;
                TotalPage = totalRecord % Size > 0 ? totalRecord / Size + 1 : totalRecord / Size;
                StartQuery(CurrentPage);
            }
        }

        private void firstPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(CurrentPage == 1)
            {
                return;
            }
            recordRichTB.Clear();
            CurrentPage = 1;
            StartQuery(CurrentPage);
        }

        private void prePage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (CurrentPage == 1)
            {
                return;
            }
            recordRichTB.Clear();
            StartQuery(--CurrentPage);
        }

        private void nextPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (CurrentPage == TotalPage)
            {
                return;
            }
            recordRichTB.Clear();
            StartQuery(++CurrentPage);
        }

        private void lastPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(CurrentPage == TotalPage)
            {
                return;
            }
            recordRichTB.Clear();
            CurrentPage = TotalPage;
            StartQuery(CurrentPage);
        }

        private void StartQuery(int page)
        {
            List<UserChatRecord> list = UserChatRecordManager.GetChatRecordList(CurrentUserId, page, Size,contentTB.Text, GlobalClass.CurrentUser.Id);
            FillRichBox(list);
        }

        private void FillRichBox(List<UserChatRecord> list)
        {
            foreach(UserChatRecord ur in list)
            {
                string fromWho;
                if (ur.Role == 1)
                    fromWho = listView.FocusedItem.Text;
                else
                    fromWho = GlobalClass.CurrentUser.Name + "(" + GlobalClass.CurrentUser.Account + ")";
                recordRichTB.AppendText(fromWho + " " + ur.Time.ToString("yyyy-MM-dd HH:mm:ss") + "\n");
                Tuple<Font, Color> tuple = UserChatRecord.GetStyle(ur.Style);
                recordRichTB.SelectionColor = tuple.Item2;
                recordRichTB.SelectionFont = tuple.Item1;
                recordRichTB.AppendText(ur.Content + "\n");
            }
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(nameTB.Text))
            {
                List<int> list = new List<int>();
                userList.ForEach(user => { if (user.Name.Contains(nameTB.Text) || user.Account.Contains(nameTB.Text)) list.Add(user.Id); });
                if(list.Count > 0)
                {
                    Ids = string.Join(",", list);
                }
            }
            else
            {
                Ids = "";
            }
            this.listView.Items.Clear();
            this.recordRichTB.Clear();
            Init();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            nameTB.Text = "";
            contentTB.Text = "";
        }

        private void nameTB_TextChanged(object sender, EventArgs e)
        {
            string accTBStr = nameTB.Text;
            if (accTBStr != "")
            {
                if ((accTBStr = Util.CheckSpecialChar(accTBStr)) != null)
                {
                    nameTB.Text = accTBStr;
                    nameTB.Select(accTBStr.Length, 0);
                }
            }
        }

        private void contentTB_TextChanged(object sender, EventArgs e)
        {
            string accTBStr = contentTB.Text;
            if (accTBStr != "")
            {
                if ((accTBStr = Util.CheckSpecialChar(accTBStr)) != null)
                {
                    contentTB.Text = accTBStr;
                    contentTB.Select(accTBStr.Length, 0);
                }
            }
        }

        private void 导出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "文件(*.xlsx)|*.xlsx|所有文件(*.*)|*.*";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string fileName = sfd.FileName;
                List<List<UserChatRecord>> list = UserChatRecordManager.GetAllRecord(GlobalClass.CurrentUser.Id, userList);
                SaveDataToExcelForm sc = new SaveDataToExcelForm(fileName, userList, list);
                sc.ShowDialog();
            }
        }
    }
}
