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
    public partial class WinTextBox : Form
    {
        public WinTextBox()
        {
            InitializeComponent();
        }

        private void WinTextBox_Load(object sender, EventArgs e)
        {
            string[] address = new string[] { "台中市大雅區","台中市神岡區","台中市太平區","台中市西區"};
            AutoCompleteStringCollection myadd = new AutoCompleteStringCollection();
            myadd.AddRange(address);
            txtAdd.AutoCompleteCustomSource = myadd;
            txtAdd.AutoCompleteMode = AutoCompleteMode.Append;
            txtAdd.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtPage.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtPage.AutoCompleteSource = AutoCompleteSource.HistoryList;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("公司 : " + txtCompany.Text + "\n住址" + txtAdd.Text + "\n網站" + txtPage.Text );
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
