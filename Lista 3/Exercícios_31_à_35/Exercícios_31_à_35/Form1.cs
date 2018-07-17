using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercícios_31_à_35
{
    public partial class Form1 : Form
    {
        int a,i=0, m = -3600, ma = -3600, mai = -3600, maio = -3600, maior = -3600, maiora = -3600, maiorb = -3600, maiorc = -3600, maiord = -3600, maiore = -3600;
        int menor = 3600,b,c,d,soma=0,somab=0;
        public Form1()
        {

            InitializeComponent();
            b = 0;
            c = 0;
            d = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            a = Convert.ToInt16(v1.Text);
            if (i <= 10)
            {
                if (a > maiore) { mai = ma; ma = m; m = maio; maio = maior; maior = maiora; maiora = maiorb; maiorb = maiorc; maiorc = maiord; maiord = maiore; maiore = a; }
                if (a > maiord && a < maiore) { mai = ma; ma = m; m = maio; maio = maior; maior = maiora; maiora = maiorb; maiorb = maiorc; maiorc = maiord; maiord = a; }
                if (a > maiorc && a < maiord) { mai = ma; ma = m; m = maio; maio = maior; maior = maiora; maiora = maiorb; maiorb = maiorc; maiorc = a; }
                if (a > maiorb && a < maiorc) { mai = ma; ma = m; m = maio; maio = maior; maior = maiora; maiora = maiorb; maiorb = a; }
                if (a > maiora && a < maiorb) { mai = ma; ma = m; m = maio; maio = maior; maior = maiora; maiora = a; }
                if (a > maior && a < maiora) { mai = ma; ma = m; m = maio; maio = maior; maior = a; }
                if (a > maio && a < maior) { mai = ma; ma = m; m = maio; maio = a; }
                if (a > m && a < maio) { mai = ma; ma = m; m = a; }
                if (a > ma && a < m) { mai = ma; ma = a; }
                if (a > mai && a < ma) { mai = a; }
                listBox1.Items.Add(a);
            }
            if (i >= 10)                
            {
                if (radioButton1.Checked == true)
                {
                    textBox2.Text = Convert.ToString(mai + ", " + ma + ", " + m + ", " + maio + ", " + maior + ", " + maiora + ", " + maiorb + ", " + maiorc + ", " + maiord + ", " + maiore);
                }
                if (radioButton2.Checked == true)
                {
                    textBox2.Text = Convert.ToString(maiore + ", " + maiord + ", " + maiorc + ", " + maiorb + ", " + maiora + ", " + maior + ", " + maio + ", " + m + ", " + ma + ", " + mai);
                }
                }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            i++;
            a = Convert.ToInt16(v2.Text);
            b = Convert.ToInt16(v3.Text);
            if (b > maior) { maior = b; c = a; }
            if (b < menor) { menor = b; d = a; }
            listBox2.Items.Add("Código do boi:: "+a);
            listBox2.Items.Add("Peso do boi:: "+b);
            if (i == 25)
            {
                button2.Enabled = false;
                textBox4.Text = Convert.ToString(c);
                textBox5.Text = Convert.ToString(d);
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt16(v4.Text);
            
            if (a % 2 == 1)
            {
                i++;
                soma = soma + a;
            }
            if (a % 2 == 0)
            {
                label11.Text = "Valor inválido!! Digite novamente.";
                somab = somab + a;
            }
            if (i == 20)
            {
                
Executar.Enabled = false;
                listBox3.Items.Add("Soma de todos os valores:: " + (soma + somab));
                listBox3.Items.Add("Soma dos valores impares:: " + (soma));
                listBox3.Items.Add("Média dos valores impares:: " + (Convert.ToDouble(soma) / 20));
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            a = Convert.ToInt16(v5.Text);
            if (a >= 0 && a <= 25)
            {
                textBox6.Text = Convert.ToString((soma=soma+1));
            }
            if (a >= 26 && a <= 50)
            {
                textBox7.Text = Convert.ToString((i=i+1));
            }
            if (a >= 51 && a <= 75)
            {
                textBox1.Text = Convert.ToString((b=b+1));
            }
            if (a >= 76 && a <= 100)
            {
                textBox8.Text = Convert.ToString((c=c+1));
            }
            if (a < 0 || a > 100)
            {
                textBox3.Text = Convert.ToString((d=d+1));
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
          
            a = Convert.ToInt16(v6.Text);         
            listBox4.Items.Add("Número:: "+a);
            listBox4.Items.Add("Quadrado:: "+(a*a));
            listBox4.Items.Add("Cubo:: " + (a * a * a));
            listBox4.Items.Add("Raiz:: " + (Math.Sqrt(Convert.ToDouble(a))));
            listBox4.Items.Add("____________________________________________________");
           
        }
    }
}
