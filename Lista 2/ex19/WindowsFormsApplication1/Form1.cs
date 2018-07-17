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

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt16(textBox1.Text);
            b = 2015-a;
            if (b >= 0 && b <= 10)
            {
                label2.Text = ("De acordo com sua data de nascimento, você é uma criança!");
            }
            if (b >= 11 && b <= 19)
            {
                label2.Text = ("De acordo com sua data de nascimento, você é um jovem!!");
            }
            if (b >= 20 && b <= 59)
            {
                label2.Text = ("De acordo com sua data de nascimento, você é um adulto!");
            }
            if (b >=60)
            {
                label2.Text = ("De acordo com sua data de nascimento, você é um idoso!");
            }

            if (b >= 100)
            {
                label2.Text = ("De acordo com sua data de nascimento, você é velho pra cacete!");
            }

            if (b<0)
            {
                label2.Text = ("De acordo com sua data de nascimento, você sera um belo idiota!");
            }
        }
    }
}
