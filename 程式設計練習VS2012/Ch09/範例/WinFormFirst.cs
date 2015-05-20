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
    public partial class WinFormFirst : Form
    {
        public WinFormFirst()
        {
            InitializeComponent();
        }

        private void WinFormFirst_Load(object sender, EventArgs e)
        {
            lbl1.Text = "載入表單執行時....";
            lbl1.Font = new Font("細明體", 14 , FontStyle.Regular);
            this.BackColor = Color.Blue; //this 為目前表單 , 背景色為藍色
        }

        private void lbl1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lbl1.Text = "按一下表單....";
            this.BackColor = Color.Yellow;
        }

    }
}
