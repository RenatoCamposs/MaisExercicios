using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercícios_6_à_10
{
    public partial class Form1 : Form
    {
        int a, b, c, i,maior,menor;
        public Form1()
        {
            InitializeComponent();
            i = 0;
            maior = -3600;
            menor=3600;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt16(v1.Text);
            for (i = 0; i <= 10; i++)
            {
               listBox1.Items.Add(a + " * " + i + " = " + a * i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (i = 1; i <= 10; i+=2)
            {
                listBox2.Items.Add(i);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt16(v2.Text);
            label6.Text = Convert.ToString(Math.Round(Math.Sqrt(a)));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt16(v3.Text);
            b=1;
            for (i = 1; i <= a; i++)
            {
                b = b * i;
                textBox2.Text = Convert.ToString(a + " ! = " + b);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            listBox3.Items.Add(v4.Text);
            a = Convert.ToInt16(v4.Text);
            if (a > maior && a != 0) { maior = a; }
            if (a < menor && a != 0) { menor = a; }
            textBox3.Text = Convert.ToString(maior);
            textBox4.Text = Convert.ToString(menor);
            i++;
                label10.Text = "Digite o " + i + "º número ::";
                if (a == 0 || a == 0) { Application.Exit(); }
                if (i > 50) { button5.Enabled = false;  }
                v4.Focus();
                
            
                       
        }
    }
}
