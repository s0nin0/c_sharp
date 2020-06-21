using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_Cafe
{
    public partial class Form1 : Form
    {
        int sum = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) {
                sum += 40;
                checkBox3.Enabled = true;
            }
            else {
                sum -= 40;
                checkBox3.Enabled = false;
                checkBox3.Checked = false;
            }
            label3.Text = sum.ToString();
        }
       
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true) sum += 35;
            else sum -= 35;
            label3.Text = sum.ToString();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true) sum += 7;
            else sum -= 7;
            label3.Text = sum.ToString();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true) sum += 14;
            else sum -= 14;
            label3.Text = sum.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false && checkBox4.Checked == false && checkBox5.Checked == false)
                MessageBox.Show("Вы ничего не заказали", "Расчет");
            else if(checkBox1.Checked == true && checkBox4.Checked == true && checkBox5.Checked == true && checkBox3.Checked == true)
                MessageBox.Show("Вам предоставляется скидка 10%. Стоимость заказа " + (sum*0.9) + " грн.", "Расчет");
            else MessageBox.Show("Стоимость заказа " + sum, "Расчет");
        }
    }
}
