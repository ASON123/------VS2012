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
    public partial class WinTrackBar : Form
    {
        public WinTrackBar()
        {
            InitializeComponent();
        }
        string[] photo = new string[] { "田園", "雪山", "山林", "月亮" };
        private void WinTrackBar_Load(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; //圖片隨著控制大小而伸縮
            pictureBox1.Image = new Bitmap(photo[0] + ".jpg"); //圖片空置顯示photo[0] 元素的圖檔
            label1.Text = "圖片名稱 :" + photo[0];
            trackBar1.Minimum = 0;
            trackBar1.Maximum = photo.GetUpperBound(0);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int index = trackBar1.Value;
            pictureBox1.Image = new Bitmap(photo[index] + ".jpg");
            label1.Text = "圖片名稱 : " + photo[index];
        }
    }
}
