using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        private Color color;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
       
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (radioButton1.Checked == true){
                e.Graphics.DrawLine(
            new Pen(color),
            new Point(0, 0),
            new Point(pictureBox1.Size.Width, pictureBox1.Size.Height));
            }
            if (radioButton2.Checked == true)
            {
                e.Graphics.DrawEllipse(
                new Pen(color),
                0, 0, pictureBox1.Size.Width, pictureBox1.Size.Height);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.Black;
            Invalidate();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.Red;
            Invalidate();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.Green;
            Invalidate();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.Blue;
            Invalidate();
        }
    }
}
