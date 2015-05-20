using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 程式設計練習VS2012.Ch09.範例
{
    public partial class WinButton1 : Form
    {
        int guess;   //宣告亂數
        public WinButton1()
        {
            InitializeComponent();
        }

        void CheckAns(int Ans)  //CheckAns方法用來判斷答案是否正確
        {
            if (guess == Ans)    //如果guess(電腦產生的亂數)==Ans(使用者的答案)
            {
                lblShow.Text = "答對了!!!";
                if (Ans == 1) btn1.Image = new Bitmap("123.jpg"); //如果ans == 1 即btn1 就會顯示 影像
                if (Ans == 2) btn2.Image = new Bitmap("123.jpg"); //如果ans == 2 即btn1 就會顯示 影像
                if (Ans == 3) btn3.Image = new Bitmap("123.jpg"); //如果ans == 3 即btn1 就會顯示 影像
            }
            else
            {
                lblShow.Text = "猜錯了!!!";
            }
        }
        private void WinButton1_Load(object sender, EventArgs e)
        {
            btnAgain_Click(sender, e); //呼叫btnAgain_Click 事件處理還函示, 產生1-3的亂數指定給guess
            this.Text = "找圖遊戲";
            lblShow.Text = "請找出圖在哪裡!?";
            lblShow.Font = new Font(lblShow.Font.FontFamily, 16, FontStyle.Bold); // 顯示字型為16的粗體文字
        }

        private void btnAgain_Click(object sender, EventArgs e)
        {
            try
            {
                Random r = new Random(); //建立Random 的物件r
                guess = r.Next(1, 4);     //產生1-3的亂數指定給guess
                lblShow.Text = "";
                btn1.Enabled = btn2.Enabled = btn3.Enabled = true;
                btn1.Image = btn2.Image = btn3.Image = null;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            CheckAns(1);       //呼叫CheckAns方法,並傳入答案1
            btn2.Enabled = false;
            btn3.Enabled = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            CheckAns(2);      //呼叫CheckAns方法,並傳入答案2
            btn1.Enabled = false;
            btn3.Enabled = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            CheckAns(3);      //呼叫CheckAns方法,並傳入答案3
            btn2.Enabled = false;
            btn1.Enabled = false; 
        }
    }
}
