using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string num1 = textBox1.Text;
            string op = comboBox1.Text;
            string num2 = textBox2.Text;

            

            switch (op)
            {
                case "+":
                    textBox3.Text = Convert.ToString(Convert.ToDouble(num1) + Convert.ToDouble(num2));
                    break;

                case "-":
                    textBox3.Text = Convert.ToString(Convert.ToDouble(num1) - Convert.ToDouble(num2));
                    break;

                case "*":
                    textBox3.Text = Convert.ToString(Convert.ToDouble(num1) * Convert.ToDouble(num2));
                    break;

                case "/":
                    if (num2 == "0")
                    {
                        textBox3.Text = "invalid input";
                        break;
                    }
                    textBox3.Text = Convert.ToString(Convert.ToDouble(num1) / Convert.ToDouble(num2));
                    break;

                default:
                    textBox3.Text = "invalid input";
                    break;
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
