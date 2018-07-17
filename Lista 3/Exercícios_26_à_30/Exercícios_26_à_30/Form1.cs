using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercícios_26_à_30
{
    public partial class Form1 : Form
    {
        int a, b, c, d,m,f,g,h,i,j,k,l,maior=-3600,soma;
        string A;
        public Form1()
        {
            InitializeComponent();
            soma=0;
            a = 0;
            b = 0;
            c = 0;
            d = 0;
            m = 0;
            f = 0;
            g = 0;
            h = 0;
            i = 0;
            j = 0;
            k = 0;
            l = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt16(v1.Text);
            if (radioButton1.Checked == true) { b++; }
            if (radioButton2.Checked == true) { c++; }
            if (radioButton3.Checked == true) { d++; }

            if (radioButton4.Checked == true) { m++; }
            if (radioButton5.Checked == true) { f++; }
            if (radioButton6.Checked == true) { g++; }

            if (radioButton7.Checked == true) { h++; }
            if (radioButton8.Checked == true) { i++; }
            if (radioButton9.Checked == true) { j++; }
            if (a > maior) { maior = a; }
            l++;
            if (a > 35) { k++; }
            listBox1.Items.Add("Percentual de Zero Km:: " + (100 * Convert.ToDouble(b) / (Convert.ToDouble(b + c + d))) + " %");
            listBox1.Items.Add("Percentual dos de antes de 1990:: " + (100 * Convert.ToDouble(c) / (Convert.ToDouble(b + c + d))) + " %");
            listBox1.Items.Add("Percentual de outros anos::" + (100 * Convert.ToDouble(d) / (Convert.ToDouble(b + c + d))) + " %");

            listBox1.Items.Add("Percentual de carros da FIAT:: " + (100 * Convert.ToDouble(m) / (Convert.ToDouble(m + f + g))) + " %");
            listBox1.Items.Add("Percentual de carros da GM :: " + (100 * Convert.ToDouble(f) / (Convert.ToDouble(m + f + g))) + " %");
            listBox1.Items.Add("Percentual de outros modelos:: " + (100 * Convert.ToDouble(g) / (Convert.ToDouble(m + f + g))) + " %");

            listBox1.Items.Add("Percentual de carros verdes:: " + (100 * Convert.ToDouble(h) / (Convert.ToDouble(h + i + j))) + " %");
            listBox1.Items.Add("Percentual de carros Pretos:: " + (100 * Convert.ToDouble(i) / (Convert.ToDouble(h + i + j))) + " %");
            listBox1.Items.Add("Percentual de outras cores:: " + (100 * Convert.ToDouble(j) / (Convert.ToDouble(h + i + j))) + " %");

            listBox1.Items.Add("Maior idade:: " +maior+ " anos");
            listBox1.Items.Add("Percentual dos motoristas com ");
            listBox1.Items.Add("mais de 35 anos:: " + (100 * Convert.ToDouble(k)) / Convert.ToDouble(l) + " %");
            listBox1.Items.Add("__________________________________");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            A = v2.Text;
            a = Convert.ToInt16(v3.Text);
            i++;
            if (a < 15)
            {
                listBox2.Items.Add("Nome::" + A);
                listBox2.Items.Add("Total a pagar:: R$" + ((a * 300) + 20) + ",00");
                soma=soma+((a * 300) + 20);
            }
            if (a == 15)
            {
                listBox2.Items.Add("Nome::" + A);
                listBox2.Items.Add("Total a pagar:: R$" + ((a * 300) + 14) + ",00");
                soma=soma+((a * 300) + 14);
            }
            if (a > 15)
            {
                listBox2.Items.Add("Nome::" + A);
                listBox2.Items.Add("Total a pagar:: R$" + ((a * 300) + 12) + ",00");
                soma=soma+((a * 300) + 12);
            }
            if (i == 25)
            {
                button2.Enabled = false;
                listBox2.Items.Add("Total ganho pelo hotel:: R$" + soma + ",00");
            }
            v2.Focus();
            v3.Focus();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            A = v4.Text;
            a = Convert.ToInt32(v5.Text);
            b = Convert.ToInt16(v6.Text);
            c = a - (b * 600);
            if (a == 0) { Application.Exit(); }
            if (c <= 10000)
            {
                listBox3.Items.Add("Nome::" + A);
                listBox3.Items.Add("Imposto de Renda:: Isento");
            }
            if (c > 10000 && c<=30000)
            {
                listBox3.Items.Add("Nome::" + A);
                listBox3.Items.Add("Imposto de Renda:: 5% :: R$" +((5*Convert.ToDouble(c))/100) + " reais");
            }
            if (c >30000 && c <= 60000)
            {
                listBox3.Items.Add("Nome::" + A);
                listBox3.Items.Add("Imposto de Renda:: 10% :: R$" + ((10 * Convert.ToDouble(c)) / 100) + " reais");
            }

            if (c > 60000)
            {
                listBox3.Items.Add("Nome::" + A);
                listBox3.Items.Add("Imposto de Renda:: 15% :: R$" + ((15 * Convert.ToDouble(c)) / 100) + " reais");
            }

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt16(v7.Text);
            i++;
            if (radioButton10.Checked == true) { b++; }
            if (radioButton11.Checked == true) { c++; }
            if (radioButton13.Checked == true) { d++; }
            if ((2015-a) < 25) { f++; }
            listBox4.Items.Add("Percentual de homens envolvidos::" + ((100 * Convert.ToDouble(b)) / Convert.ToDouble(b + c)) + " %");
            listBox4.Items.Add("Percentual de motoristas menores de 25 anos::" + ((100 * Convert.ToDouble(f)) / Convert.ToDouble(i)) + " %");
            listBox4.Items.Add("Quantidade de motoristas do interior ::" +d);
            listBox4.Items.Add("_____________________________________________________");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt16(v8.Text);
            listBox5.Items.Add("Antecessores::" + (a - 1) + ", " + (a - 2) + ", " + (a - 3));
            listBox5.Items.Add("Sucessores::" + (a + 1) + ", " + (a + 2) + ", " + (a + 3));
            listBox5.Items.Add("_________________________________________");
            if (a == -1) { Application.Exit(); }
        } 
    }
}
