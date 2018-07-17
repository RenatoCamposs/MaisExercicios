using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exe15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt16(textBox1.Text);
            b = 2015 - a;
            label3.Text = Convert.ToString(b);
            if (b >= 16)
            {
                label5.Text = "Pode Votar";
            }
            if (b < 16)
            {
                label5.Text = "Não pode votar";
            }
        }
    }
}
