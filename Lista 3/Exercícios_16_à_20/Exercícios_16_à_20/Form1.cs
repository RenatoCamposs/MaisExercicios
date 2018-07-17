using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercícios_16_à_20
{
    public partial class Form1 : Form
    {
        int i,b,a,soma,p,fato,maior,menor;
        public Form1()
        {
            InitializeComponent();
            i = 0;
            soma = 0;
            p = 1 ;
            fato = 1 ;
            maior = -3600;
            menor = 3600;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (i = 0; i <= 1000; i += 2)
            {
                soma = soma + i;
                if (i == 1000)
                {
                    listBox1.Items.Add("1000 = " + soma);
                    //500 sem o 0 e 501 com o 0
                    listBox1.Items.Add("Média = " + Convert.ToDouble(soma)/501);

                }
                else
                {
                    listBox1.Items.Add(i);
                    listBox1.Items.Add("+");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            b = Convert.ToInt16(v1.Text);
            a = Convert.ToInt16(v2.Text);
            for (i = 1; i <= a; i++)
            {
                p = p * b;
                textBox2.Text = Convert.ToString(b + " ^ " + a + " = " + p);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (i = 1; i <= 40; i += 2)
            {
                for (a = 1; a <= i; a++)
                {
                    fato = fato * a;
                }
                listBox2.Items.Add(i + " ! = " + fato);
                fato = 1;
                a = 1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt16(v3.Text);            
                b++;
                if (a > maior && a > 0) { maior = a; }
                if (a < menor && a > 0) { menor = a; }
            listBox3.Items.Add(a);
            if (a < 0)
            {
                listBox3.Items.Add("Maior valor :: " + maior);
                listBox3.Items.Add("Menor valor :: " + menor);
                listBox3.Items.Add("Quantidade dos valores ");
                listBox3.Items.Add("digitados :: " + (Convert.ToInt16(b)-1));
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt16(v4.Text);
            b = Convert.ToInt16(v5.Text);
            if (a < b)
            {
                label11.Text = Convert.ToString(a + " ! ");
                label12.Text = Convert.ToString(b + " ! ");
            }
            else
            {
                label11.Text = ("Digite o segundo valor novamente");
            }
                }
    }
}
