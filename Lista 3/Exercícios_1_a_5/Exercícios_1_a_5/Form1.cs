using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercícios_1_a_5
{
    public partial class Form1 : Form
    {
        int i,a,b,c,soma;
        double s, t, u, v, x, y, z,SOMA=0;
        double pequi = 0, trena = 0, mumbo = 0, bonco = 0, nanco = 0, branco = 0, nulo = 0; 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(v1.Text);
             a = 0;
             b = 1;            
            for(i=1;i<=x;i++){              
                c= a + b ;
                b = a;
                a = c ;
                listBox1.Items.Add(c);
                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (i = 0; i <= 100; i++)
            {
                soma = soma + i;
            }
            label4.Text = Convert.ToString(soma+" !");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt16(v2.Text);
            for (i = a; i <= a+99; i++)
            {
                soma = soma + i;
            }
            label7.Text = Convert.ToString("Soma ::" +soma);
            label8.Text = Convert.ToString("Média ::" + Convert.ToInt16(soma)/100);
        }

        private void button4_Click(object sender, EventArgs e)
        {


            if (radioButton1.Checked == true) { pequi = pequi + 1; }
            if (radioButton2.Checked == true) { trena = trena + 1; }
            if (radioButton3.Checked == true) { nanco = nanco + 1; }
            if (radioButton4.Checked == true) { mumbo = mumbo + 1; }
            if (radioButton5.Checked == true) { bonco = bonco + 1; }
            if (radioButton6.Checked == true) { branco = branco + 1; }
            if (radioButton7.Checked == true)
            {
                SOMA = pequi + trena + mumbo + bonco + nanco + branco;
                s = (pequi * 100) / SOMA;
                t = (trena * 100) / SOMA;
                u = (nanco * 100) / SOMA;
                v = (mumbo * 100) / SOMA;
                x = (bonco * 100) / SOMA;
                y = (branco * 100) / SOMA;
                z = (nulo * 100) / SOMA;
                listBox2.Items.Add("Quantidade de votos::" + SOMA);
                listBox2.Items.Add("Perceitual de votos ::");
                listBox2.Items.Add("Pequi    " + s + " %");
                listBox2.Items.Add("Trena    " + t + " %");
                listBox2.Items.Add("Nanco    " + u + " %");
                listBox2.Items.Add("Mumbo    " + v + " %");
                listBox2.Items.Add("Bonco    " + x + " %");
                listBox2.Items.Add("branco   " + y + " %");
                listBox2.Items.Add("nulo     " + z + " %");

                listBox2.Items.Add("_____________________________________");

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (i = 0; i <= 100; i=+2)
            {
                soma = soma + i;
            }
            textBox1.Text = Convert.ToString(soma + " !");
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Ex4_Click(object sender, EventArgs e)
        {

        }              
       
    }
}
