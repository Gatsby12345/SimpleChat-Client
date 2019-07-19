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
using SimpleChat.http;
using SimpleChat.pub;

namespace SimpleChat.window
{
    public partial class ChangeHeadImgForm : Form
    {
        public ChangeHeadImgForm()
        {
            InitializeComponent();
        }

        public string imageStr = "";

        public bool IsSuccess = false;

        public void Init()
        {
            if (string.IsNullOrEmpty(GlobalClass.CurrentUser.Headimage))
                headImage.Image = Properties.Resources.defalut;
            else
                headImage.Image = Util.GetImageByBase64Str(GlobalClass.CurrentUser.Headimage);
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            //选择文件
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;//该值确定是否可以选择多个文件
            dialog.Title = "请选择图片";
            dialog.Filter = "图片|*.jpg;*.png;*.gif;*.jpeg;*.bmp";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string file = dialog.FileName;
                Tuple<bool,string> tuple = Util.GetBase64StrByImage(file);
                if(tuple.Item1)
                {
                    MessageBox.Show("文件超过大小的限制", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                imageStr = tuple.Item2;
                headImage.Image = Util.GetImageByBase64Str(tuple.Item2);
            }
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(imageStr))
            {
                JObject obj = new JObject();
                obj.Add("id", GlobalClass.CurrentUser.Id);
                obj.Add("image", imageStr);
                string result = HTTPUtil.SendPostRequest(Util.GetHttpUrl() + "/updateimage", obj.ToString());
                if(result == "修改失败！")
                {
                    MessageBox.Show(result, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                IsSuccess = true;
                GlobalClass.CurrentUser.Headimage = imageStr;
            }
            Close();
        }
    }
}
