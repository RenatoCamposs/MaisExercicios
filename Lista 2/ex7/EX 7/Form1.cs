using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_7
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
            int B, C, D, E, F, G, H, I;
            A = Convert.ToInt16(textBox1.Text);
            B = A-5;
            C = A-4;
            D = A-3;
            E = A-2;
            F = A-1;
            G = A+1;
            H = A+2;
            I = A+3;

            label1.Text = Convert.ToString(B + "-" + C + "-" + D + "-" + E + "-" + F+"<<"+A+">>" + G + "-" + H + "-" + I);
        }
    }
}
