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
using SimpleChat.server;
using SimpleChat.model;
using SimpleChat.pub;
using Message = SimpleChat.model.MessageType;

namespace SimpleChat.window
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string accountStr = account.Text;
            string pwd = password.Text;
            if (string.IsNullOrEmpty(accountStr))
            {
                MessageBox.Show("请输入账号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("请输入密码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string url = Util.GetHttpUrl() + "/login/" +accountStr + "/"+pwd;
            string result = HTTPUtil.SendGetRequest(url);
            if(result != "登录失败！")
            {
                JObject userObj = JObject.Parse(result);
                int id = int.Parse(userObj["id"].ToString());
                Message msg = new Message(id, 0, "", 0);
                this.Hide();
                User user = User.GetUserByStr(result);
                GlobalClass.CurrentUser = user;
                GlobalClass.Groups = Util.GetGroups(user.Friends);
                MainForm mainForm = new MainForm();
                mainForm.Init();
                GlobalClass.mf = mainForm;
                mainForm.Show();
                try
                {
                    TCPUtil.socketSend.Send(msg.ToJsonBytes());
                }
                catch (Exception)
                {
                    MessageBox.Show("请检查网络！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(0);
                }
            }
            else
            {
                MessageBox.Show(result, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void registBtn_Click(object sender, EventArgs e)
        {
            Regist r = new Regist();
            r.ShowDialog();
        }

        private void account_TextChanged(object sender, EventArgs e)
        {
            string accTBStr = account.Text;
            if (accTBStr != "")
            {
                if ((accTBStr = Util.CheckSpecialChar(accTBStr)) != null)
                {
                    account.Text = accTBStr;
                    account.Select(accTBStr.Length, 0);
                }
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
