namespace 程式設計練習VS2012.Ch12.範例
{
    partial class WinToolStrip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinToolStrip));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbCls = new System.Windows.Forms.ToolStripLabel();
            this.tsbBullet = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.cboSize = new System.Windows.Forms.ToolStripComboBox();
            this.cboFontColor = new System.Windows.Forms.ToolStripSplitButton();
            this.黑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.紅ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.綠ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.藍ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpen,
            this.tsbSave,
            this.tsbCls,
            this.tsbBullet,
            this.toolStripLabel3,
            this.cboSize,
            this.cboFontColor});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(578, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbOpen
            // 
            this.tsbOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpen.Image")));
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(52, 22);
            this.tsbOpen.Text = "開檔";
            this.tsbOpen.Click += new System.EventHandler(this.tsbOpen_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(52, 22);
            this.tsbSave.Text = "存檔";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbCls
            // 
            this.tsbCls.Name = "tsbCls";
            this.tsbCls.Size = new System.Drawing.Size(32, 22);
            this.tsbCls.Text = "清除";
            this.tsbCls.Click += new System.EventHandler(this.tsbCls_Click);
            // 
            // tsbBullet
            // 
            this.tsbBullet.Name = "tsbBullet";
            this.tsbBullet.Size = new System.Drawing.Size(56, 22);
            this.tsbBullet.Text = "項目符號";
            this.tsbBullet.Click += new System.EventHandler(this.tsbBullet_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(56, 22);
            this.toolStripLabel3.Text = "字型大小";
            // 
            // cboSize
            // 
            this.cboSize.AutoCompleteCustomSource.AddRange(new string[] {
            "9",
            "10",
            "12",
            "14",
            "16"});
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(121, 25);
            this.cboSize.Text = "9";
            this.cboSize.Click += new System.EventHandler(this.cboSize_Click);
            // 
            // cboFontColor
            // 
            this.cboFontColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cboFontColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.黑ToolStripMenuItem,
            this.紅ToolStripMenuItem,
            this.綠ToolStripMenuItem,
            this.藍ToolStripMenuItem});
            this.cboFontColor.Image = ((System.Drawing.Image)(resources.GetObject("cboFontColor.Image")));
            this.cboFontColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cboFontColor.Name = "cboFontColor";
            this.cboFontColor.Size = new System.Drawing.Size(72, 22);
            this.cboFontColor.Text = "字型色彩";
            // 
            // 黑ToolStripMenuItem
            // 
            this.黑ToolStripMenuItem.Name = "黑ToolStripMenuItem";
            this.黑ToolStripMenuItem.Size = new System.Drawing.Size(88, 22);
            this.黑ToolStripMenuItem.Text = "黑";
            this.黑ToolStripMenuItem.Click += new System.EventHandler(this.黑ToolStripMenuItem_Click);
            // 
            // 紅ToolStripMenuItem
            // 
            this.紅ToolStripMenuItem.Name = "紅ToolStripMenuItem";
            this.紅ToolStripMenuItem.Size = new System.Drawing.Size(88, 22);
            this.紅ToolStripMenuItem.Text = "紅";
            this.紅ToolStripMenuItem.Click += new System.EventHandler(this.紅ToolStripMenuItem_Click);
            // 
            // 綠ToolStripMenuItem
            // 
            this.綠ToolStripMenuItem.Name = "綠ToolStripMenuItem";
            this.綠ToolStripMenuItem.Size = new System.Drawing.Size(88, 22);
            this.綠ToolStripMenuItem.Text = "綠";
            this.綠ToolStripMenuItem.Click += new System.EventHandler(this.綠ToolStripMenuItem_Click);
            // 
            // 藍ToolStripMenuItem
            // 
            this.藍ToolStripMenuItem.Name = "藍ToolStripMenuItem";
            this.藍ToolStripMenuItem.Size = new System.Drawing.Size(88, 22);
            this.藍ToolStripMenuItem.Text = "藍";
            this.藍ToolStripMenuItem.Click += new System.EventHandler(this.藍ToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 39);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(209, 184);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // WinToolStrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 262);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "WinToolStrip";
            this.Text = "WinToolStrip";
            this.Load += new System.EventHandler(this.WinToolStrip_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripLabel tsbCls;
        private System.Windows.Forms.ToolStripLabel tsbBullet;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripComboBox cboSize;
        private System.Windows.Forms.ToolStripSplitButton cboFontColor;
        private System.Windows.Forms.ToolStripMenuItem 黑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 紅ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 綠ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 藍ToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}