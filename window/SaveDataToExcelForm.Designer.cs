namespace SimpleChat.window
{
    partial class SaveDataToExcelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveDataToExcelForm));
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.descriptionlable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(82, 35);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(275, 37);
            this.progressBar.TabIndex = 0;
            // 
            // descriptionlable
            // 
            this.descriptionlable.AutoSize = true;
            this.descriptionlable.Location = new System.Drawing.Point(190, 86);
            this.descriptionlable.Name = "descriptionlable";
            this.descriptionlable.Size = new System.Drawing.Size(0, 12);
            this.descriptionlable.TabIndex = 1;
            // 
            // SaveDataToExcelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 118);
            this.Controls.Add(this.descriptionlable);
            this.Controls.Add(this.progressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SaveDataToExcelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "完成进度";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SaveDataToExcelForm_FormClosing);
            this.Shown += new System.EventHandler(this.SaveDataToExcelForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label descriptionlable;
    }
}