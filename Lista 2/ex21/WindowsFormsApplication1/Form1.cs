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
            double a, b;
            a = Convert.ToDouble(textBox1.Text);
            b = a / 60;
            if(b==1)
            {
            label2.Text = Convert.ToString("O total em minutos é igual a " +  b + " hora.");
            }
            
            else
            {
            label2.Text = Convert.ToString("O total em minutos são iguais a " + b + " horas.");
            }
        }
    }
}
