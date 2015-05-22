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
    public partial class WinToolStrip : Form
    {
        public WinToolStrip()
        {
            InitializeComponent();
        }

        private void WinToolStrip_Load(object sender, EventArgs e)
        {
            richTextBox1.Dock = DockStyle.Fill;
        }

        private void tsbOpen_Click(object sender, EventArgs e)//開檔
        {
            try
            {
                richTextBox1.LoadFile("GOTOP.rtf" , RichTextBoxStreamType.RichText);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tsbSave_Click(object sender, EventArgs e)//存檔
        {
            richTextBox1.SaveFile("GOTOP.rtf", RichTextBoxStreamType.RichText);
        }

        private void tsbCls_Click(object sender, EventArgs e)//清除
        {
            richTextBox1.Text = "";
        }

        private void tsbBullet_Click(object sender, EventArgs e)//項目符號
        {
            richTextBox1.SelectionBullet = !richTextBox1.SelectionBullet;
        }

        private void cboSize_Click(object sender, EventArgs e) //字型
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily.ToString(),
                float.Parse(cboSize.Text),richTextBox1.Font.Style);
        }

        private void 黑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Black;
        }

        private void 紅ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Red;
        }

        private void 綠ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Green;
        }

        private void 藍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Blue;
        }
        
    }
}
