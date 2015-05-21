using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 程式設計練習VS2012.Ch11.範例
{
    public partial class WinVHScrollBar : Form
    {
        public WinVHScrollBar()
        {
            InitializeComponent();
        }

        private void WinVHScrollBar_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap("月亮.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;

            hScrollBar1.Maximum = pictureBox1.Width;
            hScrollBar1.Value = pictureBox1.Width;
            hScrollBar1.Maximum = pictureBox1.Height;
            hScrollBar1.Value = pictureBox1.Height;

            label1.Text = "寬 : " + hScrollBar1.Value.ToString() + "    " + "高 : " + vScrollBar1.Value.ToString();
        
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            //圖片的寬度依目前水平捲軸的值做調整
            pictureBox1.Height = vScrollBar1.Value;
            label1.Text = "寬 : " + hScrollBar1.Value.ToString() + "    " + "高 :" + vScrollBar1.Value.ToString();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            pictureBox1.Width = hScrollBar1.Value;
            label1.Text = "高 : " + hScrollBar1.Value.ToString() + "     " + "寬 :" + vScrollBar1.Value.ToString();
        }
    }
}
