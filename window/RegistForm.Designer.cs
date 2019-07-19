namespace SimpleChat.window
{
    partial class Regist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Regist));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.accTB = new System.Windows.Forms.TextBox();
            this.pwdTB = new System.Windows.Forms.TextBox();
            this.conTB = new System.Windows.Forms.TextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.male = new System.Windows.Forms.RadioButton();
            this.famale = new System.Windows.Forms.RadioButton();
            this.birthTP = new System.Windows.Forms.DateTimePicker();
            this.okBtn = new System.Windows.Forms.Button();
            this.selectImageBtn = new System.Windows.Forms.Button();
            this.pathTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(67, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "账号(*)：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(67, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码(*)：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(67, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "确认密码(*)：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(67, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "昵称(*)：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(67, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "生日(*)：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(67, 455);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "性别(*)：";
            // 
            // accTB
            // 
            this.accTB.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.accTB.Location = new System.Drawing.Point(168, 83);
            this.accTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.accTB.MaxLength = 10;
            this.accTB.Name = "accTB";
            this.accTB.Size = new System.Drawing.Size(245, 23);
            this.accTB.TabIndex = 6;
            this.accTB.TextChanged += new System.EventHandler(this.accTB_TextChanged);
            // 
            // pwdTB
            // 
            this.pwdTB.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pwdTB.Location = new System.Drawing.Point(168, 160);
            this.pwdTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pwdTB.MaxLength = 16;
            this.pwdTB.Name = "pwdTB";
            this.pwdTB.PasswordChar = '*';
            this.pwdTB.Size = new System.Drawing.Size(245, 23);
            this.pwdTB.TabIndex = 7;
            // 
            // conTB
            // 
            this.conTB.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.conTB.Location = new System.Drawing.Point(168, 229);
            this.conTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.conTB.MaxLength = 16;
            this.conTB.Name = "conTB";
            this.conTB.PasswordChar = '*';
            this.conTB.Size = new System.Drawing.Size(245, 23);
            this.conTB.TabIndex = 8;
            // 
            // nameTB
            // 
            this.nameTB.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameTB.Location = new System.Drawing.Point(168, 303);
            this.nameTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameTB.MaxLength = 15;
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(245, 23);
            this.nameTB.TabIndex = 9;
            this.nameTB.TextChanged += new System.EventHandler(this.nameTB_TextChanged);
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.male.Location = new System.Drawing.Point(168, 451);
            this.male.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(38, 21);
            this.male.TabIndex = 10;
            this.male.TabStop = true;
            this.male.Text = "男";
            this.male.UseVisualStyleBackColor = true;
            // 
            // famale
            // 
            this.famale.AutoSize = true;
            this.famale.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.famale.Location = new System.Drawing.Point(375, 451);
            this.famale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.famale.Name = "famale";
            this.famale.Size = new System.Drawing.Size(38, 21);
            this.famale.TabIndex = 11;
            this.famale.TabStop = true;
            this.famale.Text = "女";
            this.famale.UseVisualStyleBackColor = true;
            // 
            // birthTP
            // 
            this.birthTP.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.birthTP.Location = new System.Drawing.Point(168, 375);
            this.birthTP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.birthTP.Name = "birthTP";
            this.birthTP.Size = new System.Drawing.Size(245, 23);
            this.birthTP.TabIndex = 12;
            // 
            // okBtn
            // 
            this.okBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.okBtn.Location = new System.Drawing.Point(227, 629);
            this.okBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(87, 33);
            this.okBtn.TabIndex = 13;
            this.okBtn.Text = "注册";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // selectImageBtn
            // 
            this.selectImageBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.selectImageBtn.Location = new System.Drawing.Point(58, 517);
            this.selectImageBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.selectImageBtn.Name = "selectImageBtn";
            this.selectImageBtn.Size = new System.Drawing.Size(87, 33);
            this.selectImageBtn.TabIndex = 15;
            this.selectImageBtn.Text = "选择头像";
            this.selectImageBtn.UseVisualStyleBackColor = true;
            this.selectImageBtn.Click += new System.EventHandler(this.selectImageBtn_Click);
            // 
            // pathTB
            // 
            this.pathTB.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pathTB.Location = new System.Drawing.Point(168, 520);
            this.pathTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pathTB.Name = "pathTB";
            this.pathTB.Size = new System.Drawing.Size(245, 23);
            this.pathTB.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(224, 577);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "带*的必填(^v^)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(419, 523);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "图片必须小于64KB";
            // 
            // Regist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 727);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pathTB);
            this.Controls.Add(this.selectImageBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.birthTP);
            this.Controls.Add(this.famale);
            this.Controls.Add(this.male);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.conTB);
            this.Controls.Add(this.pwdTB);
            this.Controls.Add(this.accTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Regist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox accTB;
        private System.Windows.Forms.TextBox pwdTB;
        private System.Windows.Forms.TextBox conTB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton famale;
        private System.Windows.Forms.DateTimePicker birthTP;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button selectImageBtn;
        private System.Windows.Forms.TextBox pathTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}