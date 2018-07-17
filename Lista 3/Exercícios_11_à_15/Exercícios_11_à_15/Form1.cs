using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercícios_11_à_15
{
    public partial class Form1 : Form
    {
        int a,b,c,i,d,maior,menor,soma,y;
        
        double x,z;
        public Form1()
        {
            InitializeComponent();
            a = 0;
            soma = 0;
            maior = -3600;
            menor = 3600;
            y = 0;
            i = 0;
            b = 0;
            c = 0;
            d = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Fahrenheit___Celsius");
            for (i = 50; i <= 200; i++)
            {
                x = (Convert.ToDouble(i) - 32) * 0.5555555555555556;
                listBox1.Items.Add(i + "                  " + x);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                if (radioButton1.Checked == true) { a++; }
                else if (radioButton2.Checked == true) { b++; }                
            i=Convert.ToInt16(v1.Text);
            if (radioButton1.Checked == true && radioButton3.Checked == true && radioButton6.Checked == true && i >= 18 && i <= 35)
            {
                c++;
            }
            if (i > maior ) { maior = i; }
            if (i < menor ) { menor = i; }
            listBox2.Items.Add("Maior idade :: "+maior);
            listBox2.Items.Add("Menor idade :: "+menor);
            x = (100 * Convert.ToDouble(c)) / (a + b);
            listBox2.Items.Add("Percentual de loiras dos olhos verdes" );
            listBox2.Items.Add(" com idade entre 18 e 35 anos::");
            listBox2.Items.Add(x+" %");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            i++;
            c = Convert.ToInt16(v3.Text); 
            d = Convert.ToInt16(v4.Text);
            if (radioButton9.Checked == true) { a++; }
            else if (radioButton10.Checked == true) { b++; }
            if (radioButton11.Checked == true) { button3.Enabled=false; }
            if ((d - c) <= 2) { y++; }
            listBox3.Items.Add("Percentual de crianças do sexo masculino mortas ::");
            x=(100*Convert.ToDouble(b))/i;
            listBox3.Items.Add(x + " %");
            listBox3.Items.Add("Percentual de crianças que viveram");
            listBox3.Items.Add(" apenas 2 ou menos anos ::");
            z = (100 * Convert.ToDouble(y)) / i;
            listBox3.Items.Add(z + " %");
            listBox3.Items.Add("Quantidade de mortes ::" +i);
            listBox3.Items.Add("Quantidade de mortes do sexo masculino ::"+b);
            listBox3.Items.Add("Quantidade de nortes do sexo feminino ::"+a);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt16(v5.Text);
            soma = soma + a;
            y++;
            if (radioButton12.Checked == true) { b++; }
            if (radioButton14.Checked == true) { c++; }
            if (radioButton16.Checked == true) { d++; }
            else if (radioButton12.Checked == true && radioButton14.Checked == true && radioButton16.Checked == true) { i++; }
            if (a > maior) { maior = a; }
            if (a < menor) { menor = a; }
            if (y == 100)
            {
                button4.Enabled = false;
                listBox4.Items.Add("Quantidade respostas ótimas ::" + b);
                listBox4.Items.Add("Quantidade respostas C ::" + c);
                listBox4.Items.Add("Percentual de respostas péssimas ::");
                x = (100 * Convert.ToDouble(d)) / (b + c + d + i);
                listBox4.Items.Add(x + " %");
                listBox4.Items.Add("Maior idade ::" + maior);
                listBox4.Items.Add("Menor idade ::" + menor);
                z = Convert.ToDouble(soma) / (b + c + d + i);
                listBox4.Items.Add("Média das idades ::" + z);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (i = 1; i <= 500; i += 2)
            {
                soma = soma + i;
                if (i == 499)
                {
                    listBox5.Items.Add("499 = " + soma);
                }
                else
                {
                    listBox5.Items.Add(i);
                    listBox5.Items.Add("+");
                }
            }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

    }
}
