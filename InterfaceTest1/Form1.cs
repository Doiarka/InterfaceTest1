using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceTest1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        interface IList
        {
            string Text { get; set; }
        }

        class MyList : IList
        {
            public string Text { get; set; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IList l = new MyList();
            l.Text = "Запись 1";
            textBox1.Text += l.Text + "\r\n";

            MyList ml = new MyList();
            ml.Text = "Запись 2";
            textBox1.Text += ml.Text;
        }
    }
}
