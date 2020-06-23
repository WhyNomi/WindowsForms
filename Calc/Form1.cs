using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        double a;// first num   
        double b;//sec num
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if(a == 0)
            {
               a = Convert.ToDouble(textBox1.Text);
            }
            else
            {
                b = Convert.ToDouble(textBox1.Text);
                a += b;
                b = 0;
                textBox1.Text = a.ToString();
            }
        }
    }
}
