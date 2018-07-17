using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exe10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a, b, c, d, j;
            a = Convert.ToSingle(textBox1.Text);
            b = Convert.ToSingle(textBox2.Text);
            c = Convert.ToSingle(textBox3.Text);
            d = Convert.ToSingle(textBox4.Text);
            j = Convert.ToSingle(textBox5.Text);
            label6.Text = ((b) + "-" + (j) + "-" + (a) + "-" + (c) + "-" + (d));

        }
    }
}
