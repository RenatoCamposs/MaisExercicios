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

        private void button1_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(textBox1.Text);

            if (a < 0)
            {
                label2.Text = "Este valor é negativo";
            }

            else
                label2.Text = "Este valor é positivo";
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
