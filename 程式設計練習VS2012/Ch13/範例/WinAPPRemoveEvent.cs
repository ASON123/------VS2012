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
    public partial class WinAPPRemoveEvent : Form
    {
        public WinAPPRemoveEvent()
        {
            InitializeComponent();
        }
        private void MyTextChanged(object sender, EventArgs e)
        {
            try
            {
                int n1, n2;
                n1 = int.Parse(textBox1.Text);
                n2 = int.Parse(textBox2.Text);
                lblAns.Text = (n1 + n2).ToString();
            }
            catch (Exception ex)
            {
                
            }
        }
        private void WinAPPRemoveEvent_Load(object sender, EventArgs e)
        {
            lblAns.Text = "0";
            textBox1.TextChanged += new EventHandler(MyTextChanged);
            textBox2.TextChanged += new EventHandler(MyTextChanged);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            textBox1.TextChanged += new EventHandler(MyTextChanged);
            textBox2.TextChanged += new EventHandler(MyTextChanged);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            textBox1.TextChanged -= new EventHandler(MyTextChanged);
            textBox2.TextChanged -= new EventHandler(MyTextChanged);
        }

    }
}
