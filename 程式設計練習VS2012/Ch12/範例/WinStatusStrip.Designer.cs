﻿namespace 程式設計練習VS2012.Ch12.範例
{
    partial class WinStatusStrip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinStatusStrip));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.最末張ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下一張ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上一張ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.第一張ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripDropDownButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 268);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(471, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(132, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLablel1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.最末張ToolStripMenuItem,
            this.下一張ToolStripMenuItem,
            this.上一張ToolStripMenuItem,
            this.第一張ToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 20);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // 最末張ToolStripMenuItem
            // 
            this.最末張ToolStripMenuItem.Name = "最末張ToolStripMenuItem";
            this.最末張ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.最末張ToolStripMenuItem.Text = "最末張";
            this.最末張ToolStripMenuItem.Click += new System.EventHandler(this.最末張ToolStripMenuItem_Click);
            // 
            // 下一張ToolStripMenuItem
            // 
            this.下一張ToolStripMenuItem.Name = "下一張ToolStripMenuItem";
            this.下一張ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.下一張ToolStripMenuItem.Text = "下一張";
            this.下一張ToolStripMenuItem.Click += new System.EventHandler(this.下一張ToolStripMenuItem_Click);
            // 
            // 上一張ToolStripMenuItem
            // 
            this.上一張ToolStripMenuItem.Name = "上一張ToolStripMenuItem";
            this.上一張ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.上一張ToolStripMenuItem.Text = "上一張";
            this.上一張ToolStripMenuItem.Click += new System.EventHandler(this.上一張ToolStripMenuItem_Click);
            // 
            // 第一張ToolStripMenuItem
            // 
            this.第一張ToolStripMenuItem.Name = "第一張ToolStripMenuItem";
            this.第一張ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.第一張ToolStripMenuItem.Text = "第一張";
            this.第一張ToolStripMenuItem.Click += new System.EventHandler(this.第一張ToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(443, 202);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // WinStatusStrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 290);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "WinStatusStrip";
            this.Load += new System.EventHandler(this.WinStatusStrip_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem 最末張ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下一張ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 上一張ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 第一張ToolStripMenuItem;
    }
}