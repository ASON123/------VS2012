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
    public partial class WinContexMentStrip : Form
    {
        public WinContexMentStrip()
        {
            InitializeComponent();
        }


        private void WinContexMentStrip_Load(object sender, EventArgs e)
        {
            richTextBox1.Dock = DockStyle.Fill;
        }
        private void 清除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void 開檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.LoadFile("GOTOP.rtf", RichTextBoxStreamType.RichText);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void 儲存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile("GOTOP.rtf" , RichTextBoxStreamType.RichText);
        }

        private void 結束ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 項目符號ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBullet = !richTextBox1.SelectionBullet;
        }

        private void cboSize_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(cboSize.Font.FontFamily.ToString(), float.Parse(cboSize.Text), richTextBox1.Font.Style);
        }

        private void cbofontColor_Click(object sender, EventArgs e)
        {
            if(cbofontColor.Text == "黑")
            {
                richTextBox1.SelectionColor = Color.Black;
            }
            if(cbofontColor.Text == "紅")
            {
                richTextBox1.SelectionColor = Color.Red;
            }
            if(cbofontColor.Text == "綠")
            {
                richTextBox1.SelectionColor = Color.Green;
            }
            if(cbofontColor.Text == "藍")
            {
                richTextBox1.SelectionColor = Color.Blue;
            }
        }

        private void 複製ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void 貼上ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void 剪下ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        
    }
}
