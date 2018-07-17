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

      
        private void button2_Click(object sender, EventArgs e)
        {
            int a, b, c, d, f, segundoMaior = 0, maior = 1;
            a = Convert.ToInt16(textBox1.Text);
            if (a > maior)
            {
                maior = a;
            }
            else if (a > segundoMaior)
            {
                segundoMaior = a;
            }

            b = Convert.ToInt16(textBox2.Text);
            if (b > maior)
            {
                maior = b;
            }
            else if (b > segundoMaior && maior > b)
            {
                segundoMaior = b;
            }

            c = Convert.ToInt16(textBox3.Text);
            if (c > maior)
            {
                maior = c;
            }
            else if (c > segundoMaior && maior > c)
            {
                segundoMaior = c;
            }

            d = Convert.ToInt16(textBox4.Text);
            if (d > maior)
            {
                maior = d;
            }
            else if (d > segundoMaior && maior > d)
            {
                segundoMaior = d;
            }

            f = Convert.ToInt16(textBox5.Text);
            if (f > maior )
            {
                maior = f;
            }
            else if (f > segundoMaior && maior > f)
            {
                segundoMaior = f;
            }


            label3.Text = ("O maior numero é " + maior);
            label4.Text = ("E o segundo maior é " + segundoMaior);
        }
    }
}
