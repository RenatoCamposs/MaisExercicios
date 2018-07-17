using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int A;
            A = Convert.ToInt16(textBox1.Text);

            if(A == 1){
                label1.Text = "JANEIRO";
            }

            if (A == 2)
            {
                label1.Text = "FEVEREIRO";
            }

            if (A == 3)
            {
                label1.Text = "MARÇO";
            }

            if (A == 4)
            {
                label1.Text = "ABRIL";
            }

            if (A == 5)
            {
                label1.Text = "MAIO";
            }

            if (A == 6)
            {
                label1.Text = "JUNHO";
            }

            if (A == 7)
            {
                label1.Text = "JULHO";
            }

            if (A == 8)
            {
                label1.Text = "AGOSTO";
            }

            if (A == 9)
            {
                label1.Text = "SETEMBRO";
            }

            if (A == 10)
            {
                label1.Text = "OUTUBRO";
            }

            if (A == 11)
            {
                label1.Text = "NOVEMBRO";
            }

            if (A == 12)
            {
                label1.Text = "DEZEMBRO";
            }

            if (A>12 || A<1)
            {
                label1.Text = "ERRO";
            }
        }
    }
}
