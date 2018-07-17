using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_11_certo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int A, B, C;
            A = Convert.ToInt16(textBox1.Text);
            B = Convert.ToInt16(textBox2.Text);
            C = A - B;
            label1.Text = Convert.ToString(C);
        }
    }
}
