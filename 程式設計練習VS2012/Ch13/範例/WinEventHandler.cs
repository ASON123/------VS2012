using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 程式設計練習VS2012.Ch13.範例
{
    public partial class WinEventHandler : Form
    {
        public WinEventHandler()
        {
            InitializeComponent();
        }

        

        private void WinEventHandler_Load(object sender, EventArgs e)
        {
            lblShow.Text = "";
        }
       

        private void btn1_Click(object sender, EventArgs e)
        {
            Button btnHit;
            btnHit = (Button)sender;
            lblShow.Text = "目前按下 " + btnHit.Text ;
        }
    }
}
