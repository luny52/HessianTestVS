using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using hessiancsharp.client;


namespace HessianTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //er66
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = @"http://127.0.0.1:80/Hello";
            CHessianProxyFactory factory = new CHessianProxyFactory();

            Isay test = (Isay)factory.Create(typeof(Isay), url);

            textBox1.Text = test.sayHello("C# call","C# p");
            textBox1.Text += test.sayHello2("C# call", "C# p");
        }
    }
}
