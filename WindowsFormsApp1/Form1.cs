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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 處理運算
            double myCalc = (1 + 2) * 10 / 6;
            double myCalc2 = 7 * 3 % 8;
            string myStr = "MON" + "PQ";
            string myStr2 = "C" + "Z";
            double myCalc3 = 10.5 % 3;
            String myMsg = "myCalc = " + myCalc.ToString() + "\n" + "myCalc2 = " + myCalc2.ToString() + "\n" 
                + "myStr = " + myStr + "\n" + "myStr2 = " + myStr2 + "\n" + "myCalc3 = " + myCalc3.ToString();
            MessageBox.Show(myMsg, "Calc 結果視窗", MessageBoxButtons.YesNoCancel);

            

            int i, j;
            string sp ="", star = "";

            for (i=1; i<4; i++)
            {
                for (j=1; j< 4; j++)
                {

                }
            }                                      
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 取int型態的最大最小值
            int minValue = int.MinValue;
            int maxValue = int.MaxValue;
            MessageBox.Show($"顯示 int 最小最大值，最小:{minValue}  最大:{maxValue}", "最大最小值顯示對話框");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 輸出溢位狀況
            int minValue = int.MinValue;
            int maxValue = int.MaxValue;
            int overFlowchk = maxValue + 2;
            MessageBox.Show($"顯示超過最大值產生溢位，得到的結果:{overFlowchk}", "溢位 顯示");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 計算圓周率
            int radius = 3;
            double area = Math.PI * radius * radius;
            MessageBox.Show($"半徑 = {radius}, 直徑 = {radius * 2}, PI = {Math.PI}, 圓周率 = {area}", "圓周率 = PI R 平方");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = 3;
            b = 4;
            c = 10;
            
            if ((a+b+c > 10 && a > b) || (a + b + c < 10 && a > b)) 
            {
                MessageBox.Show($"a{a} > b{b}", "IF..ELSE");
            }
            else
                MessageBox.Show($"a:{a} < b:{b}", "IF..ELSE");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int i = 0;
            int count = 0;
            while (i < 9)
            {
                count += 1;
                MessageBox.Show($"i={i} Count total:{count}", "While..");
                i = i + 1;
                
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int i, j;
            string sp, star, totalstr = "";

            for (i=0; i<4; i++)
            {
                sp = "";
                star = "";

                for (j=1; j<(4-i); j++)
                {
                    sp += " ";
                }
                

                for (j=0; j <(i+1); j++)
                {
                    star += "* ";
                }
                totalstr += sp + star + "\n";             

            }
            MessageBox.Show($"{totalstr}", "For..");





        }

        private void button8_Click(object sender, EventArgs e)
        {
            int i, j;
            int results=1;
            string charts = "";
            
            for (i=1; i<=9; i++)
            {
                for (j = 1; j <= 9; j++)
                {
                    results = i * j;
                    charts = charts + $"{i}*{j}={results}\t";
                }
                charts = charts + "\n\n";
            }
            MessageBox.Show($"{charts}", "9x9 乘法表");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            // 數入半徑並計算圓周率
            double radius = Convert.ToDouble(textBox1.Text);

            double area = Math.PI * radius * radius;
            MessageBox.Show($"半徑 = {radius}, 直徑 = {radius * 2}, PI = {Math.PI}, \n圓周率 = {area}", "圓周率 = PI R 平方");
            // MessageBox.Show(textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Translate check
            string myStr = txtTrans.Text;

            if (myStr.ToLower() == "apple")
            {
                MessageBox.Show("BinGo!!", "翻譯檢查");
            }
            else
                MessageBox.Show("Answer Wrong!! Please retry!", "翻譯檢查");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // List 應用
            List<string> mylist = new List<string>();
            mylist.Add("apple");
            mylist.Add("orange");
            mylist.Add("banana");
            List<int> mylist2 = new List<int>();
            mylist2.Add(3);
            mylist2.Add(5);
            mylist2.Add(6);
            if (mylist2.Contains(2))
            {
                MessageBox.Show("test", "Lists");
            }
            else
            {
                mylist2.Add(2);
                foreach (int item in mylist2)
                {
                    MessageBox.Show($"{item}", "Lists");
                }
                
            }

            string myStr = "";

            foreach (string fruit in mylist)
            {
                myStr += fruit + "\n";
            }
            MessageBox.Show($"{myStr}", "Lists");

        }

        private void btnRand_Click(object sender, EventArgs e)
        {
            try
            {
                int minValue = Convert.ToInt16(txtMin.Text);
                int maxValue = Convert.ToInt16(txtMax.Text);
                int times = Convert.ToInt16(txtTimes.Text);
                String result = "";
                List<int> mylist = new List<int>();
                Random rnd = new Random();
                int rndno = 0, count = 0;
                

                for (int i=1; i<=times; i++)
                {
                    count++;
                    rndno = rnd.Next(minValue, maxValue);
                    //result += rnd.Next(minValue, maxValue) + "\t";
                    // 檢查產生的亂數是否存在於 list 中
                    //亂數在 list 中 ==> 次數-1 ，重新產生亂數
                    if (mylist.Contains(rndno)){
                        i = i - 1;
                    }
                    //亂數不在list中 ==> 新增亂數到 list 中
                    else {
                        mylist.Add(rndno);
                    }
                   
                }

                foreach (int item in mylist)
                {
                    result += item.ToString() + "\n";
                }
                MessageBox.Show($"次數: {count}\n亂數內容:\n{result}", "取得亂數");
            }
            catch (Exception ex)
            {                
                throw ex;
            }
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
