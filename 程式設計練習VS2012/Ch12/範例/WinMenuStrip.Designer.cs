namespace 程式設計練習VS2012.Ch12.範例
{
    partial class WinMenuStrip
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.開檔OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.存檔SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清除RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.結束EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.項目符號ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.字型大小ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cboSize = new System.Windows.Forms.ToolStripComboBox();
            this.字型色彩ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbofontcolor = new System.Windows.Forms.ToolStripComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.項目符號ToolStripMenuItem,
            this.字型大小ToolStripMenuItem,
            this.cboSize,
            this.字型色彩ToolStripMenuItem,
            this.cbofontcolor});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(508, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開檔OToolStripMenuItem,
            this.存檔SToolStripMenuItem,
            this.清除RToolStripMenuItem,
            this.結束EToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(58, 24);
            this.toolStripMenuItem1.Text = "檔案(&F)";
            // 
            // 開檔OToolStripMenuItem
            // 
            this.開檔OToolStripMenuItem.Name = "開檔OToolStripMenuItem";
            this.開檔OToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.開檔OToolStripMenuItem.Text = "開檔(&O)";
            this.開檔OToolStripMenuItem.Click += new System.EventHandler(this.開檔OToolStripMenuItem_Click);
            // 
            // 存檔SToolStripMenuItem
            // 
            this.存檔SToolStripMenuItem.Name = "存檔SToolStripMenuItem";
            this.存檔SToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.存檔SToolStripMenuItem.Text = "存檔(&S)";
            this.存檔SToolStripMenuItem.Click += new System.EventHandler(this.存檔SToolStripMenuItem_Click);
            // 
            // 清除RToolStripMenuItem
            // 
            this.清除RToolStripMenuItem.Name = "清除RToolStripMenuItem";
            this.清除RToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.清除RToolStripMenuItem.Text = "清除(&R)";
            this.清除RToolStripMenuItem.Click += new System.EventHandler(this.清除RToolStripMenuItem_Click);
            // 
            // 結束EToolStripMenuItem
            // 
            this.結束EToolStripMenuItem.Name = "結束EToolStripMenuItem";
            this.結束EToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.結束EToolStripMenuItem.Text = "結束(&E)";
            this.結束EToolStripMenuItem.Click += new System.EventHandler(this.結束EToolStripMenuItem_Click);
            // 
            // 項目符號ToolStripMenuItem
            // 
            this.項目符號ToolStripMenuItem.Name = "項目符號ToolStripMenuItem";
            this.項目符號ToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.項目符號ToolStripMenuItem.Text = "項目符號";
            this.項目符號ToolStripMenuItem.Click += new System.EventHandler(this.項目符號ToolStripMenuItem_Click);
            // 
            // 字型大小ToolStripMenuItem
            // 
            this.字型大小ToolStripMenuItem.Name = "字型大小ToolStripMenuItem";
            this.字型大小ToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.字型大小ToolStripMenuItem.Text = "字型大小";
            // 
            // cboSize
            // 
            this.cboSize.Items.AddRange(new object[] {
            "9",
            "12",
            "14",
            "16",
            "18"});
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(75, 24);
            this.cboSize.Text = "9";
            this.cboSize.Click += new System.EventHandler(this.cboSize_Click);
            // 
            // 字型色彩ToolStripMenuItem
            // 
            this.字型色彩ToolStripMenuItem.Name = "字型色彩ToolStripMenuItem";
            this.字型色彩ToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.字型色彩ToolStripMenuItem.Text = "字型色彩";
            // 
            // cbofontcolor
            // 
            this.cbofontcolor.Items.AddRange(new object[] {
            "黑",
            "紅",
            "綠",
            "藍"});
            this.cbofontcolor.Name = "cbofontcolor";
            this.cbofontcolor.Size = new System.Drawing.Size(75, 24);
            this.cbofontcolor.Text = "黑";
            this.cbofontcolor.Click += new System.EventHandler(this.cbofontcolor_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 44);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // WinMenuStrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 250);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WinMenuStrip";
            this.Text = "WinMenuStrip";
            this.Load += new System.EventHandler(this.WinMenuStrip_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 開檔OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 存檔SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清除RToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 結束EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 項目符號ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 字型大小ToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox cboSize;
        private System.Windows.Forms.ToolStripMenuItem 字型色彩ToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox cbofontcolor;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}