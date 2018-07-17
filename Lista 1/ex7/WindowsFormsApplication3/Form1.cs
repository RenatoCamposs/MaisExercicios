using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cálculo volume da circunferência: V = 4/3. pi .R²
            // Cálculo Área: PI * Raio².
            double area, raio, raioQuadrado, pi,volume;
            pi = 3.141592653589793238462643383279502884;
            raio = Convert.ToInt16(textBox2.Text);
            raioQuadrado = raio * raio;
            area = (pi * raioQuadrado);
            volume = (4 / 3) * area;
            label4.Text = Convert.ToString(volume);
        }
    }
}
