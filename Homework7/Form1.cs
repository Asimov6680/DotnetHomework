using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework7
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label8.Text = "";
                if (graphics == null) graphics = this.CreateGraphics();
                graphics.Clear(Color.White);
                int n = Int32.Parse(nTextBox.Text);
                double len = Double.Parse(lenTextBox.Text);
                drawCayleyTree(n, 200, 310, len, -Math.PI / 2);
            }
            catch (FormatException)
            {
                label8.Text = "输入格式错误!";
            }
        }

        private Graphics graphics;
        double th1 = 30 * Math.PI / 180;
        double th2= 20 * Math.PI / 180;
        double per1=0.6;
        double per2=0.7;

        
        void drawCayleyTree(int n,double x0,double y0,double leng,double th)
        {
            th1 = Double.Parse(th1TextBox.Text);
            th2 = Double.Parse(th2TextBox.Text);
            per1 = Double.Parse(per1TextBox.Text);
            per2 = Double.Parse(per2TextBox.Text);

            if (n == 0) return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }

        void drawLine(double x0,double y0,double x1,double y1)
        {
            Pen p = null;

            switch (penComboBox.Text)
            {
                case "Black":
                    p = Pens.Black;
                    break;
                case "Red":
                    p = Pens.Red;
                    break;
                case "Silver":
                    p = Pens.Silver;
                    break;
                case "Blue":
                    p = Pens.Blue;
                    break;
                case "Gray":
                    p = Pens.Gray;
                    break;
                default:
                    p = Pens.Black;
                    break;
            }
            graphics.DrawLine(
                p,(int)x0,(int)y0,(int)x1,(int)y1
                );
        }

        
    }
}
