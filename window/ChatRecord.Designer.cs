namespace SimpleChat.window
{
    partial class ChatRecord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatRecord));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageMenu = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bottomTools = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.firstPage = new System.Windows.Forms.LinkLabel();
            this.lastPage = new System.Windows.Forms.LinkLabel();
            this.prePage = new System.Windows.Forms.LinkLabel();
            this.nextPage = new System.Windows.Forms.LinkLabel();
            this.splitter = new System.Windows.Forms.Splitter();
            this.recordRichTB = new System.Windows.Forms.RichTextBox();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.topTools = new System.Windows.Forms.Panel();
            this.clearBtn = new System.Windows.Forms.Button();
            this.findBtn = new System.Windows.Forms.Button();
            this.contentTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.menuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.bottomTools.SuspendLayout();
            this.panel2.SuspendLayout();
            this.topTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(749, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.文件ToolStripMenuItem.Text = "文件(&F)";
            // 
            // 导出ToolStripMenuItem
            // 
            this.导出ToolStripMenuItem.Name = "导出ToolStripMenuItem";
            this.导出ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.导出ToolStripMenuItem.Text = "导出(&O)";
            this.导出ToolStripMenuItem.Click += new System.EventHandler(this.导出ToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 398);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "消息类型";
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(3, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(194, 376);
            this.listView1.SmallImageList = this.imageMenu;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // imageMenu
            // 
            this.imageMenu.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageMenu.ImageSize = new System.Drawing.Size(16, 16);
            this.imageMenu.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bottomTools);
            this.panel1.Controls.Add(this.splitter);
            this.panel1.Controls.Add(this.recordRichTB);
            this.panel1.Controls.Add(this.listView);
            this.panel1.Controls.Add(this.topTools);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 398);
            this.panel1.TabIndex = 2;
            // 
            // bottomTools
            // 
            this.bottomTools.Controls.Add(this.panel2);
            this.bottomTools.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomTools.Location = new System.Drawing.Point(200, 370);
            this.bottomTools.Name = "bottomTools";
            this.bottomTools.Size = new System.Drawing.Size(549, 28);
            this.bottomTools.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.firstPage);
            this.panel2.Controls.Add(this.lastPage);
            this.panel2.Controls.Add(this.prePage);
            this.panel2.Controls.Add(this.nextPage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(349, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 28);
            this.panel2.TabIndex = 4;
            // 
            // firstPage
            // 
            this.firstPage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstPage.AutoSize = true;
            this.firstPage.Location = new System.Drawing.Point(6, 4);
            this.firstPage.Name = "firstPage";
            this.firstPage.Size = new System.Drawing.Size(32, 17);
            this.firstPage.TabIndex = 0;
            this.firstPage.TabStop = true;
            this.firstPage.Text = "首页";
            this.firstPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.firstPage_LinkClicked);
            // 
            // lastPage
            // 
            this.lastPage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastPage.AutoSize = true;
            this.lastPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lastPage.Location = new System.Drawing.Point(145, 4);
            this.lastPage.Name = "lastPage";
            this.lastPage.Size = new System.Drawing.Size(32, 17);
            this.lastPage.TabIndex = 3;
            this.lastPage.TabStop = true;
            this.lastPage.Text = "尾页";
            this.lastPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lastPage_LinkClicked);
            // 
            // prePage
            // 
            this.prePage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prePage.AutoSize = true;
            this.prePage.Location = new System.Drawing.Point(45, 4);
            this.prePage.Name = "prePage";
            this.prePage.Size = new System.Drawing.Size(44, 17);
            this.prePage.TabIndex = 1;
            this.prePage.TabStop = true;
            this.prePage.Text = "上一页";
            this.prePage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.prePage_LinkClicked);
            // 
            // nextPage
            // 
            this.nextPage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nextPage.AutoSize = true;
            this.nextPage.Location = new System.Drawing.Point(95, 4);
            this.nextPage.Name = "nextPage";
            this.nextPage.Size = new System.Drawing.Size(44, 17);
            this.nextPage.TabIndex = 2;
            this.nextPage.TabStop = true;
            this.nextPage.Text = "下一页";
            this.nextPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.nextPage_LinkClicked);
            // 
            // splitter
            // 
            this.splitter.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter.Location = new System.Drawing.Point(200, 204);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(549, 5);
            this.splitter.TabIndex = 5;
            this.splitter.TabStop = false;
            // 
            // recordRichTB
            // 
            this.recordRichTB.BackColor = System.Drawing.SystemColors.Window;
            this.recordRichTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recordRichTB.Location = new System.Drawing.Point(200, 204);
            this.recordRichTB.Name = "recordRichTB";
            this.recordRichTB.ReadOnly = true;
            this.recordRichTB.Size = new System.Drawing.Size(549, 194);
            this.recordRichTB.TabIndex = 4;
            this.recordRichTB.Text = "";
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView.Dock = System.Windows.Forms.DockStyle.Top;
            this.listView.FullRowSelect = true;
            this.listView.Location = new System.Drawing.Point(200, 38);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(549, 166);
            this.listView.SmallImageList = this.imageList;
            this.listView.TabIndex = 3;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "联系人";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "最后通话时间";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "信息条数";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 195;
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // topTools
            // 
            this.topTools.Controls.Add(this.clearBtn);
            this.topTools.Controls.Add(this.findBtn);
            this.topTools.Controls.Add(this.contentTB);
            this.topTools.Controls.Add(this.label2);
            this.topTools.Controls.Add(this.label1);
            this.topTools.Controls.Add(this.nameTB);
            this.topTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.topTools.Location = new System.Drawing.Point(200, 0);
            this.topTools.Name = "topTools";
            this.topTools.Size = new System.Drawing.Size(549, 38);
            this.topTools.TabIndex = 2;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(462, 9);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 5;
            this.clearBtn.Text = "清除";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // findBtn
            // 
            this.findBtn.Location = new System.Drawing.Point(376, 9);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(75, 23);
            this.findBtn.TabIndex = 4;
            this.findBtn.Text = "查找";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // contentTB
            // 
            this.contentTB.Location = new System.Drawing.Point(254, 9);
            this.contentTB.Name = "contentTB";
            this.contentTB.Size = new System.Drawing.Size(100, 23);
            this.contentTB.TabIndex = 3;
            this.contentTB.TextChanged += new System.EventHandler(this.contentTB_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "内容：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "姓名或账号：";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(95, 9);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(100, 23);
            this.nameTB.TabIndex = 0;
            this.nameTB.TextChanged += new System.EventHandler(this.nameTB_TextChanged);
            // 
            // ChatRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 423);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ChatRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "消息管理器";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.bottomTools.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.topTools.ResumeLayout(false);
            this.topTools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel topTools;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Panel bottomTools;
        private System.Windows.Forms.Splitter splitter;
        private System.Windows.Forms.RichTextBox recordRichTB;
        private System.Windows.Forms.LinkLabel lastPage;
        private System.Windows.Forms.LinkLabel nextPage;
        private System.Windows.Forms.LinkLabel prePage;
        private System.Windows.Forms.LinkLabel firstPage;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.TextBox contentTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ToolStripMenuItem 导出ToolStripMenuItem;
        private System.Windows.Forms.ImageList imageMenu;
        private System.Windows.Forms.Panel panel2;
    }
}