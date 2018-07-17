using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double tempoGasto, velocidadeMedia, distancia, litrosGastos;
            tempoGasto = Convert.ToInt16(textBox1.Text);
            velocidadeMedia = Convert.ToInt16(textBox2.Text);
            distancia = tempoGasto * velocidadeMedia;
            litrosGastos = distancia / 12;
            label6.Text = Convert.ToString(litrosGastos + " litros");
        }
    }
}
