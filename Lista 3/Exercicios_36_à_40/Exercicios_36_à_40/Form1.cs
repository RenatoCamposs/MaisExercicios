using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios_36_à_40
{
    public partial class Form1 : Form
    {
        int a,b,soma=0,somab=0,i;
        double m,s=0,v,x,y,z,r,t,u;
        public Form1()
        {
            i = 0;
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {           
            v = Convert.ToDouble(v3.Text);
            x = Convert.ToDouble(v4.Text);
            y = Convert.ToDouble(v5.Text);
            z = Convert.ToDouble(v6.Text);
            s = v + x + y + z + z;
            m = s / 5;            
                listBox1.Items.Add("RGM :: " +v1.Text);
                listBox1.Items.Add("Nome :: " +v2.Text);
                listBox1.Items.Add("1º nota :: " +v);
                listBox1.Items.Add("2º nota :: " +x);
                listBox1.Items.Add("3º nota :: " +y);
                listBox1.Items.Add("4º nota:: " +z);
                listBox1.Items.Add("Média das notas :: " +m);
                if (m < 5)
                {
                    listBox1.Items.Add("Situação do aluno :: I");
                }
                if (m >= 5 && m<7.5)
                {
                    listBox1.Items.Add("Situação do aluno :: B");
                }
                if (m>=7.5)
                {
                    listBox1.Items.Add("Situação do aluno :: MB");
                }
                listBox1.Items.Add("____________________________________________");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label9.Text = Convert.ToString("Olá, Sr " + v7.Text);
            }
            if (radioButton2.Checked == true)
            {
                label9.Text = Convert.ToString("Olá, Sra " + v7.Text);
            }
            if (radioButton3.Checked == true)
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            x=Convert.ToDouble(v8.Text);
            y=Convert.ToDouble(v9.Text);
            if (radioButton4.Checked == true)
            {
                label13.Text = Convert.ToString(y + "Dólar(es) são :: " + (y * x)+" Real(is)");
            }
            if (radioButton5.Checked == true)
            {
                label13.Text = Convert.ToString(y + "Real(is) são :: " + (y / x)+"Dólar(es)");
            }
            if (radioButton6.Checked == true)
            {
                label13.Text = Convert.ToString(y + "Euro(s) são :: " + (y * x)+" Real(is)");
            }
            if (radioButton7.Checked == true)
            {
                label13.Text = Convert.ToString(y + "Real(is) são :: " + (y / x)+"Euro(s)");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (i = 0; i <= 200; i += 2)
            {
                a++;
                soma = soma + i;
            }
            for (i = 201; i <= 300; i += 2)
            {
                b++;
                somab = somab + i;
            }
        
            listBox2.Items.Add("Soma dos pares entre 0 e 200 ::");
            listBox2.Items.Add(soma);
            listBox2.Items.Add("Média dos pares entre 0 e 200 ::");
            listBox2.Items.Add((Convert.ToDouble(soma) / Convert.ToDouble(a)));
            listBox2.Items.Add("Soma dos impares entre 200 e 300 ::");
            listBox2.Items.Add(somab);
            listBox2.Items.Add("Média dos impares entre 200 e 300 ::");
            listBox2.Items.Add((Convert.ToDouble(somab) / Convert.ToDouble(b)));
            listBox2.Items.Add("Soma geral ::");
            listBox2.Items.Add((soma+somab));
            listBox2.Items.Add("Média geral ::");
            listBox2.Items.Add((Convert.ToDouble(soma+somab) / Convert.ToDouble(a+b)));
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            i++;
            a = Convert.ToInt16(v10.Text);
            if (a == 1 || a == 2 || a == 3)
            {
                m++;
                textBox1.Text = Convert.ToString(m);                
            }
            if (a == 4 || a == 5)
            {
                r++;
                textBox4.Text = Convert.ToString(r);                
            }
            if (a == 6)
            {
                t++;
                textBox6.Text = Convert.ToString(t);                
            }
            if (a == 7 || a == 8 || a == 9)
            {
                x++;
                textBox7.Text = Convert.ToString(x);               
            }
            if (a == 10 || a == 11 || a == 12)
            {
                v++;
                textBox8.Text = Convert.ToString(v);                
            }
            if (a == 13 || a == 14)
            {
                y++;
                textBox16.Text = Convert.ToString(y);                
            }
            if (a>=15 && a<=20)
            {
                z++;
                textBox9.Text = Convert.ToString(z);               
            }
            if (a >= 21 && a <= 35)
            {
                s++;
                textBox10.Text = Convert.ToString(s);               
            }
            if(a<-1 || a==0 || a>35)
            {
                u++;
                textBox18.Text = Convert.ToString(u);                
            }
            if (a == -1) { Application.Exit(); }
            textBox2.Text = Convert.ToString((100 * m) / Convert.ToDouble(i) + " %");
            textBox3.Text = Convert.ToString((100 * r) / Convert.ToDouble(i) + " %");
            textBox5.Text = Convert.ToString((100 * t) / Convert.ToDouble(i) + " %");
            textBox12.Text = Convert.ToString((100 * x) / Convert.ToDouble(i) + " %");
            textBox13.Text = Convert.ToString((100 * v) / Convert.ToDouble(i) + " %");
            textBox11.Text = Convert.ToString((100 * y) / Convert.ToDouble(i) + " %");
            textBox14.Text = Convert.ToString((100 * z) / Convert.ToDouble(i) + " %");
            textBox15.Text = Convert.ToString((100 * s) / Convert.ToDouble(i) + " %");
            textBox17.Text = Convert.ToString((100 * u) / Convert.ToDouble(i) + " %");
        }
    }
}
