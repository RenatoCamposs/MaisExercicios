using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "M")
            {
                label6.Text = "Bom Dia!";
            }
            else if (textBox1.Text == "V")
            {
                label6.Text = "Boa Tarde!";
            }
            else if (textBox1.Text == "N")
            {
                label6.Text = "Boa Noite!";
            }
            else
            {
                label6.Text = "Valor Inválido!";
            }
        }
    }
}
