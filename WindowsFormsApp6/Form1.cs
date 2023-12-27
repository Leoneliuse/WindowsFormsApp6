using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n = double.Parse(textBox1.Text);
            double a = double.Parse(textBox2.Text);
            double z,x = 1,c = 0,y = 0,t = 1,j=0;
            z = Math.Pow(a, n);
            for (double i = 1; i < (n - 1); i++)
            {
                x *= a * (a + i);
            }
            for (int i = 0; i < n; i++)
            {
                c += 1 / (a + i);
            }
            for (int i = 0; i < n; i++)
            {
                y += 1 / Math.Pow(Math.Pow(a,n),i);
                
            }
            for (double i = 1; i <= n; i++)
            {
                t *= a * (a - (i * n));
            }
            textBox4.Text += " a)= " + z.ToString() + Environment.NewLine;
            textBox4.Text += " б)= " + x.ToString() + Environment.NewLine;
            textBox4.Text += " в)= " + c.ToString() + Environment.NewLine;
            textBox4.Text += " г)= " + y.ToString() + Environment.NewLine;
            textBox4.Text += " д)= " + t.ToString() + Environment.NewLine;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
