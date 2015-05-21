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
    public partial class WinListCombo : Form
    {
        public WinListCombo()
        {
            InitializeComponent();
        }
        class Member
        {
            public string Name { get; set; }             //姓名屬性
            public DateTime BirthDay { get; set; }      // 生日屬性
            public string sex { get; set; }             //性別屬性
            public string Job { get; set; }             //職業屬性
        }
        List<Member> m = new List<Member>();            //建立m 串列物件用來存放Member 會員物件
        private void WinListCombo_Load(object sender, EventArgs e)
        {
            cboyear.Text = (DateTime.Now.Year - 100).ToString(); // 年下拉式清單預設值為100年前
            cboMonth.Text = ("1"); // 月下拉式清單預設值為1
            cboDay.Text = ("1"); //  日下拉式清單預設值為1
            for (int i = DateTime.Now.Year  -100; i <= DateTime.Now.Year; i++ ) //下拉式清單的範圍100年前~今年
            {
                cboyear.Items.Add(i.ToString());
            }
            for (int i = 1; i < 12; i++)
            {
                cboMonth.Items.Add(i.ToString());
            }
            for (int i = 1; i < 31; i++ )
            {
                cboDay.Items.Add(i.ToString());
            }
            rdbM.Checked = true; //男選項鈕預設被選取
            string[] Job = new string[] { "學生","公教","服務","製造","家管","其他"};
            lstJob.Items.AddRange(Job);
            lstJob.SelectedIndex = 0;
            
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(cboName.Text == "") //檢查姓名是否為空字串
            {
                MessageBox.Show("請輸入姓名");
                return;  //離開事件
            }
            bool find = false; 
            for(int i = 0; i < m.Count;i++)
            {
                if(m[i].Name == cboName.Text)
                {
                    find = true; //如果有找到則find設為true
                    break;
                }
            }
            if(find) //若find為true 表示有該筆資料
            {
                MessageBox.Show("資料已存在");
                return; 
            }
            else
            {
                DateTime MyBirthDay = new DateTime();
                try
                {
                    MyBirthDay = DateTime.Parse(cboyear.Text + "/" + cboMonth.Text + "/" + cboDay.Text );
                }
                catch(Exception ex)
                {
                    MessageBox.Show("生日有誤!!!");
                    MessageBox.Show(ex.ToString());
                    return; //如果生日有誤離開此事件!!
                }
                cboName.Items.Add(cboName.Text);

                m.Add(new Member()
                {
                    Name = cboName.Text,
                    BirthDay = MyBirthDay,
                    sex = rdbF.Checked ? "男" : "女",
                    Job = lstJob.SelectedIndex.ToString()
                });
                MessageBox.Show("會員新增成功");
            }
        }

        private void cboName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int index = cboName.SelectedIndex;
                cboyear.Text = m[index].BirthDay.Year.ToString();
                cboMonth.Text = m[index].BirthDay.Month.ToString();
                cboDay.Text = m[index].BirthDay.Day.ToString();
                if (m[index].sex == "男")
                {
                    rdbM.Checked = true;
                }
                else
                {
                    rdbF.Checked = true;
                }
                int JobIndex = lstJob.FindString(m[index].Job);
                lstJob.SelectedIndex = JobIndex;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
