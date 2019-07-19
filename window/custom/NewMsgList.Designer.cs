namespace SimpleChat.window.custom
{
    partial class NewMsgList
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
            this.msgCount = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.headimage)).BeginInit();
            this.SuspendLayout();
            // 
            // headimage
            // 
            this.headimage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.headimage.Location = new System.Drawing.Point(0, 0);
            this.headimage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.headimage.Name = "headimage";
            this.headimage.Size = new System.Drawing.Size(30, 30);
            this.headimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.headimage.TabIndex = 0;
            this.headimage.TabStop = false;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(36, 8);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(43, 17);
            this.name.TabIndex = 1;
            this.name.Text = "label1";
            // 
            // msgCount
            // 
            this.msgCount.AutoSize = true;
            this.msgCount.Location = new System.Drawing.Point(154, 8);
            this.msgCount.Name = "msgCount";
            this.msgCount.Size = new System.Drawing.Size(43, 17);
            this.msgCount.TabIndex = 2;
            this.msgCount.Text = "label2";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(85, 13);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(43, 17);
            this.idLabel.TabIndex = 3;
            this.idLabel.Text = "label1";
            this.idLabel.Visible = false;
            // 
            // NewMsgList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.msgCount);
            this.Controls.Add(this.name);
            this.Controls.Add(this.headimage);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NewMsgList";
            this.Size = new System.Drawing.Size(200, 30);
            this.Click += new System.EventHandler(this.NewMsgList_Click);
            this.MouseEnter += new System.EventHandler(this.NewMsgList_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.NewMsgList_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.headimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox headimage;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label msgCount;
        private System.Windows.Forms.Label idLabel;
    }
}
