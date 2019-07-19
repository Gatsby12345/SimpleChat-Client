using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleChat.model;
using SimpleChat.pub;
using SimpleChat.window.custom;

namespace SimpleChat.window
{
    public partial class NewMsgForm : Form
    {
        public NewMsgForm()
        {
            InitializeComponent();
        }

        public void Init()
        {
            int count = 0;
            foreach (int id in MainForm.Id_Messages.Keys)
            {
                NewMsgList nl = new NewMsgList();
                nl.MsgCount = MainForm.Id_Messages[id].Count;
                count += nl.MsgCount;
                nl.Dock = DockStyle.Top;
                if (id == 0)
                {
                    nl.InitFriends();
                }
                else
                {
                    User msgUser = null;
                    foreach (List<User> list in MainForm.Group_Users.Values)
                    {
                        foreach (User user in list)
                        {
                            if (user.Id == id)
                            {
                                msgUser = user;
                                break;
                            }
                        }
                    }
                    nl.user = msgUser;
                    nl.InitChat();
                }
                this.Controls.Add(nl);
            }
            this.Text = "未读消息(" + count + ")";
        }

        private void NewMsgForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.nf = null;
            GlobalClass.mf.Invoke((MethodInvoker)delegate
            {
                GlobalClass.mf.SetTimerStatus(false);
            });
        }

        private void getAllBtn_Click(object sender, EventArgs e)
        {
            GlobalClass.mf.Invoke((MethodInvoker)delegate
            {
                GlobalClass.mf.SetTimerStatus(false);
            });
            this.Hide();
            foreach (int id in MainForm.Id_Messages.Keys)
            {
                if(id == 0)
                {
                    continue;
                }
                else
                {
                    User msgUser = null;
                    foreach (List<User> list in MainForm.Group_Users.Values)
                    {
                        foreach (User user in list)
                        {
                            if (user.Id == id)
                            {
                                msgUser = user;
                                break;
                            }
                        }
                    }
                    Chat newchat = new Chat();
                    newchat.DestUser = msgUser;
                    MainForm.Id_Chat.TryAdd(msgUser.Id, newchat);
                    newchat.Init();
                    MainForm.Id_Messages.TryGetValue(id, out List<MessageType> msglist);
                    newchat.InitChatText(msglist);
                    newchat.Show();
                }
            }
            if(MainForm.Id_Messages.TryRemove(0, out List<MessageType> checkMsgList))
            {
                Util.OpenTheFrqForm();
            }
            MainForm.Id_Messages.Clear();
            this.Close();
        }
    }
}
