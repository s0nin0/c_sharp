using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace автозаправка
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("92");
            comboBox1.Items.Add("95");
            comboBox1.Items.Add("98");
            comboBox1.Items.Add("ДТ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            double price, sum, litrs;
            n = comboBox1.SelectedIndex;
            switch (n)
            {
                case 0:
                    price = 14.85;
                    break;
                case 1:
                    price = 15.05;
                    break;
                case 2:
                    price = 16.80;
                    break;
                case 3:
                    price = 14.55;
                    break;
                default:
                    price = 0;
                    break;
            }
            if(price == 0 || textBox1.Text == "")
            {
                label5.Text = "";
                label8.Text = "Не все данные выбраны!!";
            }
            else
            {
                label5.Text = price.ToString();
                sum = double.Parse(textBox1.Text);
                litrs = Math.Round(sum / price, 2);
                label8.Text = litrs.ToString();
            }
        }
    }
}
