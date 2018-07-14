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

        interface IList<T>
        {
            T Id { get; }
        }

        class MyList<T> : IList<T>
        {
            public T _id;
            public MyList(T id)
            {
                _id = id;
            }
            public T Id { get { return _id; } }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IList<int> l = new MyList<int>(123);
            textBox1.Text += l.Id + "\r\n";

            IList<string> ml = new MyList<string>("456");
            textBox1.Text += ml.Id;
        }
    }
}
