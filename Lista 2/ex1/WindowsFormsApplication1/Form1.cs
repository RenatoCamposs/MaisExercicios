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

        private void button1_Click(object sender, EventArgs e)
        {
            double A, B, C, D, E;
            A = Convert.ToDouble(textBox1.Text);
            B = Convert.ToDouble(textBox2.Text);
            C = Convert.ToDouble(textBox3.Text);
            D = Convert.ToDouble(textBox4.Text);
            E = (A + B + C + D) / 4;

            if(E>= 8.5){
                label5.Text = "APROVADO";
            }

            if(E<8.5 && E>6){
                label5.Text = "EXAME";
            }

            if(E<=6){
                label5.Text = "RETIDO";
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
