using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
    public partial class Regist : Form
    {
        public Regist()
        {
            InitializeComponent();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            string account = accTB.Text;

            string pwd = pwdTB.Text;

            string conPwd = conTB.Text;

            string name = nameTB.Text;

            DateTime birth = birthTP.Value;

            bool maleChecked = male.Checked;

            bool famaleChecked = famale.Checked;

            string fileName = pathTB.Text;

            if(string.IsNullOrEmpty(account))
            {
                MessageBox.Show("请输入账号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("请输入密码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (pwd.Length < 6)
            {
                MessageBox.Show("密码应不低于6位", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(conPwd))
            {
                MessageBox.Show("请输入确认密码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (conPwd != pwd)
            {
                MessageBox.Show("两次密码不一致", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(account))
            {
                MessageBox.Show("请输入昵称", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!famaleChecked && !maleChecked)
            {
                MessageBox.Show("请选择性别", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string headimage = "";
            if (!string.IsNullOrEmpty(fileName))
            {
                bool isExistFile = File.Exists(fileName);
                if (!isExistFile)
                {
                    MessageBox.Show("头像文件格式不正确或文件不存在", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                Tuple<bool, string> tuple = Util.GetBase64StrByImage(fileName);
                if(tuple.Item1)
                {
                    MessageBox.Show("文件超过大小的限制", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                headimage = tuple.Item2;
            }
            char sex = maleChecked ? '男' : '女';

            JObject obj = new JObject();
            obj.Add("account", account);
            obj.Add("password", pwd);
            obj.Add("name", name);
            obj.Add("sex", sex);
            obj.Add("birthday", birth);
            obj.Add("headimage", headimage);
            JArray jArray = new JArray();
            JObject jObject = new JObject();
            jObject.Add("name", "我的好友");
            jObject.Add("members", "");
            jArray.Add(jObject);
            obj.Add("friends", jArray.ToString());
            string result = HTTPUtil.SendPostRequest(Util.GetHttpUrl() + "/regist",obj.ToString());
            if (result != "注册失败！")
            {
                MessageBox.Show("注册成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                StyleConfig sc = new StyleConfig()
                {
                    UserId = int.Parse(result),
                    Color = 0,
                    Size = 12.0f,
                    FontFamily = "楷体",
                    FontStyle = 1
                };
                StyleConfigManager.AddConfig(sc);
                this.Close();
            }
            else
            {
                MessageBox.Show("result", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void accTB_TextChanged(object sender, EventArgs e)
        {
            string accTBStr = accTB.Text;
            if(accTBStr != "")
            {
                if ((accTBStr = Util.CheckSpecialChar(accTBStr)) != null)
                {
                    accTB.Text = accTBStr;
                    accTB.Select(accTBStr.Length, 0);
                }
            }
        }

        private void nameTB_TextChanged(object sender, EventArgs e)
        {
            string nameTBStr = nameTB.Text;
            if (nameTBStr != "")
            {
                if ((nameTBStr = Util.CheckSpecialChar(nameTBStr)) != null)
                {
                    accTB.Text = nameTBStr;
                    accTB.Select(nameTBStr.Length, 0);
                }
            }
        }

        private void selectImageBtn_Click(object sender, EventArgs e)
        {
            //选择文件
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;//该值确定是否可以选择多个文件
            dialog.Title = "请选择图片";
            dialog.Filter = "图片|*.jpg;*.png;*.gif;*.jpeg;*.bmp";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string file = dialog.FileName;
                pathTB.Text = file;
            }
        }
    }
}
