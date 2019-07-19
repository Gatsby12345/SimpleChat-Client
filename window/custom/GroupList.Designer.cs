namespace SimpleChat.window.custom
{
    partial class GroupList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.headimage = new System.Windows.Forms.PictureBox();
            this.name = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.Label();
            this.agreeBtn = new System.Windows.Forms.Button();
            this.refuseBtn = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.Label();
            this.yrefuseBtn = new System.Windows.Forms.Button();
            this.yagreeBtn = new System.Windows.Forms.Button();
            this.destId = new System.Windows.Forms.Label();
            this.waitCheck = new System.Windows.Forms.Label();
            this.checkSucceed = new System.Windows.Forms.Label();
            this.checkFail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.headimage)).BeginInit();
            this.SuspendLayout();
            // 
            // headimage
            // 
            this.headimage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.headimage.Location = new System.Drawing.Point(26, 34);
            this.headimage.Name = "headimage";
            this.headimage.Size = new System.Drawing.Size(60, 60);
            this.headimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.headimage.TabIndex = 0;
            this.headimage.TabStop = false;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("SimHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.name.Location = new System.Drawing.Point(99, 49);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(41, 12);
            this.name.TabIndex = 1;
            this.name.Text = "label1";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Font = new System.Drawing.Font("SimHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.age.Location = new System.Drawing.Point(216, 49);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(41, 12);
            this.age.TabIndex = 2;
            this.age.Text = "label2";
            // 
            // sex
            // 
            this.sex.AutoSize = true;
            this.sex.Font = new System.Drawing.Font("SimHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sex.Location = new System.Drawing.Point(159, 49);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(41, 12);
            this.sex.TabIndex = 3;
            this.sex.Text = "label3";
            // 
            // agreeBtn
            // 
            this.agreeBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.agreeBtn.Location = new System.Drawing.Point(312, 44);
            this.agreeBtn.Name = "agreeBtn";
            this.agreeBtn.Size = new System.Drawing.Size(75, 23);
            this.agreeBtn.TabIndex = 4;
            this.agreeBtn.Text = "同意";
            this.agreeBtn.UseVisualStyleBackColor = true;
            this.agreeBtn.Visible = false;
            this.agreeBtn.Click += new System.EventHandler(this.agreeBtn_Click);
            // 
            // refuseBtn
            // 
            this.refuseBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.refuseBtn.Location = new System.Drawing.Point(420, 44);
            this.refuseBtn.Name = "refuseBtn";
            this.refuseBtn.Size = new System.Drawing.Size(75, 23);
            this.refuseBtn.TabIndex = 5;
            this.refuseBtn.Text = "拒绝";
            this.refuseBtn.UseVisualStyleBackColor = true;
            this.refuseBtn.Visible = false;
            this.refuseBtn.Click += new System.EventHandler(this.refuseBtn_Click);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("SimHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.date.Location = new System.Drawing.Point(24, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(41, 12);
            this.date.TabIndex = 6;
            this.date.Text = "label1";
            // 
            // yrefuseBtn
            // 
            this.yrefuseBtn.Enabled = false;
            this.yrefuseBtn.Location = new System.Drawing.Point(361, 44);
            this.yrefuseBtn.Name = "yrefuseBtn";
            this.yrefuseBtn.Size = new System.Drawing.Size(75, 23);
            this.yrefuseBtn.TabIndex = 7;
            this.yrefuseBtn.Text = "已拒绝";
            this.yrefuseBtn.UseVisualStyleBackColor = true;
            this.yrefuseBtn.Visible = false;
            // 
            // yagreeBtn
            // 
            this.yagreeBtn.Enabled = false;
            this.yagreeBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.yagreeBtn.Location = new System.Drawing.Point(362, 44);
            this.yagreeBtn.Name = "yagreeBtn";
            this.yagreeBtn.Size = new System.Drawing.Size(75, 23);
            this.yagreeBtn.TabIndex = 8;
            this.yagreeBtn.Text = "已同意";
            this.yagreeBtn.UseVisualStyleBackColor = true;
            this.yagreeBtn.Visible = false;
            // 
            // destId
            // 
            this.destId.AutoSize = true;
            this.destId.Location = new System.Drawing.Point(204, 75);
            this.destId.Name = "destId";
            this.destId.Size = new System.Drawing.Size(41, 12);
            this.destId.TabIndex = 9;
            this.destId.Text = "label1";
            this.destId.Visible = false;
            // 
            // waitCheck
            // 
            this.waitCheck.AutoSize = true;
            this.waitCheck.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.waitCheck.Location = new System.Drawing.Point(373, 46);
            this.waitCheck.Name = "waitCheck";
            this.waitCheck.Size = new System.Drawing.Size(56, 17);
            this.waitCheck.TabIndex = 10;
            this.waitCheck.Text = "等待验证";
            // 
            // checkSucceed
            // 
            this.checkSucceed.AutoSize = true;
            this.checkSucceed.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkSucceed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.checkSucceed.Location = new System.Drawing.Point(359, 47);
            this.checkSucceed.Name = "checkSucceed";
            this.checkSucceed.Size = new System.Drawing.Size(92, 17);
            this.checkSucceed.TabIndex = 11;
            this.checkSucceed.Text = "好友申请已通过";
            // 
            // checkFail
            // 
            this.checkFail.AutoSize = true;
            this.checkFail.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkFail.ForeColor = System.Drawing.Color.Red;
            this.checkFail.Location = new System.Drawing.Point(359, 46);
            this.checkFail.Name = "checkFail";
            this.checkFail.Size = new System.Drawing.Size(92, 17);
            this.checkFail.TabIndex = 12;
            this.checkFail.Text = "好友申请未通过";
            // 
            // GroupList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.checkFail);
            this.Controls.Add(this.checkSucceed);
            this.Controls.Add(this.waitCheck);
            this.Controls.Add(this.destId);
            this.Controls.Add(this.yagreeBtn);
            this.Controls.Add(this.yrefuseBtn);
            this.Controls.Add(this.date);
            this.Controls.Add(this.refuseBtn);
            this.Controls.Add(this.agreeBtn);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.age);
            this.Controls.Add(this.name);
            this.Controls.Add(this.headimage);
            this.Name = "GroupList";
            this.Size = new System.Drawing.Size(498, 109);
            ((System.ComponentModel.ISupportInitialize)(this.headimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox headimage;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label sex;
        private System.Windows.Forms.Button agreeBtn;
        private System.Windows.Forms.Button refuseBtn;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Button yrefuseBtn;
        private System.Windows.Forms.Button yagreeBtn;
        private System.Windows.Forms.Label destId;
        private System.Windows.Forms.Label waitCheck;
        private System.Windows.Forms.Label checkSucceed;
        private System.Windows.Forms.Label checkFail;
    }
}
