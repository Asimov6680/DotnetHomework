using SimpleCrawler;
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

namespace Homework_10
{
    public partial class Form1 : Form
    {
        private Hashtable urls = new Hashtable();
        private SimpleCrawler0 myCrawler;
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            myCrawler = new SimpleCrawler0();
            textBox2.Clear();
            
            string startUrl = textBox1.Text;

            myCrawler.Urls.Add(startUrl, false);//加入初始页面
            new Thread(myCrawler.Crawl).Start();

            //while (!myCrawler.Message.EndsWith("爬行完毕"))
            //{
                //textBox2.Text = myCrawler.Message;
                //Thread.Sleep(100);
            //}
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = myCrawler.Message;
        }
    }
}
