namespace 程式設計練習VS2012.Ch10.範例
{
    partial class WinChkLstBx
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
            this.chkListLot = new System.Windows.Forms.CheckedListBox();
            this.lblShow = new System.Windows.Forms.ListBox();
            this.btnCheckLot = new System.Windows.Forms.Button();
            this.btnRest = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkListLot
            // 
            this.chkListLot.CheckOnClick = true;
            this.chkListLot.FormattingEnabled = true;
            this.chkListLot.Location = new System.Drawing.Point(13, 30);
            this.chkListLot.Name = "chkListLot";
            this.chkListLot.Size = new System.Drawing.Size(442, 106);
            this.chkListLot.TabIndex = 0;
            this.chkListLot.TabIndexChanged += new System.EventHandler(this.btnCheckLot_Click);
            this.chkListLot.StyleChanged += new System.EventHandler(this.WinChkLstBx_Load);
            // 
            // lblShow
            // 
            this.lblShow.FormattingEnabled = true;
            this.lblShow.ItemHeight = 12;
            this.lblShow.Location = new System.Drawing.Point(13, 143);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(442, 88);
            this.lblShow.TabIndex = 1;
            // 
            // btnCheckLot
            // 
            this.btnCheckLot.Location = new System.Drawing.Point(34, 253);
            this.btnCheckLot.Name = "btnCheckLot";
            this.btnCheckLot.Size = new System.Drawing.Size(75, 23);
            this.btnCheckLot.TabIndex = 2;
            this.btnCheckLot.Text = "對獎";
            this.btnCheckLot.UseVisualStyleBackColor = true;
            this.btnCheckLot.Click += new System.EventHandler(this.btnCheckLot_Click);
            // 
            // btnRest
            // 
            this.btnRest.Location = new System.Drawing.Point(192, 253);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(75, 23);
            this.btnRest.TabIndex = 2;
            this.btnRest.Text = "清除";
            this.btnRest.UseVisualStyleBackColor = true;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(347, 253);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "離開";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // WinChkLstBx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 288);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRest);
            this.Controls.Add(this.btnCheckLot);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.chkListLot);
            this.Name = "WinChkLstBx";
            this.Text = "WinChkLstBx";
            this.Load += new System.EventHandler(this.WinChkLstBx_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chkListLot;
        private System.Windows.Forms.ListBox lblShow;
        private System.Windows.Forms.Button btnCheckLot;
        private System.Windows.Forms.Button btnRest;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
    }
}