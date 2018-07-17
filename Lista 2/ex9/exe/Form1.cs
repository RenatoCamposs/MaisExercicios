using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            float l, h;
            l = Convert.ToSingle(textBox1.Text);
            h = Convert.ToSingle(textBox2.Text);
            textBox3.Text = Convert.ToString(l * h);
            textBox4.Text = Convert.ToString((l * h) / 15);
        }
    }
}
