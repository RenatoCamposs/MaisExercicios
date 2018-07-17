using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exe3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a, b, c, x;
            a = Convert.ToSingle(textBox1.Text);
            b = Convert.ToSingle(textBox2.Text);
            c = Convert.ToSingle(textBox3.Text);
            x = Convert.ToSingle(textBox3.Text);

            textBox4.Text = Convert.ToString((a*(x* x)) + (25 * b) + c);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
