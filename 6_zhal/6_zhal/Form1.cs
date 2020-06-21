using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_zhal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a, b, sum;
            double c;
            c = double.Parse(textBox1.Text);
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                label5.Text = "Не все данные введены";
            }
            else 
            {
                a = double.Parse(textBox1.Text);
                b = double.Parse(textBox2.Text);
                if (radioButton1.Checked == true)
                    sum = (a / 100 * b / 100) * 190;
                else sum = (a / 100 * b / 100) * 400;
                label5.Text = sum.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
