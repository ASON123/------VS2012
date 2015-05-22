using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 程式設計練習VS2012.Ch12.範例
{
    public partial class WinStatusStrip : Form
    {
        public WinStatusStrip()
        {
            InitializeComponent();
        }
        int num = 0; //宣告num 整數變數用來紀錄目前的圖片索引編號0表示第一張
        string[] photo = new string[] { "田園", "雪山", "山林", "月亮" };
        void ShowPic () //定義ShowPic方法
        {
            pictureBox1.Image = new Bitmap(photo[num] + ".jpg");
            toolStripStatusLabel1.Text= "圖片名稱 : " + photo[num]; //顯示目前圖片的名稱

        }
        private void WinStatusStrip_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            ShowPic(); // 呼叫ShowPic 方法在pict裡面顯示圖片
        }

        private void 第一張ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            num = 0;
            ShowPic();
        }

        private void 上一張ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            num--; //num 圖片索引編號-1 表示顯示上一張
            if(num < 0) //若圖片編號小於1時 則由最後一張開始
            {
                num = photo.GetUpperBound(0);  
            }
            ShowPic();
        }

        private void 下一張ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            num++; // num 圖片索引編號+1 表示顯示下一張
            if(num > photo.GetUpperBound(0) ) //則另num 為0時表示由第一張開始顯示
            {
                num = 0;
            }
            ShowPic();
        }

        private void 最末張ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            num = photo.GetUpperBound(0); 
            ShowPic();
        }


    }
}
