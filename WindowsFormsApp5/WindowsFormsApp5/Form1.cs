using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Width = this.Width;
            pictureBox1.Height = this.Height - 90;
        }
        int x_start = 0;
        int y_start = 0;
        bool click = false;
        bool uwu = false;
        private void Form1_Resize(object sender, EventArgs e)
        {
            pictureBox1.Width = this.Width;
            pictureBox1.Height = this.Height - 90;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                label1.Text = $"X: {e.X}; Y: {e.Y}";

                pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics graph = Graphics.FromImage(pictureBox1.Image);
                Pen maroonPen = new Pen(Brushes.Maroon);
                maroonPen.Width = 4;
                if (uwu) graph.DrawLine(maroonPen, x_start, y_start, e.X, e.Y);
                

            }
        }
        

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (click == false)
            {
                x_start = e.X;
                y_start = e.Y;
                click = true;
                uwu = true;
            }
            else
            {
                click = false;
                uwu = false;
                pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics graph = Graphics.FromImage(pictureBox1.Image);

                Pen maroonPen = new Pen(Brushes.Maroon);
                maroonPen.Width = 4;
                graph.DrawLine(maroonPen, x_start, y_start, e.X, e.Y);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
    }
}
