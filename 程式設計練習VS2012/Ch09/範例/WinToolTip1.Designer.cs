namespace 程式設計練習VS2012.Ch09.範例
{
    partial class WinToolTip1
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
            this.components = new System.ComponentModel.Container();
            this.lbl1 = new System.Windows.Forms.LinkLabel();
            this.lbl2 = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.lbl3 = new System.Windows.Forms.LinkLabel();
            this.lbl4 = new System.Windows.Forms.LinkLabel();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(73, 34);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(149, 12);
            this.lbl1.TabIndex = 0;
            this.lbl1.TabStop = true;
            this.lbl1.Text = "宇辰科技系統股份有限公司";
            this.lbl1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl1_LinkClicked);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(73, 66);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(65, 12);
            this.lbl2.TabIndex = 1;
            this.lbl2.TabStop = true;
            this.lbl2.Text = "請聯絡我們";
            this.lbl2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl2_LinkClicked);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(75, 99);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(29, 12);
            this.lbl3.TabIndex = 2;
            this.lbl3.TabStop = true;
            this.lbl3.Text = "奇摩";
            this.lbl3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl3_LinkClicked);
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(75, 130);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(39, 12);
            this.lbl4.TabIndex = 3;
            this.lbl4.TabStop = true;
            this.lbl4.Text = "Google";
            this.lbl4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl4_LinkClicked);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(197, 190);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "離開";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // WinToolTip1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "WinToolTip1";
            this.Text = "WinToolTip1";
            this.Load += new System.EventHandler(this.WinToolTip1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lbl1;
        private System.Windows.Forms.LinkLabel lbl2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.LinkLabel lbl3;
        private System.Windows.Forms.LinkLabel lbl4;
        private System.Windows.Forms.Button btnExit;
    }
}