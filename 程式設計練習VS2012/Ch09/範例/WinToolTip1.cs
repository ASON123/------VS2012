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
    public partial class WinToolTip1 : Form
    {
        public WinToolTip1()
        {
            InitializeComponent();
        }

        private void WinToolTip1_Load(object sender, EventArgs e)
        {
            lbl1.Text = "宇辰系統";
            toolTip1.IsBalloon = true; //使用氣球的形式
            toolTip1.ToolTipIcon = ToolTipIcon.Info; //顯示資訊圖示 ICON
            toolTip1.ToolTipTitle = "公司網站~~~~~"; //設定工具提示標題
            lbl1.LinkColor = Color.Yellow;
            toolTip1.BackColor = Color.Yellow;      //設定工具提示背景
            toolTip1.SetToolTip(lbl1, "系統資訊");
            lbl2.Text = "請聯絡我們";
            lbl2.LinkColor = Color.Red; ;       //設定文字為連結
            toolTip2.SetToolTip(lbl2, "歡迎來信");
            lbl3.Text = "奇摩網站";
            lbl3.LinkColor = Color.Green;
            lbl4.Text = "Google";
            lbl4.LinkColor = Color.Pink;
        }

        private void lbl1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.yuchens.com/");//連結到網站
        }

        private void lbl2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:asonxu@yuchens.com");//連結到Email
        }

        private void lbl3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://yahoo.com.tw");
        }

        private void lbl4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://google.com");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
