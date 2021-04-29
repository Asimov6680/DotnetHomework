using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Homework9_1;
using SimpleCrawler;

namespace Homework9_2
{
    public partial class Form1 : Form
    {
        private Hashtable urls = new Hashtable();
        private int count = 0;
        private SimpleCrawler0 myCrawler = new SimpleCrawler0();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string startUrl = textBox1.Text;

            myCrawler.Urls.Add(startUrl, false);//加入初始页面
            new Thread(myCrawler.Crawl).Start();
  
            textBox2.Text = myCrawler.Message;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = myCrawler.Message;
        }
    }
}
