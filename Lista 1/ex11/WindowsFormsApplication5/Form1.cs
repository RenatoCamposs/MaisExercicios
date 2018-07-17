using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3, nota4, media;
            nota1 = Convert.ToDouble(textBox1.Text);
            nota2 = Convert.ToDouble(textBox2.Text);
            nota3 = Convert.ToDouble(textBox3.Text);
            nota4 = Convert.ToDouble(textBox4.Text); 
            media = (nota1 + nota2 + nota3 + nota4) / 4;
            label3.Text = Convert.ToString(media + " é a média!");
        }
    }
}
