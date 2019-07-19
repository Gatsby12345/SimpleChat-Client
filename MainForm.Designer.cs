namespace SimpleChat
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.searchBox = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.friendsTree = new System.Windows.Forms.TreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.search = new System.Windows.Forms.Button();
            this.headImage = new System.Windows.Forms.PictureBox();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.FRBtn = new System.Windows.Forms.Button();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.treePanel = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.联系人ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加联系人ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于我们ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.显示主界面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.userMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.发送消息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.修改名称ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除分组ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.增加分组ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headImage)).BeginInit();
            this.infoPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.treePanel.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.userMenu.SuspendLayout();
            this.groupMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchBox.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.searchBox.ForeColor = System.Drawing.Color.Gray;
            this.searchBox.Location = new System.Drawing.Point(0, 0);
            this.searchBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(206, 23);
            this.searchBox.TabIndex = 0;
            this.searchBox.TabStop = false;
            this.searchBox.Text = "可输入账号或者昵称查找";
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            this.searchBox.Enter += new System.EventHandler(this.searchBox_Enter);
            this.searchBox.Leave += new System.EventHandler(this.searchBox_Leave);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(87, 30);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(0, 17);
            this.name.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(293, 440);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 2;
            this.tabControl1.TabStop = false;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.friendsTree);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(285, 410);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "联系人";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // friendsTree
            // 
            this.friendsTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.friendsTree.Location = new System.Drawing.Point(3, 4);
            this.friendsTree.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.friendsTree.Name = "friendsTree";
            this.friendsTree.Size = new System.Drawing.Size(279, 402);
            this.friendsTree.TabIndex = 0;
            this.friendsTree.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.friendsTree_AfterLabelEdit);
            this.friendsTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.friendsTree_NodeMouseClick);
            this.friendsTree.DoubleClick += new System.EventHandler(this.friendsTree_DoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(285, 410);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "讨论组";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Size = new System.Drawing.Size(285, 410);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "最近联系";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // search
            // 
            this.search.Dock = System.Windows.Forms.DockStyle.Right;
            this.search.Location = new System.Drawing.Point(206, 0);
            this.search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(87, 23);
            this.search.TabIndex = 3;
            this.search.TabStop = false;
            this.search.Text = "查找";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // headImage
            // 
            this.headImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.headImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.headImage.Location = new System.Drawing.Point(0, 0);
            this.headImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.headImage.Name = "headImage";
            this.headImage.Size = new System.Drawing.Size(71, 69);
            this.headImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.headImage.TabIndex = 4;
            this.headImage.TabStop = false;
            this.headImage.Click += new System.EventHandler(this.headImage_Click);
            // 
            // infoPanel
            // 
            this.infoPanel.Controls.Add(this.FRBtn);
            this.infoPanel.Controls.Add(this.headImage);
            this.infoPanel.Controls.Add(this.name);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoPanel.Location = new System.Drawing.Point(0, 27);
            this.infoPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(293, 69);
            this.infoPanel.TabIndex = 5;
            // 
            // FRBtn
            // 
            this.FRBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.FRBtn.Location = new System.Drawing.Point(191, 20);
            this.FRBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FRBtn.Name = "FRBtn";
            this.FRBtn.Size = new System.Drawing.Size(101, 33);
            this.FRBtn.TabIndex = 0;
            this.FRBtn.TabStop = false;
            this.FRBtn.Text = "验证消息管理";
            this.FRBtn.UseVisualStyleBackColor = true;
            this.FRBtn.Click += new System.EventHandler(this.FRBtn_Click);
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.searchBox);
            this.searchPanel.Controls.Add(this.search);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchPanel.Location = new System.Drawing.Point(0, 96);
            this.searchPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(293, 23);
            this.searchPanel.TabIndex = 6;
            // 
            // treePanel
            // 
            this.treePanel.Controls.Add(this.tabControl1);
            this.treePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treePanel.Location = new System.Drawing.Point(0, 119);
            this.treePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.treePanel.Name = "treePanel";
            this.treePanel.Size = new System.Drawing.Size(293, 440);
            this.treePanel.TabIndex = 7;
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(293, 27);
            this.menuStrip.TabIndex = 8;
            this.menuStrip.Text = "menuStrip";
            // 
            // 联系人ToolStripMenuItem
            // 
            this.联系人ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加联系人ToolStripMenuItem});
            this.联系人ToolStripMenuItem.Name = "联系人ToolStripMenuItem";
            this.联系人ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.联系人ToolStripMenuItem.Size = new System.Drawing.Size(72, 21);
            this.联系人ToolStripMenuItem.Text = "联系人(&C)";
            // 
            // 添加联系人ToolStripMenuItem
            // 
            this.添加联系人ToolStripMenuItem.Name = "添加联系人ToolStripMenuItem";
            this.添加联系人ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.添加联系人ToolStripMenuItem.Text = "添加联系人(&I)";
            this.添加联系人ToolStripMenuItem.Click += new System.EventHandler(this.添加联系人ToolStripMenuItem_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于我们ToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 关于我们ToolStripMenuItem
            // 
            this.关于我们ToolStripMenuItem.Name = "关于我们ToolStripMenuItem";
            this.关于我们ToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.关于我们ToolStripMenuItem.Text = "关于我们(&A)";
            this.关于我们ToolStripMenuItem.Click += new System.EventHandler(this.关于我们ToolStripMenuItem_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            this.notifyIcon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseMove);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示主界面ToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(137, 26);
            // 
            // 显示主界面ToolStripMenuItem
            // 
            this.显示主界面ToolStripMenuItem.Name = "显示主界面ToolStripMenuItem";
            this.显示主界面ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.显示主界面ToolStripMenuItem.Text = "显示主界面";
            this.显示主界面ToolStripMenuItem.Click += new System.EventHandler(this.显示主界面ToolStripMenuItem_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // userMenu
            // 
            this.userMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.发送消息ToolStripMenuItem});
            this.userMenu.Name = "userMenu";
            this.userMenu.Size = new System.Drawing.Size(149, 26);
            // 
            // 发送消息ToolStripMenuItem
            // 
            this.发送消息ToolStripMenuItem.Name = "发送消息ToolStripMenuItem";
            this.发送消息ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.发送消息ToolStripMenuItem.Text = "发送即时消息";
            this.发送消息ToolStripMenuItem.Click += new System.EventHandler(this.发送消息ToolStripMenuItem_Click);
            // 
            // groupMenu
            // 
            this.groupMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改名称ToolStripMenuItem,
            this.删除分组ToolStripMenuItem,
            this.增加分组ToolStripMenuItem});
            this.groupMenu.Name = "groupMenu";
            this.groupMenu.Size = new System.Drawing.Size(125, 70);
            // 
            // 修改名称ToolStripMenuItem
            // 
            this.修改名称ToolStripMenuItem.Name = "修改名称ToolStripMenuItem";
            this.修改名称ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.修改名称ToolStripMenuItem.Text = "修改名称";
            this.修改名称ToolStripMenuItem.Click += new System.EventHandler(this.修改名称ToolStripMenuItem_Click);
            // 
            // 删除分组ToolStripMenuItem
            // 
            this.删除分组ToolStripMenuItem.Name = "删除分组ToolStripMenuItem";
            this.删除分组ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.删除分组ToolStripMenuItem.Text = "删除分组";
            this.删除分组ToolStripMenuItem.Click += new System.EventHandler(this.删除分组ToolStripMenuItem_Click);
            // 
            // 增加分组ToolStripMenuItem
            // 
            this.增加分组ToolStripMenuItem.Name = "增加分组ToolStripMenuItem";
            this.增加分组ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.增加分组ToolStripMenuItem.Text = "添加分组";
            this.增加分组ToolStripMenuItem.Click += new System.EventHandler(this.添加分组ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 559);
            this.Controls.Add(this.treePanel);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleChat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.headImage)).EndInit();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.treePanel.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.userMenu.ResumeLayout(false);
            this.groupMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.PictureBox headImage;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Panel treePanel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 联系人ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加联系人ToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 显示主界面ToolStripMenuItem;
        private System.Windows.Forms.TreeView friendsTree;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button FRBtn;
        private System.Windows.Forms.ContextMenuStrip userMenu;
        private System.Windows.Forms.ToolStripMenuItem 发送消息ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip groupMenu;
        private System.Windows.Forms.ToolStripMenuItem 修改名称ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除分组ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 增加分组ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于我们ToolStripMenuItem;
    }
}

