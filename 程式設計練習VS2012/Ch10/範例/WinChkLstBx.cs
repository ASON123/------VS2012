using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 程式設計練習VS2012.Ch10.範例
{
    public partial class WinChkLstBx : Form
    {
        public WinChkLstBx()
        {
            InitializeComponent();
        }

        int[] pcLot = new int[6];
       
        private void WinChkLstBx_Load(object sender, EventArgs e)
        {
            chkListLot.MultiColumn = true;          //水平欄顯示
            chkListLot.ColumnWidth = 45;            //水平欄寬45
            for (int i = 1; i < 49; i++ )
            {
                chkListLot.Items.Add(i.ToString());
            }
            lblShow.Text = "本期未開獎";
        }

        private void btnCheckLot_Click(object sender, EventArgs e)
        {
            int count = 0;
            int i = 0;
            //使用for迴圈看目前勾選幾個按鈕
            for ( i = 0; i < chkListLot.Items.Count;i++ )
            {
                if(chkListLot.GetItemChecked(i))
                {
                    count++;
                }
            }
            if (count != 6) //沒有選擇6個按鈕就會離開此函示
            {
                MessageBox.Show("請選擇6個號碼");
                return;
            }
            SetLot(ref pcLot, 1, 49, pcLot.Length);
                Array.Sort(pcLot);
                string myNumstr = "", pcNumstr = "";
                for ( i = 0; i <= pcLot.GetUpperBound(0);i++ )
                {
                    pcNumstr += pcLot [i].ToString() + ", ";
                }
                for ( i = 0; i < chkListLot .Items .Count;i++ )
                {
                    if(chkListLot.GetItemChecked(i))
                    {
                        myNumstr += chkListLot.Items[i].ToString () + ",";
                    }
                }

                //lblShow 顯示本期開獎號碼 
                lblShow.Text = "本期大樂透號碼如下 \n " + pcNumstr + "\n";
                //判斷是否中獎
                if(pcNumstr == myNumstr)
                {
                    lblShow.Items.Add("恭喜你中獎了!");
                }
                else
                {
                    lblShow.Items.Add("沒中...再接再厲!!");
                }
        }

        private void SetLot(ref int [] choose,int min ,int max,int num)
        {
            int[] lot = new int[50];
            int max_dim, choice;
            int i, j;
            max_dim = max - min + 1;
            for (i = 0; i < max_dim;i++ )
            {
                lot[i] = min + i;
            }
            Random ranObj = new Random();
            for (i = 0; i < num;i++ )
            {
                choice = ranObj.Next(0 , max_dim);
                choose[i] = lot[choice];
                for (j = choice; j < max_dim; j++ )
                {
                    lot[j] = lot[j + 1];
                }
                max_dim--;
            }
             
        }

        private void btnRest_Click(object sender, EventArgs e) // 清除
        {
            for(int i = 0; i < chkListLot.Items.Count; i ++)
            {
                chkListLot.SetItemChecked(i , false);

            }
        }

        private void btnExit_Click(object sender, EventArgs e) //離開
        {
            Application.Exit();
        }

    }
}
