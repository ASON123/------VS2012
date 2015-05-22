namespace 程式設計練習VS2012.Ch13.範例
{
    partial class WinKeyUpDn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinKeyUpDn));
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.picTankR = new System.Windows.Forms.PictureBox();
            this.picTankD = new System.Windows.Forms.PictureBox();
            this.picTank = new System.Windows.Forms.PictureBox();
            this.picTankL = new System.Windows.Forms.PictureBox();
            this.picTankU = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTankR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTankD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTankL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTankU)).BeginInit();
            this.SuspendLayout();
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(13, 293);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(33, 12);
            this.lblX.TabIndex = 1;
            this.lblX.Text = "label1";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(12, 323);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(33, 12);
            this.lblY.TabIndex = 1;
            this.lblY.Text = "label1";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(12, 354);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(33, 12);
            this.lblMsg.TabIndex = 1;
            this.lblMsg.Text = "label1";
            // 
            // picTankR
            // 
            this.picTankR.Image = ((System.Drawing.Image)(resources.GetObject("picTankR.Image")));
            this.picTankR.Location = new System.Drawing.Point(500, 194);
            this.picTankR.Name = "picTankR";
            this.picTankR.Size = new System.Drawing.Size(71, 67);
            this.picTankR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picTankR.TabIndex = 0;
            this.picTankR.TabStop = false;
            // 
            // picTankD
            // 
            this.picTankD.Image = ((System.Drawing.Image)(resources.GetObject("picTankD.Image")));
            this.picTankD.Location = new System.Drawing.Point(67, 194);
            this.picTankD.Name = "picTankD";
            this.picTankD.Size = new System.Drawing.Size(65, 71);
            this.picTankD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picTankD.TabIndex = 0;
            this.picTankD.TabStop = false;
            // 
            // picTank
            // 
            this.picTank.Location = new System.Drawing.Point(281, 118);
            this.picTank.Name = "picTank";
            this.picTank.Size = new System.Drawing.Size(85, 81);
            this.picTank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picTank.TabIndex = 0;
            this.picTank.TabStop = false;
            this.picTank.StyleChanged += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picTankL
            // 
            this.picTankL.Image = ((System.Drawing.Image)(resources.GetObject("picTankL.Image")));
            this.picTankL.Location = new System.Drawing.Point(500, 37);
            this.picTankL.Name = "picTankL";
            this.picTankL.Size = new System.Drawing.Size(76, 64);
            this.picTankL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picTankL.TabIndex = 0;
            this.picTankL.TabStop = false;
            // 
            // picTankU
            // 
            this.picTankU.Image = ((System.Drawing.Image)(resources.GetObject("picTankU.Image")));
            this.picTankU.Location = new System.Drawing.Point(67, 37);
            this.picTankU.Name = "picTankU";
            this.picTankU.Size = new System.Drawing.Size(66, 73);
            this.picTankU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picTankU.TabIndex = 0;
            this.picTankU.TabStop = false;
            this.picTankU.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // WinKeyUpDn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 390);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.picTankR);
            this.Controls.Add(this.picTankD);
            this.Controls.Add(this.picTank);
            this.Controls.Add(this.picTankL);
            this.Controls.Add(this.picTankU);
            this.Name = "WinKeyUpDn";
            this.Text = "WinKeyUpDn";
            this.Load += new System.EventHandler(this.WinKeyUpDn_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WinKeyUpDn_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.WinKeyUpDn_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picTankR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTankD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTankL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTankU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picTankU;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.PictureBox picTankL;
        private System.Windows.Forms.PictureBox picTank;
        private System.Windows.Forms.PictureBox picTankD;
        private System.Windows.Forms.PictureBox picTankR;
    }
}