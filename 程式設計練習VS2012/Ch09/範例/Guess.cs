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
    public partial class Guess : Form
    {
        public Guess()
        {
            InitializeComponent();
        }
        int guess, count, min, max;
        private void Guess_Load(object sender, EventArgs e)
        {
            Random r = new Random(); //產生亂數物件r
            guess = r.Next(1 , 100); //產生1-99 亂數當被猜數置入
            min = 1;
            max = 99;
            count = 0;
            lblTitle.Text = min + " < ? < " + max;
            lblShow.Text = "共猜了" + count + "次";
            txtGuess.Text = "";
        }

        private void btnOk_Click(object sender, EventArgs e)//確定
        {
            count += 1;
            int myguess = 0;
            try
            {
                try
                {
                    myguess = int.Parse(txtGuess.Text); //判斷是否輸入數值
                }
                catch
                {
                    MessageBox.Show("請輸入數字");
                }
                if (myguess >= 1 && myguess < 100)
                {
                    if (myguess == guess)
                    {
                        MessageBox.Show("賓果答對了!!!");
                        btnOk.Enabled = false;
                    }
                    else if (myguess > guess)
                    {
                        max = myguess;   //將輸入值取代最大值
                        MessageBox.Show("在小一點...");
                    }
                    else if (myguess < guess)
                    {
                        min = myguess;
                        MessageBox.Show("在大一點...");
                    }
                }
                else
                {
                    MessageBox.Show("輸入提示範圍的數字....");
                }
                lblShow.Text = "共猜了" + count + "次!";
                lblTitle.Text = min + " < ? < " + max;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnAgain_Click(object sender, EventArgs e) //重玩
        {
            Guess_Load(sender,e);   //呼叫執行from表單
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("請問是否離開遊戲? " ,"數字遊戲",MessageBoxButtons.OKCancel,MessageBoxIcon.Information)
                 == System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
