namespace 程式設計練習VS2012.Ch12.範例
{
    partial class WinContexMentStrip
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
        // ch12 WinContexMentStrip 完成
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.開檔ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.儲存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.結束ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.項目符號ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.字型大小ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cboSize = new System.Windows.Forms.ToolStripComboBox();
            this.字型色彩ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbofontColor = new System.Windows.Forms.ToolStripComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.複製ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.貼上ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.剪下ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Location = new System.Drawing.Point(12, 42);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.項目符號ToolStripMenuItem,
            this.字型大小ToolStripMenuItem,
            this.cboSize,
            this.字型色彩ToolStripMenuItem,
            this.cbofontColor});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(605, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開檔ToolStripMenuItem,
            this.儲存ToolStripMenuItem,
            this.清出ToolStripMenuItem,
            this.結束ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(58, 24);
            this.toolStripMenuItem1.Text = "檔案(&F)";
            // 
            // 開檔ToolStripMenuItem
            // 
            this.開檔ToolStripMenuItem.Name = "開檔ToolStripMenuItem";
            this.開檔ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.開檔ToolStripMenuItem.Text = "開檔";
            this.開檔ToolStripMenuItem.Click += new System.EventHandler(this.開檔ToolStripMenuItem_Click);
            // 
            // 儲存ToolStripMenuItem
            // 
            this.儲存ToolStripMenuItem.Name = "儲存ToolStripMenuItem";
            this.儲存ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.儲存ToolStripMenuItem.Text = "儲存";
            this.儲存ToolStripMenuItem.Click += new System.EventHandler(this.儲存ToolStripMenuItem_Click);
            // 
            // 清出ToolStripMenuItem
            // 
            this.清出ToolStripMenuItem.Name = "清出ToolStripMenuItem";
            this.清出ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.清出ToolStripMenuItem.Text = "清除";
            this.清出ToolStripMenuItem.Click += new System.EventHandler(this.清除ToolStripMenuItem_Click);
            // 
            // 結束ToolStripMenuItem
            // 
            this.結束ToolStripMenuItem.Name = "結束ToolStripMenuItem";
            this.結束ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.結束ToolStripMenuItem.Text = "結束";
            this.結束ToolStripMenuItem.Click += new System.EventHandler(this.結束ToolStripMenuItem_Click);
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
            this.cboSize.AutoCompleteCustomSource.AddRange(new string[] {
            "9",
            "12",
            "14",
            "16",
            "18"});
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
            // cbofontColor
            // 
            this.cbofontColor.AutoCompleteCustomSource.AddRange(new string[] {
            "黑",
            "紅",
            "綠",
            "藍"});
            this.cbofontColor.Items.AddRange(new object[] {
            "黑",
            "紅",
            "綠",
            "藍"});
            this.cbofontColor.Name = "cbofontColor";
            this.cbofontColor.Size = new System.Drawing.Size(75, 24);
            this.cbofontColor.Text = "黑";
            this.cbofontColor.Click += new System.EventHandler(this.cbofontColor_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.複製ToolStripMenuItem,
            this.貼上ToolStripMenuItem,
            this.剪下ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 70);
            // 
            // 複製ToolStripMenuItem
            // 
            this.複製ToolStripMenuItem.Name = "複製ToolStripMenuItem";
            this.複製ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.複製ToolStripMenuItem.Text = "複製";
            this.複製ToolStripMenuItem.Click += new System.EventHandler(this.複製ToolStripMenuItem_Click);
            // 
            // 貼上ToolStripMenuItem
            // 
            this.貼上ToolStripMenuItem.Name = "貼上ToolStripMenuItem";
            this.貼上ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.貼上ToolStripMenuItem.Text = "貼上";
            this.貼上ToolStripMenuItem.Click += new System.EventHandler(this.貼上ToolStripMenuItem_Click);
            // 
            // 剪下ToolStripMenuItem
            // 
            this.剪下ToolStripMenuItem.Name = "剪下ToolStripMenuItem";
            this.剪下ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.剪下ToolStripMenuItem.Text = "剪下";
            this.剪下ToolStripMenuItem.Click += new System.EventHandler(this.剪下ToolStripMenuItem_Click);
            // 
            // WinContexMentStrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 332);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WinContexMentStrip";
            this.Text = "WinContexMentStrip";
            this.Load += new System.EventHandler(this.WinContexMentStrip_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 開檔ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 儲存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 結束ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 項目符號ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 字型大小ToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox cboSize;
        private System.Windows.Forms.ToolStripMenuItem 字型色彩ToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox cbofontColor;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 複製ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 貼上ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 剪下ToolStripMenuItem;
    }
}