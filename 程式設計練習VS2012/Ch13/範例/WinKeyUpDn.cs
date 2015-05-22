﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 程式設計練習VS2012.Ch13.範例
{
    public partial class WinKeyUpDn : Form
    {
        public WinKeyUpDn()
        {
            InitializeComponent();
        }
        int locX, locY;
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void WinKeyUpDn_Load(object sender, EventArgs e)
        {
            // 取得picTank的X, Y座標並指定給locX, locY
            locX = picTank.Location.X;
            locY = picTank.Location.Y;
            lblX.Text = "X座標：" + picTank.Location.X;
            lblY.Text = "Y座標：" + picTank.Location.Y;
            lblMsg.Text = "請按上下左右鍵控制坦克！";
            picTank.SizeMode = PictureBoxSizeMode.AutoSize;
            picTank.Image = picTankU.Image;
            picTankU.Visible = false;  // 坦克往上圖隱藏
            picTankD.Visible = false;  // 坦克往下圖隱藏
            picTankL.Visible = false;  // 坦克往左圖隱藏
            picTankR.Visible = false;  // 坦克往右圖隱藏
        }
        private void WinKeyUpDn_KeyDown(object sender , KeyEventArgs e )
        {
            switch(e.KeyCode)
            {
                case Keys.Up :
                    picTank.Image = picTankU.Image;
                    if((picTank.Top + picTank.Height) <= 0)
                    {
                        picTank.Top = this.Height;
                    }
                    else
                    {
                        picTank.Top -= 10;
                    }
                    break;
                case Keys.Down :
                    picTank.Image = picTankD.Image;
                    if((picTank.Top >= this.Height))
                    {
                        picTank.Top = 0 - picTank.Height;
                    }
                    else
                    {
                        picTank.Top += 10;
                    }
                    break;
                case Keys.Left :
                    picTank.Image = picTankL.Image;
                    if((picTank.Width + picTank .Left <= 0))
                    {
                        picTank.Left = this.Width;
                    }
                    else
                    {
                        picTank.Left -= 10;
                    }
                    break;
                case Keys.Right :
                    picTank.Image = picTankR.Image;
                    if((picTank.Left  >= this.Width))
                    {
                        picTankR.Left = 0 - picTank.Width;
                    }
                    else
                    {
                        picTank.Left += 10;
                    }
                    break;
            }
            lblX.Text = "X座標 : " + picTank.Location.X ;
            lblY.Text = "Y座標 : " + picTank.Location.Y;
            lblMsg.Text = "現在按下 " + e.KeyCode.ToString() + "鍵 , 鍵值為 : " + e.KeyValue.ToString() + "!!";

        }
         private void WinKeyUpDn_KeyUp (object sender , KeyEventArgs e)
        {
            lblX.Text = "X座標 : " + picTank.Location.X;
            lblY.Text = "Y座標 : " + picTank.Location.Y;
            lblMsg.Text = "請案上下左右鍵控制坦克 ! ";
        }
    }
}
