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
    public partial class WinpictureBox : Form
    {
        public WinpictureBox()
        {
            InitializeComponent();
        }

        private void WinpictureBox_Load(object sender, EventArgs e)
        {
            string[] photo = new string[] {"田園","雪山","山林","月亮"};
            cboPhotoName.Items.Add(photo);
            cboPhotoName.SelectedIndex = 1;
            pic.BorderStyle = BorderStyle.Fixed3D;
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void cboPhotoName_SelectedIndexChanged(object sender, EventArgs e)
        {
             
             pic.Image =  new Bitmap(cboPhotoName.Text + ".jpg");
        }
    }
}
