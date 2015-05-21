namespace 程式設計練習VS2012.Ch11.範例
{
    partial class winpictureBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboPhotoName = new System.Windows.Forms.ComboBox();
            this.pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "圖片名稱 :";
            // 
            // cboPhotoName
            // 
            this.cboPhotoName.FormattingEnabled = true;
            this.cboPhotoName.Location = new System.Drawing.Point(77, 16);
            this.cboPhotoName.Name = "cboPhotoName";
            this.cboPhotoName.Size = new System.Drawing.Size(121, 20);
            this.cboPhotoName.TabIndex = 1;
            this.cboPhotoName.SelectedIndexChanged += new System.EventHandler(this.cboPhotoName_SelectedIndexChanged);
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(4, 48);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(268, 202);
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            // 
            // winpictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.cboPhotoName);
            this.Controls.Add(this.label1);
            this.Name = "winpictureBox";
            this.Text = "winpictureBox";
            this.Load += new System.EventHandler(this.winpictureBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPhotoName;
        private System.Windows.Forms.PictureBox pic;
    }
}