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
using SimpleChat.data.db3model;
using SimpleChat.pub;
using SimpleChat.server;
using Newtonsoft.Json.Linq;

namespace SimpleChat.window.custom
{
    public partial class GroupList : UserControl
    {
        public GroupList()
        {
            InitializeComponent();
        }

        public FriendsReq fr;

        public void Init()
        {
            destId.Text = fr.DestUser.Id.ToString();
            name.Text = fr.DestUser.Name;
            sex.Text = fr.DestUser.Sex.ToString();
            age.Text = ((int)((DateTime.Now - fr.DestUser.Birthday).TotalDays / 365)).ToString() + "岁";
            date.Text = fr.time.ToString();
            if(!string.IsNullOrEmpty(fr.DestUser.Headimage))
                headimage.Image = Util.GetImageByBase64Str(fr.DestUser.Headimage);
            else
            {
                headimage.Image = Properties.Resources.defalut;
            }
                
            SetControlStatus(fr);
        }

        private void SetControlStatus(FriendsReq fr)
        {
            if(GlobalClass.CurrentUser.Id == fr.destid)
            {
                if (fr.status == 0) //待审核
                {
                    agreeBtn.Visible = true;
                    refuseBtn.Visible = true;
                    yagreeBtn.Visible = false;
                    yrefuseBtn.Visible = false;
                    waitCheck.Visible = false;
                    checkFail.Visible = false;
                    checkSucceed.Visible = false;
                }
                else if (fr.status == 1) //已同意
                {
                    agreeBtn.Visible = false;
                    refuseBtn.Visible = false;
                    yagreeBtn.Visible = true;
                    yrefuseBtn.Visible = false;
                    waitCheck.Visible = false;
                    checkFail.Visible = false;
                    checkSucceed.Visible = false;
                }
                else if (fr.status == 2) //已拒绝
                {
                    agreeBtn.Visible = false;
                    refuseBtn.Visible = false;
                    yagreeBtn.Visible = false;
                    yrefuseBtn.Visible = true;
                    waitCheck.Visible = false;
                    checkFail.Visible = false;
                    checkSucceed.Visible = false;
                }
            }
            else
            {
                if (fr.status == 0) //等待验证
                {
                    agreeBtn.Visible = false;
                    refuseBtn.Visible = false;
                    yagreeBtn.Visible = false;
                    yrefuseBtn.Visible = false;
                    waitCheck.Visible = true;
                    checkFail.Visible = false;
                    checkSucceed.Visible = false;
                }
                else if (fr.status == 1) //验证成功
                {
                    agreeBtn.Visible = false;
                    refuseBtn.Visible = false;
                    yagreeBtn.Visible = false;
                    yrefuseBtn.Visible = false;
                    waitCheck.Visible = false;
                    checkFail.Visible = false;
                    checkSucceed.Visible = true;
                }
                else if (fr.status == 2) //验证失败
                {
                    agreeBtn.Visible = false;
                    refuseBtn.Visible = false;
                    yagreeBtn.Visible = false;
                    yrefuseBtn.Visible = false;
                    waitCheck.Visible = false;
                    checkFail.Visible = true;
                    checkSucceed.Visible = false;
                }
            }

            
        }

        private void agreeBtn_Click(object sender, EventArgs e)
        {
            GroupSelectForm gs = new GroupSelectForm(GlobalClass.CurrentUser.Id,int.Parse(destId.Text),2);
            gs.Init();
            gs.group = fr.groupname;
            gs.ShowDialog();
            if (gs.issuccess)
            {
                agreeBtn.Visible = false;
                refuseBtn.Visible = false;
                yagreeBtn.Visible = true;
                yrefuseBtn.Visible = false;
                waitCheck.Visible = false;
                checkFail.Visible = false;
                checkSucceed.Visible = false;
            }
            MessageType msg = new MessageType(GlobalClass.CurrentUser.Id, int.Parse(destId.Text),  "yes", 3);
            TCPUtil.socketSend.Send(msg.ToJsonBytes());
        }

        private void refuseBtn_Click(object sender, EventArgs e)
        {
            agreeBtn.Visible = false;
            refuseBtn.Visible = false;
            yagreeBtn.Visible = false;
            yrefuseBtn.Visible = true;
            waitCheck.Visible = false;
            checkFail.Visible = false;
            checkSucceed.Visible = false;
            MessageType mt = new MessageType(GlobalClass.CurrentUser.Id, int.Parse(destId.Text), "no", 3);
            TCPUtil.socketSend.Send(mt.ToJsonBytes());
        }
    }
}
