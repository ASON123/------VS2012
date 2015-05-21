using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 程式設計練習VS2012.Ch11.範例
{
    public partial class WinNumericUPDn : Form
    {
        public WinNumericUPDn()
        {
            InitializeComponent();
        }
        //宣告num的陣列用來存放數字和英文單字
        string[] num = new string[] { "one", "tow", "three", "four", "five", "six", "seven", "eight", "ning", "ten" };
        private void WinNumericUPDn_Load(object sender, EventArgs e)
        {
            numericUpDown1.Minimum = 1; //最小值為1
            numericUpDown1.Maximum = 10; //最大值為10
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int n = int.Parse(numericUpDown1.Value.ToString()) -1; //將數字上下鈕-1時即取得num陣列的索引
            lblShow.Text = "英文 : " + num[n]; //顯示結果
        }

    }
}
