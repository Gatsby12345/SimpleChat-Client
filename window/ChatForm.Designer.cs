namespace SimpleChat.window
{
    partial class Chat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chat));
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.sendBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sendRichBox = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chatRecordBtn = new System.Windows.Forms.Button();
            this.changeColorBtn = new System.Windows.Forms.Button();
            this.changeFontBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.recRichBox = new System.Windows.Forms.RichTextBox();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.sendBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 356);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 47);
            this.panel1.TabIndex = 0;
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(558, 13);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(66, 29);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.TabStop = false;
            this.closeBtn.Text = "关闭";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(630, 13);
            this.sendBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(68, 29);
            this.sendBtn.TabIndex = 0;
            this.sendBtn.TabStop = false;
            this.sendBtn.Text = "发送";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.sendRichBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 214);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(701, 142);
            this.panel2.TabIndex = 1;
            // 
            // sendRichBox
            // 
            this.sendRichBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sendRichBox.Location = new System.Drawing.Point(0, 0);
            this.sendRichBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sendRichBox.Name = "sendRichBox";
            this.sendRichBox.Size = new System.Drawing.Size(701, 142);
            this.sendRichBox.TabIndex = 0;
            this.sendRichBox.TabStop = false;
            this.sendRichBox.Text = "";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chatRecordBtn);
            this.panel3.Controls.Add(this.changeColorBtn);
            this.panel3.Controls.Add(this.changeFontBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 183);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(701, 31);
            this.panel3.TabIndex = 2;
            // 
            // chatRecordBtn
            // 
            this.chatRecordBtn.Location = new System.Drawing.Point(614, 3);
            this.chatRecordBtn.Name = "chatRecordBtn";
            this.chatRecordBtn.Size = new System.Drawing.Size(75, 23);
            this.chatRecordBtn.TabIndex = 6;
            this.chatRecordBtn.TabStop = false;
            this.chatRecordBtn.Text = "消息记录";
            this.chatRecordBtn.UseVisualStyleBackColor = true;
            this.chatRecordBtn.Click += new System.EventHandler(this.chatRecordBtn_Click);
            // 
            // changeColorBtn
            // 
            this.changeColorBtn.Location = new System.Drawing.Point(87, 3);
            this.changeColorBtn.Name = "changeColorBtn";
            this.changeColorBtn.Size = new System.Drawing.Size(75, 23);
            this.changeColorBtn.TabIndex = 5;
            this.changeColorBtn.TabStop = false;
            this.changeColorBtn.Text = "设置颜色";
            this.changeColorBtn.UseVisualStyleBackColor = true;
            this.changeColorBtn.Click += new System.EventHandler(this.changeColorBtn_Click);
            // 
            // changeFontBtn
            // 
            this.changeFontBtn.Location = new System.Drawing.Point(12, 3);
            this.changeFontBtn.Name = "changeFontBtn";
            this.changeFontBtn.Size = new System.Drawing.Size(69, 23);
            this.changeFontBtn.TabIndex = 4;
            this.changeFontBtn.TabStop = false;
            this.changeFontBtn.Text = "设置字体";
            this.changeFontBtn.UseVisualStyleBackColor = true;
            this.changeFontBtn.Click += new System.EventHandler(this.changeFontBtn_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.recRichBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(701, 183);
            this.panel4.TabIndex = 3;
            // 
            // recRichBox
            // 
            this.recRichBox.BackColor = System.Drawing.SystemColors.Window;
            this.recRichBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recRichBox.Location = new System.Drawing.Point(0, 0);
            this.recRichBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recRichBox.Name = "recRichBox";
            this.recRichBox.ReadOnly = true;
            this.recRichBox.Size = new System.Drawing.Size(701, 183);
            this.recRichBox.TabIndex = 0;
            this.recRichBox.TabStop = false;
            this.recRichBox.Text = "";
            // 
            // fontDialog
            // 
            this.fontDialog.AllowScriptChange = false;
            this.fontDialog.ShowColor = true;
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 403);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Chat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Chat_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox sendRichBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox recRichBox;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.Button changeFontBtn;
        private System.Windows.Forms.Button changeColorBtn;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button chatRecordBtn;
    }
}