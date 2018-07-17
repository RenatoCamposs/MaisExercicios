using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exe7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a;
            a = Convert.ToSingle(textBox1.Text);
            label2.Text = ((a-3)+"-"+(a-2)+"-"+(a-1)+"<"+(a)+">"+(a+1)+"-"+(a+2)+"-"+(a+3)+"-"+(a+4)+"-"+(a+5));
        }
    }
}
