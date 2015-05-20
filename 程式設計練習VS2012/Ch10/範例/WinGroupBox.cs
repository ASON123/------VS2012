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
    public partial class WinGroupBox : Form
    {
        public WinGroupBox()
        {
            InitializeComponent();
        }
        private void WinGroupBox_Load(object sender, EventArgs e)
        {
            rdbbox360.Checked = true;
        }
        private void rdbbox360_CheckedChanged(object sender, EventArgs e) //Xbox360 紐
        {
            rdbbox360.Enabled = true;
            rdbps3.Enabled = false;
        }
        private void rdbps3_CheckedChanged(object sender, EventArgs e) //PS3紐
        {
            rdbbox360.Enabled = false;
            rdbps3.Enabled = true;
        }

        private void btnOK_Click(object sender, EventArgs e) //確定
        {
            string str = "謝謝你購買";
            if (rdbbox360.Checked)
            {
                str += rdbbox360.Text + ",";
                if (chkxb1.Checked)
                {
                    str += chkxb1.Text + ",";
                }
                if (chkxb3.Checked)
                {
                    str += chkxb3.Text + ",";
                }
            }
            else if (rdbps3.Checked)
            {
                str += rdbps3.Text + ",";
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
                    str += chkps3.Text = ",";
                }

            }
            MessageBox.Show(str);
        }
    }
}






