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
                    int d1, mult1, mult2, mult3, mult4, mult5, mult6, mult7, mult8, mult9, mult10;

                    d1 = Convert.ToInt16(txtOperador.Text);

                        mult1 = d1 * 1;
                        mult2 = d1 * 2;
                        mult3 = d1 * 3;
                        mult4 = d1 * 4;
                        mult5 = d1 * 5;
                        mult6 = d1 * 6;
                        mult7 = d1 * 7;
                        mult8 = d1 * 8;
                        mult9 = d1 * 9;
                        mult10 = d1 * 10;

                        label11.Text = d1 + " * 1 = " + Convert.ToString(mult1);
                        label2.Text = d1 + " * 2 = " + Convert.ToString(mult2);
                        label3.Text = d1 + " * 3 = " + Convert.ToString(mult3);
                        label4.Text = d1 + " * 4 = " + Convert.ToString(mult4);
                        label5.Text = d1 + " * 5 = " + Convert.ToString(mult5);
                        label6.Text = d1 + " * 6 = " + Convert.ToString(mult6);
                        label7.Text = d1 + " * 7 = " + Convert.ToString(mult7);
                        label8.Text = d1 + " * 8 = " + Convert.ToString(mult8);
                        label9.Text = d1 + " * 9 = " + Convert.ToString(mult9);
                        label10.Text = d1 + " * 10 = " + Convert.ToString(mult10);


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
