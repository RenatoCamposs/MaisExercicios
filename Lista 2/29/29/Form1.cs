using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _29
{
    public partial class Form1 : Form
    {
        int i = 1, p = 0, im = 0;
        float a, b, c, d, f, g, h, j, k, l, pares = 0, impares = 0, media = 0, maior = 0, menor = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            if (i == 1){
                a = Convert.ToSingle(textBox1.Text);
                menor = a;
                maior = a;
                media += a;
                if (a % 2 == 1){
                    impares += a;
                    im++;
                }
                if (a % 2 == 0){
                    pares += a;
                    p++;
                }
            }

            if (i == 2)
            {
                b = Convert.ToSingle(textBox1.Text);
                media += b;
                if (b % 2 == 1)
                {
                    impares += b;
                    im++;
                }
                if (b % 2 == 0)
                {
                    pares += b;
                    p++;
                }
                if (b > maior)
                {
                    maior = b;
                }
                if (b < menor)
                {
                    menor = b;
                }
            }


            if (i == 3)
            {
                c = Convert.ToSingle(textBox1.Text);
                media += c;
                if (c % 2 == 1)
                {
                    impares += c;
                    im++;
                }
                if (c % 2 == 0)
                {
                    pares += c;
                    p++;
                }
                if (c > maior)
                {
                    maior = c;
                }
                if (c < menor)
                {
                    menor = c;
                }
            }

                if (i == 4)
                {
                    d = Convert.ToSingle(textBox1.Text);
                    media += d;
                    if (d % 2 == 1)
                    {
                        impares += d;
                        im++;
                    }
                    if (d % 2 == 0)
                    {
                        pares += d;
                        p++;
                    }
                    if (d > maior)
                    {
                        maior = d;
                    }
                    if (d < menor)
                    {
                        menor = d;
                    }
                }


                if (i == 5)
                {
                    f = Convert.ToSingle(textBox1.Text);
                    media += f;
                    if (f % 2 == 1)
                    {
                        impares += f;
                        im++;
                    }
                    if (f % 2 == 0)
                    {
                        pares += f;
                        p++;
                    }
                    if (f > maior)
                    {
                        maior = f;
                    }
                    if (f < menor)
                    {
                        menor = f;
                    }
                }


                if (i == 6)
                {
                    g = Convert.ToSingle(textBox1.Text);
                    media += g;
                    if (g % 2 == 1)
                    {
                        impares += g;
                        im++;
                    }
                    if (g % 2 == 0)
                    {
                        pares += g;
                        p++;
                    }
                    if (g > maior)
                    {
                        maior = g;
                    }
                    if (g < menor)
                    {
                        menor = g;
                    }
                }


                if (i == 7)
                {
                    h = Convert.ToSingle(textBox1.Text);
                    media += h;
                    if (h % 2 == 1)
                    {
                        impares += h;
                        im++;
                    }
                    if (h % 2 == 0)
                    {
                        pares += h;
                        p++;
                    }
                    if (h > maior)
                    {
                        maior = h;
                    }
                    if (h < menor)
                    {
                        menor = h;
                    }
                }


                if (i == 8)
                {
                    j = Convert.ToSingle(textBox1.Text);
                    media += j;
                    if (j % 2 == 1)
                    {
                        impares += j;
                        im++;
                    }
                    if (j % 2 == 0)
                    {
                        pares += j;
                        p++;
                    }
                    if (j > maior)
                    {
                        maior = j;
                    }
                    if (j < menor)
                    {
                        menor = j;
                    }
                }


                if (i == 9)
                {
                    k = Convert.ToSingle(textBox1.Text);
                    media += k;
                    if (k % 2 == 1)
                    {
                        impares += k;
                        im++;
                    }
                    if (k % 2 == 0)
                    {
                        pares += k;
                        p++;
                    }
                    if (k > maior)
                    {
                        maior = k;
                    }
                    if (k < menor)
                    {
                        menor = k;
                    }
                }


                if (i == 10)
                {
                    l = Convert.ToSingle(textBox1.Text);
                    media += l;
                    button1.Enabled = false;
                    if (l % 2 == 1)
                    {
                        impares += l;
                        im++;
                    }
                    if (l % 2 == 0)
                    {
                        pares += l;
                        p++;
                    }
                    if (l > maior)
                    {
                        maior = l;
                    }
                    if (l < menor)
                    {
                        menor = l;
                    }
                    label2.Text += Convert.ToString(maior);
                    label3.Text += Convert.ToString(menor);
                    label4.Text += Convert.ToString(pares / p);
                    label5.Text += Convert.ToString(impares / im);
                    label6.Text += Convert.ToString(media / 10);
                }
                i++;
            }
           
        }
    }

