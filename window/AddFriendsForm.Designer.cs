namespace SimpleChat.window
{
    partial class AddFriendsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFriendsForm));
            this.searchTB = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.onlineCheckBox = new System.Windows.Forms.CheckBox();
            this.ageCB = new System.Windows.Forms.ComboBox();
            this.sexCB = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.buttonPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchTB
            // 
            this.searchTB.ForeColor = System.Drawing.Color.LightGray;
            this.searchTB.Location = new System.Drawing.Point(86, 23);
            this.searchTB.Margin = new System.Windows.Forms.Padding(2);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(243, 21);
            this.searchTB.TabIndex = 0;
            this.searchTB.Text = "可输入账号、昵称等进行查询";
            this.searchTB.TextChanged += new System.EventHandler(this.searchTB_TextChanged);
            this.searchTB.Enter += new System.EventHandler(this.searchTB_Enter);
            this.searchTB.Leave += new System.EventHandler(this.searchTB_Leave);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(353, 22);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(56, 22);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "查找";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // onlineCheckBox
            // 
            this.onlineCheckBox.AutoSize = true;
            this.onlineCheckBox.Location = new System.Drawing.Point(281, 59);
            this.onlineCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.onlineCheckBox.Name = "onlineCheckBox";
            this.onlineCheckBox.Size = new System.Drawing.Size(48, 16);
            this.onlineCheckBox.TabIndex = 2;
            this.onlineCheckBox.Text = "在线";
            this.onlineCheckBox.UseVisualStyleBackColor = true;
            // 
            // ageCB
            // 
            this.ageCB.FormattingEnabled = true;
            this.ageCB.Items.AddRange(new object[] {
            "不限",
            "18岁以下",
            "18-22岁",
            "23-26岁",
            "27-35岁",
            "35岁以上"});
            this.ageCB.Location = new System.Drawing.Point(86, 57);
            this.ageCB.Margin = new System.Windows.Forms.Padding(2);
            this.ageCB.Name = "ageCB";
            this.ageCB.Size = new System.Drawing.Size(72, 20);
            this.ageCB.TabIndex = 3;
            this.ageCB.Text = "年龄";
            // 
            // sexCB
            // 
            this.sexCB.FormattingEnabled = true;
            this.sexCB.Items.AddRange(new object[] {
            "不限",
            "男",
            "女"});
            this.sexCB.Location = new System.Drawing.Point(192, 57);
            this.sexCB.Margin = new System.Windows.Forms.Padding(2);
            this.sexCB.Name = "sexCB";
            this.sexCB.Size = new System.Drawing.Size(67, 20);
            this.sexCB.TabIndex = 4;
            this.sexCB.Text = "性别";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.buttonPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 153);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 225);
            this.panel1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGrid);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 46);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(644, 179);
            this.panel3.TabIndex = 1;
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column5});
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(0, 0);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowTemplate.Height = 23;
            this.dataGrid.Size = new System.Drawing.Size(644, 179);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.Visible = false;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "account";
            this.Column1.HeaderText = "账号";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "name";
            this.Column2.HeaderText = "昵称";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "sex";
            this.Column3.HeaderText = "性别";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "birthday";
            this.Column4.HeaderText = "生日";
            this.Column4.Name = "Column4";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "online";
            this.Column6.HeaderText = "状态";
            this.Column6.Name = "Column6";
            // 
            // Column5
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.NullValue = "添加好友";
            this.Column5.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column5.HeaderText = "操作";
            this.Column5.Name = "Column5";
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.label1);
            this.buttonPanel.Controls.Add(this.backBtn);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPanel.Location = new System.Drawing.Point(0, 0);
            this.buttonPanel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(644, 46);
            this.buttonPanel.TabIndex = 0;
            this.buttonPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "好友推荐";
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(22, 9);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(56, 28);
            this.backBtn.TabIndex = 0;
            this.backBtn.Text = "返回";
            this.backBtn.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.searchBtn);
            this.panel2.Controls.Add(this.sexCB);
            this.panel2.Controls.Add(this.searchTB);
            this.panel2.Controls.Add(this.onlineCheckBox);
            this.panel2.Controls.Add(this.ageCB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(644, 153);
            this.panel2.TabIndex = 6;
            // 
            // AddFriendsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 378);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "AddFriendsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查找";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.buttonPanel.ResumeLayout(false);
            this.buttonPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.CheckBox onlineCheckBox;
        private System.Windows.Forms.ComboBox ageCB;
        private System.Windows.Forms.ComboBox sexCB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
    }
}