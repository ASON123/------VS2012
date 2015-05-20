namespace 程式設計練習VS2012.Ch10.範例
{
    partial class WinGroupBox
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbps3 = new System.Windows.Forms.RadioButton();
            this.rdbbox360 = new System.Windows.Forms.RadioButton();
            this.gbBOX360 = new System.Windows.Forms.GroupBox();
            this.chkxb3 = new System.Windows.Forms.CheckBox();
            this.chkxb2 = new System.Windows.Forms.CheckBox();
            this.chkxb1 = new System.Windows.Forms.CheckBox();
            this.gbPs3 = new System.Windows.Forms.GroupBox();
            this.chkps3 = new System.Windows.Forms.CheckBox();
            this.chkps2 = new System.Windows.Forms.CheckBox();
            this.chkps1 = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbBOX360.SuspendLayout();
            this.gbPs3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbps3);
            this.groupBox1.Controls.Add(this.rdbbox360);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 49);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "遊戲主機";
            // 
            // rdbps3
            // 
            this.rdbps3.AutoSize = true;
            this.rdbps3.Location = new System.Drawing.Point(131, 21);
            this.rdbps3.Name = "rdbps3";
            this.rdbps3.Size = new System.Drawing.Size(41, 16);
            this.rdbps3.TabIndex = 0;
            this.rdbps3.TabStop = true;
            this.rdbps3.Text = "PS3";
            this.rdbps3.UseVisualStyleBackColor = true;
            this.rdbps3.CheckedChanged += new System.EventHandler(this.rdbps3_CheckedChanged);
            // 
            // rdbbox360
            // 
            this.rdbbox360.AutoSize = true;
            this.rdbbox360.Location = new System.Drawing.Point(18, 21);
            this.rdbbox360.Name = "rdbbox360";
            this.rdbbox360.Size = new System.Drawing.Size(49, 16);
            this.rdbbox360.TabIndex = 0;
            this.rdbbox360.TabStop = true;
            this.rdbbox360.Text = "X360";
            this.rdbbox360.UseVisualStyleBackColor = true;
            this.rdbbox360.CheckedChanged += new System.EventHandler(this.rdbbox360_CheckedChanged);
            // 
            // gbBOX360
            // 
            this.gbBOX360.Controls.Add(this.chkxb3);
            this.gbBOX360.Controls.Add(this.chkxb2);
            this.gbBOX360.Controls.Add(this.chkxb1);
            this.gbBOX360.Location = new System.Drawing.Point(12, 67);
            this.gbBOX360.Name = "gbBOX360";
            this.gbBOX360.Size = new System.Drawing.Size(260, 51);
            this.gbBOX360.TabIndex = 0;
            this.gbBOX360.TabStop = false;
            this.gbBOX360.Text = "X360遊戲";
            // 
            // chkxb3
            // 
            this.chkxb3.AutoSize = true;
            this.chkxb3.Location = new System.Drawing.Point(173, 21);
            this.chkxb3.Name = "chkxb3";
            this.chkxb3.Size = new System.Drawing.Size(48, 16);
            this.chkxb3.TabIndex = 0;
            this.chkxb3.Text = "大聯";
            this.chkxb3.UseVisualStyleBackColor = true;
            // 
            // chkxb2
            // 
            this.chkxb2.AutoSize = true;
            this.chkxb2.Location = new System.Drawing.Point(90, 22);
            this.chkxb2.Name = "chkxb2";
            this.chkxb2.Size = new System.Drawing.Size(48, 16);
            this.chkxb2.TabIndex = 0;
            this.chkxb2.Text = "生死";
            this.chkxb2.UseVisualStyleBackColor = true;
            // 
            // chkxb1
            // 
            this.chkxb1.AutoSize = true;
            this.chkxb1.Location = new System.Drawing.Point(7, 22);
            this.chkxb1.Name = "chkxb1";
            this.chkxb1.Size = new System.Drawing.Size(48, 16);
            this.chkxb1.TabIndex = 0;
            this.chkxb1.Text = "忍者";
            this.chkxb1.UseVisualStyleBackColor = true;
            // 
            // gbPs3
            // 
            this.gbPs3.Controls.Add(this.chkps3);
            this.gbPs3.Controls.Add(this.chkps2);
            this.gbPs3.Controls.Add(this.chkps1);
            this.gbPs3.Location = new System.Drawing.Point(12, 124);
            this.gbPs3.Name = "gbPs3";
            this.gbPs3.Size = new System.Drawing.Size(260, 51);
            this.gbPs3.TabIndex = 0;
            this.gbPs3.TabStop = false;
            this.gbPs3.Text = "PS3遊戲";
            // 
            // chkps3
            // 
            this.chkps3.AutoSize = true;
            this.chkps3.Location = new System.Drawing.Point(173, 20);
            this.chkps3.Name = "chkps3";
            this.chkps3.Size = new System.Drawing.Size(48, 16);
            this.chkps3.TabIndex = 0;
            this.chkps3.Text = "賽車";
            this.chkps3.UseVisualStyleBackColor = true;
            // 
            // chkps2
            // 
            this.chkps2.AutoSize = true;
            this.chkps2.Location = new System.Drawing.Point(90, 21);
            this.chkps2.Name = "chkps2";
            this.chkps2.Size = new System.Drawing.Size(48, 16);
            this.chkps2.TabIndex = 0;
            this.chkps2.Text = "海王";
            this.chkps2.UseVisualStyleBackColor = true;
            // 
            // chkps1
            // 
            this.chkps1.AutoSize = true;
            this.chkps1.Location = new System.Drawing.Point(7, 21);
            this.chkps1.Name = "chkps1";
            this.chkps1.Size = new System.Drawing.Size(48, 16);
            this.chkps1.TabIndex = 0;
            this.chkps1.Text = "火影";
            this.chkps1.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(197, 184);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "確定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // WinGroupBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 219);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gbPs3);
            this.Controls.Add(this.gbBOX360);
            this.Controls.Add(this.groupBox1);
            this.Name = "WinGroupBox";
            this.Text = "WinGroupBox";
            this.Load += new System.EventHandler(this.WinGroupBox_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbBOX360.ResumeLayout(false);
            this.gbBOX360.PerformLayout();
            this.gbPs3.ResumeLayout(false);
            this.gbPs3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbps3;
        private System.Windows.Forms.RadioButton rdbbox360;
        private System.Windows.Forms.GroupBox gbBOX360;
        private System.Windows.Forms.CheckBox chkxb3;
        private System.Windows.Forms.CheckBox chkxb2;
        private System.Windows.Forms.CheckBox chkxb1;
        private System.Windows.Forms.GroupBox gbPs3;
        private System.Windows.Forms.CheckBox chkps3;
        private System.Windows.Forms.CheckBox chkps2;
        private System.Windows.Forms.CheckBox chkps1;
        private System.Windows.Forms.Button btnOK;
    }
}