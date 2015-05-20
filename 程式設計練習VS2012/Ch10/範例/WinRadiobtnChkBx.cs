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
    public partial class WinRadiobtnChkBx : Form
    {
        public WinRadiobtnChkBx()
        {
            InitializeComponent();
        }

        private void WinRadiobtnChkBx_Load(object sender, EventArgs e)
        {
            rdb360.Checked = true; //預設xbox360 選項紐被選取       
        }

        private void rdb360_CheckedChanged(object sender, EventArgs e)
        {
            chkps1.Enabled = true;   //chkps1 方塊不失效
            chkps2.Enabled = true;   //chkps2 方塊不失效
            chkps3.Enabled = true;   //chkps3 方塊不失效
            chkbox1.Enabled = false; //chkbox1 方塊失效
            chkbox2.Enabled = false; //chkbox2 方塊失效
            chkbox3.Enabled = false; //chkbox3 方塊失效
        }

        private void rdbps3_CheckedChanged(object sender, EventArgs e)
        {
            chkps1.Enabled = false;
            chkps2.Enabled = false;
            chkps3.Enabled = false;
            chkbox1.Enabled = true;
            chkbox2.Enabled = true;
            chkbox3.Enabled = true;
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "謝謝購買!";
                if (rdb360.Checked)         //判斷Xbox360是否被選取
                {
                    str += rdb360.Text + "\n";
                    if (chkps1.Checked)
                    {
                        str += chkps1.Text + ",";
                    }
                    if (chkps2.Checked)
                    {
                        str += chkps2.Text + ",";
                    }
                    if (chkps3.Checked)
                    {
                        str += chkps3.Text + ",";
                    }
                    else if (rdbps3.Checked)
                    {
                        str += rdbps3.Text + "\n";
                        if (chkbox1.Checked)
                        {
                            str += chkbox1.Text + ",";
                        }
                        if (chkbox2.Checked)
                        {
                            str += chkbox2.Text + ",";
                        }
                        if (chkbox3.Checked)
                        {
                            str += chkbox3.Text + ",";
                        }
                    }
                }
                MessageBox.Show(str);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
