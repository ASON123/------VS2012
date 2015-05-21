namespace 程式設計練習VS2012.Ch11.範例
{
    partial class WinpictureBox
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
            this.lable1 = new System.Windows.Forms.Label();
            this.cboPhotoName = new System.Windows.Forms.ComboBox();
            this.pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(52, 25);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(53, 12);
            this.lable1.TabIndex = 0;
            this.lable1.Text = "圖片名稱";
            // 
            // cboPhotoName
            // 
            this.cboPhotoName.FormattingEnabled = true;
            this.cboPhotoName.Items.AddRange(new object[] {
            "田園",
            "雪山",
            "山林",
            "月亮"});
            this.cboPhotoName.Location = new System.Drawing.Point(111, 22);
            this.cboPhotoName.Name = "cboPhotoName";
            this.cboPhotoName.Size = new System.Drawing.Size(121, 20);
            this.cboPhotoName.TabIndex = 3;
            this.cboPhotoName.SelectedIndexChanged += new System.EventHandler(this.cboPhotoName_SelectedIndexChanged);
            // 
            // pic
            // 
            this.pic.ErrorImage = null;
            this.pic.ImageLocation = "C:\\Users\\asonxu\\Desktop\\新增資料夾 (2)\\程式設計練習VS2012\\程式設計練習VS2012\\程式設計練習VS2012\\bin\\Debu" +
    "g";
            this.pic.InitialImage = null;
            this.pic.Location = new System.Drawing.Point(13, 57);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(259, 193);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            // 
            // WinpictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cboPhotoName);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.lable1);
            this.Name = "WinpictureBox";
            this.Text = "圖片顯示";
            this.Load += new System.EventHandler(this.WinpictureBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.ComboBox cboPhotoName;
    }
}