using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleChat.pub;

namespace SimpleChat.window
{
    public partial class AddGroupForm : Form
    {
        public AddGroupForm()
        {
            InitializeComponent();
        }

        public string groupname;

        public bool IsOk;

        private void OkBtn_Click(object sender, EventArgs e)
        {
            string groupName = groupBox.Text;
            if(string.IsNullOrEmpty(groupName))
            {
                MessageBox.Show("组名不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            IsOk = true;
            groupname = groupName;
            Close();
        }

        private void groupBox_TextChanged(object sender, EventArgs e)
        {
            string accTBStr = groupBox.Text;
            if (accTBStr != "")
            {
                if ((accTBStr = Util.CheckSpecialChar(accTBStr)) != null)
                {
                    groupBox.Text = accTBStr;
                    groupBox.Select(accTBStr.Length, 0);
                }
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            IsOk = false;
            Close();
        }
    }
}
