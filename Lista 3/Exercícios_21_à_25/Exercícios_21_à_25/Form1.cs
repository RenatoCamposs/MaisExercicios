using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercícios_21_à_25
{
    public partial class Form1 : Form
    {
        int a,i,b,c,d,soma,maior=-3600,menor=3600;
        double x,y,z,SOMA;
        public Form1()
        {
            i = 0;

            InitializeComponent();
            soma = 0;
            SOMA = 0;
            b = 0;
            c = 0;
            x = 0;
            y = 0;
            z = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) { label2.Text = ("Você é mulher !"); }
            if (radioButton2.Checked == true) { label2.Text = ("Você é homem !"); }
            if (radioButton3.Checked == true) { Application.Exit(); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Pares____Impares");
            for (i = 0; i <= 99; i += 2)
            {
                listBox1.Items.Add(i + "                " + (i + 1));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt16(v1.Text);
            if (a > maior) { maior = a; }
            if (a < menor) { menor = a; }
             SOMA = SOMA + a;
            if (a > 0) { b++; }
            if (a < 0) { c++; }            
            if (a >= 0 && a <= 20)
            {
                i++;
                if (i == 25) { button3.Enabled = false; }
                v1.Focus();
            }
            if (a < 0 || a > 20)
            {
                d++;
                label6.Text = ("Valor incorreto. Digite novamente!");
            }
            listBox2.Items.Add("Maior valor :: " + maior);
            listBox2.Items.Add("Menor valor :: " + menor);
            listBox2.Items.Add("Soma dos valores :: " + SOMA);
            x = SOMA /( Convert.ToDouble(i) + Convert.ToDouble(d));
            listBox2.Items.Add("Média dos valores :: "+x);
            if (b == 0) { y = 0; }
            if (b != 0)
            {
                y = (100 * Convert.ToDouble(b)) / (Convert.ToDouble(i) + Convert.ToDouble(d));
            }
            if (c == 0) { z = 0; }
            if (c != 0)
            {
                z = (100 * Convert.ToDouble(c)) / (Convert.ToDouble(i) + Convert.ToDouble(d));
            }
            listBox2.Items.Add("Percentual dos positivos :: " + (100 - z) + " %");
            listBox2.Items.Add("Percentual dos negativos :: " + (100 - y) + " %");
            listBox2.Items.Add("________________________________________");
            z = 0;
            y = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt16(v2.Text);
            b = Convert.ToInt16(v3.Text);
            textBox3.Text = Convert.ToString(a + " + " + b + " = " + (a + b));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt16(v2.Text);
            b = Convert.ToInt16(v3.Text);
            textBox3.Text = Convert.ToString(a + " - " + b + " = " + (a - b));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt16(v2.Text);
            b = Convert.ToInt16(v3.Text);
            textBox3.Text = Convert.ToString(a + " * " + b + " = " + (a * b));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(v2.Text);
            y = Convert.ToDouble(v3.Text);
            textBox3.Text = Convert.ToString(x + " / " + y + " = " + (x / y));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();    
        }

        private void button9_Click(object sender, EventArgs e)
        {
            for (i = 20; i <= 200; i++)
            {
                listBox3.Items.Add(i + " * " + i + " = " + (i * i));
            }
        }

        
    }
}
