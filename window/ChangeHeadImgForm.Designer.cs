namespace SimpleChat.window
{
    partial class ChangeHeadImgForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeHeadImgForm));
            this.headImage = new System.Windows.Forms.PictureBox();
            this.changeBtn = new System.Windows.Forms.Button();
            this.OkBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.headImage)).BeginInit();
            this.SuspendLayout();
            // 
            // headImage
            // 
            this.headImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.headImage.Location = new System.Drawing.Point(31, 26);
            this.headImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.headImage.Name = "headImage";
            this.headImage.Size = new System.Drawing.Size(218, 179);
            this.headImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.headImage.TabIndex = 0;
            this.headImage.TabStop = false;
            // 
            // changeBtn
            // 
            this.changeBtn.Location = new System.Drawing.Point(31, 223);
            this.changeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(91, 28);
            this.changeBtn.TabIndex = 1;
            this.changeBtn.TabStop = false;
            this.changeBtn.Text = "点击更换头像";
            this.changeBtn.UseVisualStyleBackColor = true;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(158, 223);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(91, 28);
            this.OkBtn.TabIndex = 2;
            this.OkBtn.TabStop = false;
            this.OkBtn.Text = "确定";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // ChangeHeadImgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 280);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.changeBtn);
            this.Controls.Add(this.headImage);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "ChangeHeadImgForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "更换头像";
            ((System.ComponentModel.ISupportInitialize)(this.headImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox headImage;
        private System.Windows.Forms.Button changeBtn;
        private System.Windows.Forms.Button OkBtn;
    }
}