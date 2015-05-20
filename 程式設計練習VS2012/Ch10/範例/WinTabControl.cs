using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 程式設計練習VS2012.Ch10.範例
{
    public partial class WinTabControl : Form
    {
        public WinTabControl()
        {
            InitializeComponent();
        }
        class Employee // 定義員工類別
        {
            public string EmpID { get; set; }    //編號屬性
            public string EmpName { get; set; }  //姓名屬性
            public string EmpSex { get; set; }   //性別屬性
            public bool EmpIsMarry { get; set; } //婚姻屬性
        }
        List<Employee> emp = new List<Employee>(); //建立Emp串列物件用來存放Member
        private void WinTabControl_Load(object sender, EventArgs e)
        {
            txtShow.Dock = DockStyle.Fill; //txtShow 文字方塊填滿整個標籤頁
            txtID.Font = new Font(txtShow.Font.FontFamily , 14 , FontStyle.Regular); // Show 字型大小
            txtShow.ReadOnly = true;
            txtShow.Multiline = true;
            rdbF.Checked = true;  //預設男為初始扭

        } 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sex = "";
            if(rdbM.Checked)
            {
                sex = "先生";
            }
            else
            {
                sex = "小姐";
            }
            emp.Add(new Employee() { EmpID = txtID.Text,EmpName = txtName.Text,EmpSex = sex,EmpIsMarry = chkMarry.Checked});
            MessageBox.Show("會員新增成功");
            //還原預設值
            txtID.Text = "";
            txtName.Text = "";
            rdbF.Checked = true;
            chkMarry.Checked = false;
        }
        
        private void tabContorll_SelectedIndexChanged(object sender,EventArgs e)
        {
            if(tabControl1.SelectedIndex == 1) //判斷是否切換到會員列表
            {
                txtShow.Text = "編號\t姓名\t性別\t是否已婚" + Environment.NewLine;
                txtShow.Text += "=========================" + Environment.NewLine;
                for (int i = 0; i < emp.Count;i++ )
                {
                    txtShow.Text += emp[i].EmpID + "\t" + emp[i].EmpName + "\t" + emp[i].EmpSex + "\t" + emp[i].EmpIsMarry.ToString() + Environment.NewLine;
                }

            }
        }
        private void tabPage1_Click(object sender, EventArgs e) 
        {
           
        }

       

        
    }
}
