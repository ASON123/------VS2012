using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace 程式設計練習VS2012.Ch13.範例
{
    public partial class WinMouseEvent : Form
    {
        public WinMouseEvent()
        {
            InitializeComponent();
            
        }
        Bitmap bmp;  //宣告圖型物件
        int oldX, oldY; //紀錄滑鼠指標
        int PenPoint;  // 宣告PenPoint表示畫筆粗細
        Color PenColor;// 宣告PenColor表示畫筆顏色
        private void WinMouseEvent_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(320, 210);  //建立圖形物件大小320*210
            Graphics g = Graphics.FromImage(bmp);  // 建立畫布物件g
            PenColor = Color.Black;
            PenPoint = 3;
            g.Clear(Color.White);   // 將畫布清為白色
            pictureBox1.Image = bmp;// 畫布貼到pictureBox1圖片方塊控制項上
            pictureBox1.Refresh();  // 更新pictureBox1圖片方塊控制項
        }

        private void 開檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream f = new FileStream("myPic.jpg" , FileMode.Open);
                bmp = new Bitmap(f);
                f.Close();
                pictureBox1.Image = bmp;
            }catch(Exception ex )
            {
                MessageBox.Show("目前專案無圖檔,請先繪圖後再存檔");
                MessageBox.Show(ex.Message);
            }
        }

        private void 存檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bmp.Save("mypic.jpg");
        }

        private void 清除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            pictureBox1.Image = bmp;
        }

        private void 結束ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pictureBox1_MouseDowm(object sender , MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Graphics g = Graphics.FromImage(bmp);
                Pen p = new Pen(PenColor , PenPoint);
                g.DrawLine( p , oldX , oldY , e.X , e.Y);
                pictureBox1.Image = bmp;
                oldX = e.X;
                oldY = e.Y;
            }
        }

        private void pixelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PenPoint = 1;
        }

        private void piselsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PenPoint = 3;
        }

        private void piselsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PenPoint = 5;
        }

        private void 黑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PenColor = Color.Black;
        }

        private void 紅ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PenColor = Color.Red;
        }

        private void 綠ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PenColor = Color.Green;
        }

        private void 藍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PenColor = Color.Blue;
        }

       private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            
        }

    }
}
