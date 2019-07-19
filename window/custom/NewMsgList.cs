using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleChat.model;
using SimpleChat.pub;
using SimpleChat.http;
using SimpleChat.data.db3model;

namespace SimpleChat.window.custom
{
    public partial class NewMsgList : UserControl
    {
        public NewMsgList()
        {
            InitializeComponent();
        }

        public int MsgCount;

        public User user;

        public void InitFriends()
        {
            headimage.Image = Properties.Resources.laba.ToBitmap();
            name.Text = "验证消息";
            msgCount.Text = "(" + MsgCount + ")";
            idLabel.Text = "0";
        }

        public void InitChat()
        {
            if (string.IsNullOrEmpty(user.Headimage))
                headimage.Image = Properties.Resources.defalut;
            else
                headimage.Image = Util.GetImageByBase64Str(user.Headimage);
            name.Text = user.Name;
            msgCount.Text = "(" + MsgCount + ")";
            idLabel.Text = user.Id.ToString();
        }

        private void NewMsgList_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.PaleGreen;
        }

        private void NewMsgList_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void NewMsgList_Click(object sender, EventArgs e)
        {
            MainForm.nf.Close();
            int id = user == null ? 0 : user.Id;
            if (!MainForm.Id_Messages.TryRemove(id, out List<MessageType> list))
            {
                return;
            }
            if (MainForm.Id_Messages.Count == 0)
            {
                GlobalClass.mf.Invoke((MethodInvoker)delegate
                {
                    GlobalClass.mf.SetTimerStatus(false);
                });
            }
            if (idLabel.Text == "0") //验证消息
            {
                Util.OpenTheFrqForm();
            }
            else
            {
                Chat newchat = new Chat();
                newchat.DestUser = user;
                MainForm.Id_Chat.TryAdd(user.Id, newchat);
                newchat.Init();
                newchat.InitChatText(list);
                newchat.Show();
            }
        }
    }
}
