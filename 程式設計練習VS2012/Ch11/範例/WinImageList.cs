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
    public partial class WinImageList : Form
    {
        public WinImageList()
        {
            InitializeComponent();
        }

        int num = 0; //宣告num 整數用來紀錄目前的圖片索引編號,0表示第一張
        int i = 0;
        string[] photo = new string[] { "田園", "雪山", "山林", "月亮" };
        void ShowPic()
        {
            pictureBox1.Image = imageList1.Images[num];
            lblShow.Text = "圖片名稱 : " + photo[num];
        }

        private void WinImageList_Load(object sender, EventArgs e)
        {

            for (i = 0; i <= photo.GetUpperBound(0);i++ )
            {
                imageList1.Images.Add(new Bitmap(photo[i] + ".jpg"));
            }
            imageList1.ImageSize = new Size(250,180);
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            ShowPic();
        }

        private void btnFist_Click(object sender, EventArgs e)//第一張
        {
            num = 0;
            ShowPic();
        }

        private void btnPrev_Click(object sender, EventArgs e) //上一張
        {
            num--;
            if(num < 0)
            {
                num = photo.GetUpperBound(0);
            }
            ShowPic();
        }

        private void btnNext_Click(object sender, EventArgs e)//下一張
        {
            num++;
            if(num > photo.GetUpperBound(0))
            {
                num = 0;
            }
            ShowPic();
        }

        private void btnLast_Click(object sender, EventArgs e)//最末張
        {
            num = photo.GetUpperBound(0);
            ShowPic();
        }


    }
}
