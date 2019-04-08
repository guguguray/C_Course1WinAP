using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string acc = "姓名:" +　txtAcc.Text;
            string pwd = "密碼:" + txtPwd.Text;
            String sex =  "性別:";
            String interest = "興趣:";
            string result = "";
            

            if (rdb1.Checked)
            {
                sex += rdb1.Text;
            }
            if (rdb2.Checked)
            {
                sex += rdb2.Text;
            }

            if (chkBox1.Checked)
            {
                interest += chkBox1.Text + "、";
            }
            if (chkBox2.Checked)
            {
                interest += chkBox2.Text + "、";
            }
            if (chkBox3.Checked)
            {
                interest += chkBox3.Text + "、";
            }
            if (chkBox4.Checked)
            {
                interest += chkBox4.Text + "、";
            }

            result = acc + "\n" + pwd + "\n" + sex + "\n" + interest;
            MessageBox.Show($"{result}", "會員資料:");
        }

        private void rdb1_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
