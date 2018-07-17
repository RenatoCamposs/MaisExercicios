using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
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


        private void label2_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt16(textBox1.Text);
            b = Convert.ToInt16(textBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt16(textBox1.Text);
            b = Convert.ToInt16(textBox2.Text);
            label2.Text = Convert.ToString(a * b);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt16(textBox1.Text);
            b = Convert.ToInt16(textBox2.Text);
            label2.Text = Convert.ToString(a + b);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt16(textBox1.Text);
            b = Convert.ToInt16(textBox2.Text);
            label2.Text = Convert.ToString(a / b);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt16(textBox1.Text);
            b = Convert.ToInt16(textBox2.Text);
            label2.Text = Convert.ToString(a - b);
        }
    }
}
