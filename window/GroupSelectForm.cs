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

namespace SimpleChat.window
{
    public partial class GroupSelectForm : Form
    {
        private int id;

        private int destid;

        public string group;

        private int operationType;

        public bool issuccess = false;

        public GroupSelectForm(int id,int destid, int operationType)
        {
            InitializeComponent();
            this.id = id;
            this.destid = destid;
            this.operationType = operationType;
        }

        public void Init()
        {
            groupComBox.DataSource = GlobalClass.Groups;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if(operationType == 1) //添加好友
            {
                MessageType msg = new MessageType(GlobalClass.CurrentUser.Id, destid, groupComBox.Text, 2);
                TCPUtil.socketSend.Send(msg.ToJsonBytes()); //发送好友请求
                MessageBox.Show("发送成功，请等待对方验证！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(operationType == 2) //被添加好友
            {
                JObject obj = new JObject();
                obj.Add("id", GlobalClass.CurrentUser.Id);
                obj.Add("destid", destid);
                obj.Add("thisgroup", groupComBox.Text);
                obj.Add("thatgroup", group);
                string result = HTTPUtil.SendPostRequest(Util.GetHttpUrl() + "/addfriends", obj.ToString());
                if(result == "添加成功！")
                {
                    MessageBox.Show(result, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    issuccess = true;
                }
                else
                {
                    MessageBox.Show(result, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    issuccess = false;
                }
            }
            Close();
        }
    }
}
