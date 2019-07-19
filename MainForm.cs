using Newtonsoft.Json.Linq;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleChat.data.db3model;
using SimpleChat.pub;
using SimpleChat.model;
using SimpleChat.server;
using SimpleChat.window;

namespace SimpleChat
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public static NewMsgForm nf = null; //消息提醒窗口

        public User user = GlobalClass.CurrentUser;

        private bool IconStatus = true;

        public static Dictionary<string, List<User>> Group_Users = new Dictionary<string, List<User>>(); //组名-成员

        public static ConcurrentDictionary<int, Chat> Id_Chat = new ConcurrentDictionary<int, Chat>(); //id-聊天窗口

        public static ConcurrentDictionary<int, List<MessageType>> Id_Messages = new ConcurrentDictionary<int, List<MessageType>>(); //id-聊天消息

        public void NotifyOffline()
        {
            MessageBox.Show("您的账号已在其他地方登录！请检查账号安全状况！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Util.Exit();
        }

        public void Init()
        {
            name.Text = user.Name;
            if (!string.IsNullOrEmpty(user.Headimage))
                headImage.Image = Util.GetImageByBase64Str(user.Headimage);
            else
            {
                headImage.Image = Properties.Resources.defalut;
            }
            notifyIcon.Text = "当前用户："+user.Name + "\n状态："+"在线";
            InitTree();
        }

        public void InitTree()
        {
            if(string.IsNullOrEmpty(user.Friends))
            {
                return;
            }
            friendsTree.Nodes.Clear();
            Group_Users.Clear();
            JArray array = JArray.Parse(user.Friends);
            for(int i = 0; i < array.Count; i++)
            {
                string groupname = (string)array[i]["name"];
                friendsTree.Nodes.Add(groupname);
                string membersStr = (string)array[i]["members"];
                List<User> list = new List<User>();
                if (string.IsNullOrEmpty(membersStr))
                {
                    Group_Users.Add(groupname, list);
                    continue;
                }
                string Users = HTTPUtil.SendGetRequest(Util.GetHttpUrl() +"/getUsersByUserid/" + membersStr);
                JArray usersArray = JArray.Parse(Users);
                for (int k = 0; k < usersArray.Count; k++)
                {
                    User user = new User()
                    {
                        Id = int.Parse((string)usersArray[k]["id"]),
                        Name = (string)usersArray[k]["name"],
                        Account = (string)usersArray[k]["account"],
                        Headimage = (string)usersArray[k]["headimage"]
                    };
                    friendsTree.Nodes[i].Nodes.Add(user.Name + "(" + user.Account + ")");
                    list.Add(user);
                }
                Group_Users.Add(groupname, list);
            }
            
        }

        #region notifyicon
        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowMainForm();
        }

        private void 显示主界面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMainForm();
        }

        private void ShowMainForm()
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Show();
                WindowState = FormWindowState.Normal;
                this.Activate();
                this.ShowInTaskbar = true;
            }
        }

        private void notifyIcon_MouseMove(object sender, MouseEventArgs e)
        {
            if (nf == null && timer.Enabled)
            {
                Point CursorPoint = MousePosition;
                nf = new NewMsgForm();
                nf.Height = Id_Messages.Count * 30 + 65;
                int height = Screen.PrimaryScreen.WorkingArea.Height;
                nf.DesktopLocation = new Point(CursorPoint.X - nf.Width / 2, height - nf.Height);
                nf.Init();
                nf.Show();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ShowInTaskbar)
            {
                if (MessageBox.Show("是否确认退出程序？", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    this.Dispose();
                    TCPUtil.CloseConn();
                    Util.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Minimized)
            {
                //隐藏任务栏区图标
                this.ShowInTaskbar = false;
                //图标显示在托盘区
                notifyIcon.Visible = true;
                
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (IconStatus)
                notifyIcon.Icon = Properties.Resources.blank;
            else
                notifyIcon.Icon = Properties.Resources.SimpleChat;
            IconStatus = !IconStatus;
        }

        public void SetTimerStatus(bool isStart)
        {
            if (isStart)
            {
                timer.Interval = 600;
                timer.Start();
                timer.Enabled = true;
            }
            else
            {
                timer.Stop();
                notifyIcon.Icon = Properties.Resources.SimpleChat;
            }
        }
        #endregion

        #region Menu
        private void 添加联系人ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFriendsForm afForm = new AddFriendsForm();
            afForm.Show();
        }
        #endregion

        
        private void FRBtn_Click(object sender, EventArgs e)
        {
            if(nf != null)
            {
                nf.Close();
            }
            Id_Messages.TryRemove(0, out List<MessageType> list);
            string frStr = HTTPUtil.SendGetRequest(Util.GetHttpUrl() + "/friendsreq/getall/"+GlobalClass.CurrentUser.Id);
            List<FriendsReq> frList = FriendsReq.GetListByStr(frStr);
            CheckFriendsReqForm fr = new CheckFriendsReqForm();
            fr.Init(frList);
            fr.ShowDialog();
            string result = HTTPUtil.SendGetRequest(Util.GetHttpUrl() + "/getfriendsbyid/" + user.Id);
            if (result != "获取失败！")
            {
                GlobalClass.CurrentUser.Friends = result;
                GlobalClass.Groups = Util.GetGroups(user.Friends);
                InitTree();
            }
        }

        #region search panel
        private void searchBox_Enter(object sender, EventArgs e)
        {
            if (searchBox.ForeColor == Color.Gray)
            {
                searchBox.Text = "";
            }
            searchBox.ForeColor = Color.Black;
        }

        private void searchBox_Leave(object sender, EventArgs e)
        {
            if (searchBox.Text == "")
            {
                searchBox.Text = "可输入账号或者昵称查找";
                searchBox.ForeColor = Color.Gray;
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            string accTBStr = searchBox.Text;
            if (accTBStr != "")
            {
                if ((accTBStr = Util.CheckSpecialChar(accTBStr)) != null)
                {
                    searchBox.Text = accTBStr;
                    searchBox.Select(accTBStr.Length, 0);
                }
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            string searchStr = searchBox.Text;
            if(Group_Users.Count == 0)
            {
                return;
            }
            bool IsCheckAll = false;
            if (string.IsNullOrEmpty(searchStr) || searchBox.ForeColor == Color.Gray)
            {
                IsCheckAll = true;
            }
            friendsTree.Nodes.Clear();
            int i = 0;
            foreach (string key in Group_Users.Keys)
            {
                List<User> list = Group_Users[key];
                bool isHave = false;
                list.ForEach(user => { if (user.Account.Contains(searchStr) || user.Name.Contains(searchStr) || IsCheckAll) { isHave = true;} });
                if(isHave || IsCheckAll)
                {
                    friendsTree.Nodes.Add(key);
                    list.ForEach(user => { if (user.Account.Contains(searchStr) || user.Name.Contains(searchStr) || IsCheckAll) { friendsTree.Nodes[i].Nodes.Add(user.Name + "(" + user.Account + ")"); } });
                    i++;
                }
            }
        }
        #endregion

        private void friendsTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                if(e.Node.Level == 0)
                {
                    e.Node.ContextMenuStrip = groupMenu;
                    friendsTree.SelectedNode = e.Node;
                }
                else
                {
                    e.Node.ContextMenuStrip = userMenu;
                }
            }
        }

        private void friendsTree_DoubleClick(object sender, EventArgs e)
        {
            if(friendsTree == null || friendsTree.SelectedNode == null)
            {
                return;
            }
            if(friendsTree.SelectedNode.Level == 1)
            {
                OpenChatForm();
            }
        }

        private void OpenChatForm()
        {
            if(nf != null)
            {
                nf.Close();
            }
            string info = friendsTree.SelectedNode.Text;
            int startindex = info.IndexOf('(');
            int endindex = info.IndexOf(')');
            string param = info.Substring(startindex + 1, endindex - startindex - 1);
            string result = HTTPUtil.SendGetRequest(Util.GetHttpUrl() + "/getuserbyaccount/" + param);
            User DestUser = User.GetUserByStr(result);
            if (Id_Chat.TryGetValue(DestUser.Id,out Chat chat))
            {
                chat.Activate();
            }
            else
            {
                Chat newchat = new Chat();
                newchat.DestUser = DestUser;
                Id_Chat.TryAdd(DestUser.Id, newchat);
                newchat.Init();
                Id_Messages.TryRemove(DestUser.Id, out List<MessageType> list);
                if(list != null)
                {
                    newchat.InitChatText(list);
                }
                newchat.Show();
            }
        }

        private void 发送消息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChatForm();
        }

        private void 添加分组ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddGroupForm af = new AddGroupForm();
            af.ShowDialog();
            if(af.IsOk)
            {
                if(Group_Users.ContainsKey(af.groupname))
                {
                    MessageBox.Show("已存在该分组！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                JObject param = new JObject();
                param.Add("id", GlobalClass.CurrentUser.Id);
                param.Add("groupname", af.groupname);
                string result = HTTPUtil.SendPostRequest(Util.GetHttpUrl() + "/addgroup", param.ToString());
                if(result == "添加成功！")
                {
                    friendsTree.Nodes.Add(af.groupname);
                    Group_Users.Add(af.groupname, new List<User>());
                    GlobalClass.Groups.Add(af.groupname);
                }
                else
                {
                    MessageBox.Show(result, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void 删除分组ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Group_Users.Count == 1)
            {
                MessageBox.Show("您只有一个分组！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(MessageBox.Show("确认删除此分组以及该分组下的好友吗？","询问",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                string groupname = friendsTree.SelectedNode.Text;
                JObject param = new JObject();
                param.Add("id", GlobalClass.CurrentUser.Id);
                param.Add("groupname", groupname);
                string result = HTTPUtil.SendPostRequest(Util.GetHttpUrl() + "/deletegroup", param.ToString());
                if (result == "删除成功！")
                {
                    friendsTree.Nodes.Remove(friendsTree.SelectedNode);
                    Group_Users.Remove(groupname);
                }
                else
                {
                    MessageBox.Show(result, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void 修改名称ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string oldName = friendsTree.SelectedNode.Text;
            friendsTree.LabelEdit = true;
            friendsTree.SelectedNode.BeginEdit();
        }

        private void friendsTree_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            friendsTree.LabelEdit = false;
            string oldName = e.Node.Text;
            string newName = e.Label;
            if (newName == null) //没改
                return;
            if (string.IsNullOrEmpty(newName))
            {
                MessageBox.Show("组名不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.CancelEdit = true;
                return;
            }
            if (!Util.CheckChar(newName))
            {
                MessageBox.Show("组名不能包含标点符号！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.CancelEdit = true;
                return;
            }
            JObject obj = new JObject();
            obj.Add("id", GlobalClass.CurrentUser.Id);
            obj.Add("newname", newName);
            obj.Add("oldname", oldName);
            string result = HTTPUtil.SendPostRequest(Util.GetHttpUrl() + "/updategroup", obj.ToString());
            if(result == "修改成功！")
            {
                List<string> list = Group_Users.Keys.ToList();
                for (int i = 0; i < list.Count; i++)
                {
                    if(list[i] == oldName)
                    {
                        list[i] = newName;
                        break;
                    }
                }
                List<List<User>> userList = Group_Users.Values.ToList();
                Group_Users.Clear();
                for (int k = 0; k < list.Count; k++)
                {
                    Group_Users.Add(list[k], userList[k]);
                }
            }
            else
            {
                MessageBox.Show(result, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void headImage_Click(object sender, EventArgs e)
        {
            ChangeHeadImgForm cf = new ChangeHeadImgForm();
            cf.Init();
            cf.ShowDialog();
            if(cf.IsSuccess)
            {
                headImage.Image = Util.GetImageByBase64Str(cf.imageStr);
            }
        }

        private void 关于我们ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUsForm af = new AboutUsForm();
            af.Show();
        }
    }
}
