using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 程式設計練習VS2012.Ch12.範例
{
    public partial class WinMenuStrip : Form
    {
        public WinMenuStrip()
        {
            InitializeComponent();
        }

        private void WinMenuStrip_Load(object sender, EventArgs e)
        {
            richTextBox1.Dock = DockStyle.Fill; // 將dock填滿整個表單
        }

        private void 開檔OToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            try
            {
                richTextBox1.LoadFile("GOTOP.rtf", RichTextBoxStreamType.RichText);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void 存檔SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile("GOTOP.rtf",RichTextBoxStreamType.RichText);
        }

        private void 清除RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void 結束EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 項目符號ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBullet = !richTextBox1.SelectionBullet;
        }

        private void cboSize_Click(object sender, EventArgs e) //設定選取字型的樣式
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily.ToString(),float.Parse(cboSize.Text),richTextBox1.Font.Style);
        }

        private void cbofontcolor_Click(object sender, EventArgs e) //設定字型的顏色
        {
            if(cbofontcolor.Text == "黑")
            {
                richTextBox1.SelectionColor = Color.Black;
            }
            if(cbofontcolor.Text == "紅")
            {
                richTextBox1.SelectionColor = Color.Red;
            }

            if(cbofontcolor.Text == "綠")
            {
                richTextBox1.SelectionColor = Color.Green;
            }
            if(cbofontcolor.Text == "藍")
            {
                richTextBox1.SelectionColor = Color.Blue;
            }
        }
        
    }
}
