using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace площадь_и_периметр_трапеции
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

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);
            int d = Convert.ToInt32(textBox4.Text);
            int h = Convert.ToInt32(textBox5.Text);
            int k = a + b + c + d;
            int v = a + b / 2 * h;
            label2.Text = g.ToString();
            label5.Text = v.ToString();
            int d1 = (b - a >= 0) ? (b - a) / 2 : 0;
            int d2 = (a - b >= 0) ? (a - b) / 2 : 0;
            g.DrawLine(p, X + d1, Y, X + a + d1, Y);
            g.DrawLine(p, X + d1, Y, X + d2, Y + h);
            g.DrawLine(p, X + d2, Y + h, X + b + d2, Y + h);
            g.DrawLine(p, X + b + d2, Y + h, X + a + d1, Y);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
         
        }
    }
}
