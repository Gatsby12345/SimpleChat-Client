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
using SimpleChat.server;
using SimpleChat.model;
using SimpleChat.pub;
using SimpleChat.window;

namespace SimpleChat.window
{
    public partial class Chat : Form
    {
        public Chat()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        public User DestUser;

        public void Init()
        {
            Text = DestUser.Name + "(" + DestUser.Account + ")";
            Tuple<Font,Color> tuple = StyleConfigManager.GetStyleConfig(GlobalClass.CurrentUser.Id);
            fontDialog.Font = tuple.Item1;
            colorDialog.Color = tuple.Item2;
            sendRichBox.Font = tuple.Item1;
            sendRichBox.ForeColor = tuple.Item2;
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            string str = sendRichBox.Text;
            if(string.IsNullOrEmpty(str.Trim('\n').Trim('\t').Trim(' ')))
            {
                sendRichBox.Text = "";
                sendRichBox.Focus();
                MessageBox.Show("发送内容不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DateTime dt = DateTime.Now;
            string style = null;
            string content = ChatContent.GetStringByContent(str, fontDialog.Font, colorDialog.Color,dt,ref style);
            MessageType mt = new MessageType(GlobalClass.CurrentUser.Id,DestUser.Id, content, 1);
            TCPUtil.socketSend.Send(mt.ToJsonBytes());
            recRichBox.AppendText(dt.ToString("yyyy-MM-dd HH:mm:ss") + " " + GlobalClass.CurrentUser.Name + "(" + GlobalClass.CurrentUser.Account + ")" + "\n");
            recRichBox.SelectionFont = fontDialog.Font;
            recRichBox.SelectionColor = colorDialog.Color;
            recRichBox.AppendText(str + "\n");
            FormatChatText();
            sendRichBox.Text = "";
            UserChatRecord ur = new UserChatRecord()
            {
                MyId = GlobalClass.CurrentUser.Id,
                UserId = DestUser.Id,
                Time = dt,
                Content = str,
                Style = style,
                Role = 0
            };
            UserChatRecordManager.AddRecord(ur);
        }

        public void InitChatText(List<MessageType> list)
        {
            foreach(MessageType mt in list)
            {
                string style = null;
                ChatContent cc = ChatContent.GetChatContentByStr(mt.Content,ref style);
                recRichBox.AppendText(cc.Time.ToString("yyyy-MM-dd HH:mm:ss") + " " + DestUser.Name + "(" + DestUser.Account + ")" + "\n");
                recRichBox.SelectionColor = cc.Color;
                recRichBox.SelectionFont = new Font(cc.FontFamily, cc.Size, cc.FontStyle);
                recRichBox.AppendText(cc.Content + "\n");
                FormatChatText();
                UserChatRecord ur = new UserChatRecord()
                {
                    MyId = GlobalClass.CurrentUser.Id,
                    UserId = DestUser.Id,
                    Time = cc.Time,
                    Content = cc.Content,
                    Style = style,
                    Role = 1
                };
                UserChatRecordManager.AddRecord(ur);
            }
        }


        public void ReceiveMsg(string str)
        {
            string style = null;
            recRichBox.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " " + DestUser.Name + "(" + DestUser.Account + ")" + "\n");
            ChatContent cc = ChatContent.GetChatContentByStr(str, ref style);
            recRichBox.SelectionColor = cc.Color;
            recRichBox.SelectionFont = new Font(cc.FontFamily, cc.Size, cc.FontStyle);
            recRichBox.AppendText(cc.Content + "\n");
            FormatChatText();
            UserChatRecord ur = new UserChatRecord()
            {
                MyId = GlobalClass.CurrentUser.Id,
                UserId = DestUser.Id,
                Time = cc.Time,
                Content = cc.Content,
                Style = style,
                Role = 1
            };
            UserChatRecordManager.AddRecord(ur);
        }

        private void Chat_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.Id_Chat.TryRemove(DestUser.Id, out Chat chat);
        }

        private void changeFontBtn_Click(object sender, EventArgs e)
        {
            fontDialog.ShowDialog();
            sendRichBox.Font = fontDialog.Font;
            StyleConfigManager.UpdateFont(fontDialog.Font, GlobalClass.CurrentUser.Id);
        }

        private void changeColorBtn_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            sendRichBox.ForeColor = colorDialog.Color;
            StyleConfigManager.UpdateColor(colorDialog.Color.ToArgb(), GlobalClass.CurrentUser.Id);
        }

        private void chatRecordBtn_Click(object sender, EventArgs e)
        {
            ChatRecord cr = new ChatRecord();
            cr.Init();
            cr.ShowDialog();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            MainForm.Id_Chat.TryRemove(DestUser.Id, out Chat chat);
            Close();
        }

        private void FormatChatText()
        {
            recRichBox.Focus();
            recRichBox.SelectionStart = recRichBox.Text.Length;
            recRichBox.SelectionLength = 0;
            sendRichBox.Focus();
        }
    }
}
