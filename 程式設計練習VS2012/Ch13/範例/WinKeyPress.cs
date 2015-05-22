using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 程式設計練習VS2012.Ch13
{
    public partial class WinKeyPress : Form
    {
        public WinKeyPress()
        {
            InitializeComponent();
        }



        private void WinKeyPress_Load(object sender, EventArgs e)
        {
            txtPrice.Text = "0"; //單價
            txtQty.Text = "0";   //數量
            txtTotal.Text = "0";
            txtTotal.ReadOnly = true;
        }

        private void txtId_TextChanged(object sender, EventArgs e) 
        {
            int Loc = txtId.SelectionStart; //儲存目前由標位子
            txtId.Text = txtId.Text.ToUpper();
            txtId.SelectionStart = Loc; //將遊標位子還原到原來位子
        }
        private void txtId_KeyPress (object sender , KeyPressEventArgs e )
        {
            if(txtId.Text.Length < 6)
            {
                if(txtId.SelectionStart == 0)
                {
                    string S = e.KeyChar.ToString().ToUpper();
                    if(S.CompareTo("A") < 0 || S.CompareTo("Z") > 0)
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    if(e.KeyChar.CompareTo('0') < 0 ||e.KeyChar.CompareTo('9') > 0)
                    {
                        if(e.KeyChar != '\b')
                        {
                            e.Handled = true;
                        }
                    }
                }
            }
            else
            {
                if(e.KeyChar != '\b')
                {
                    e.Handled = true;
                }
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int price = int.Parse(txtId.Text);
                int qty = int.Parse(txtQty.Text);
                txtTotal.Text = (price * qty).ToString();
            }catch
            {
            }
        }
        private void txtPrice_KeyPass(object sender , KeyPressEventArgs e )
        {
            if((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != '\b'))
            {
                e.Handled = true;
            }
        }
        private void txtQty_Text (object sender , EventArgs e )
        {
            try
            {
                int price = int.Parse(txtPrice.Text);
                int qty = int.Parse(txtQty.Text);
                txtTotal.Text = (price * qty).ToString();
            }catch
            {

            }
        }
        private void txtQty_KeyPass(object sender , KeyPressEventArgs e )
        {
            if((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != '\b'))
            {
                e.Handled = true;
            }
        }
    }
}
