using OfficeOpenXml;
using SimpleChat.data.db3model;
using SimpleChat.model;
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

namespace SimpleChat.window
{
    public partial class SaveDataToExcelForm : Form
    {
        public SaveDataToExcelForm(string filename, List<User> userList, List<List<UserChatRecord>> recordList)
        {
            InitializeComponent();
            this.filename = filename;
            this.userList = userList;
            this.recordList = recordList;
        }

        private string filename = "";

        private List<User> userList;

        List<List<UserChatRecord>> recordList;

        public void SaveToExcel()
        {
            int gap = (int)(100 / userList.Count);
            using (ExcelPackage excel = new ExcelPackage())
            {
                for(int i=0;i<userList.Count;i++)
                {
                    excel.Workbook.Worksheets.Add(userList[i].Name);
                    var headerRow = new List<string[]>()
                    {
                        new string[]
                        {
                            "时间", "角色", "内容"
                        }
                     };
                    string headerRange = "A1:C1";
                    var worksheet = excel.Workbook.Worksheets[userList[i].Name];
                    worksheet.Cells[headerRange].LoadFromArrays(headerRow);
                    List<UserChatRecord> ucList = recordList[i];
                    for(int j = 0; j<ucList.Count;j++)
                    {
                        descriptionlable.BeginInvoke(new Action<int>((ii) =>
                        {
                            descriptionlable.Text = "当前正在处理：" + (ii + 1).ToString() + "/" + userList.Count.ToString();
                        }), new Object[] { j });
                        worksheet.Cells[j + 2, 1].Value = ucList[j].Time.ToString("yyyy-MM-dd HH:mm:ss");
                        worksheet.Cells[j + 2, 2].Value = ucList[j].Role == 0 ? "自己" : "对方";
                        worksheet.Cells[j + 2, 3].Value = ucList[j].Content;
                    }
                    progressBar.BeginInvoke(new Action(() => { progressBar.Value = i * gap; }));
                }
                FileInfo excelFile = new FileInfo(filename);
                excel.SaveAs(excelFile);
                progressBar.BeginInvoke(new Action(() =>
                {
                    descriptionlable.Text = "已完成！";
                    progressBar.Value = 100;
                }));
            }
        }

        private async void SaveDataToExcelForm_Shown(object sender, EventArgs e)
        {
            await Task.Run(() => SaveToExcel());
        }

        private void SaveDataToExcelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (progressBar.Value < 100)
            {
                if (MessageBox.Show("未完成是否确认退出？", "警告",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }
    }
}
