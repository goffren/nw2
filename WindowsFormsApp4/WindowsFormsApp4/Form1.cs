using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph = Graphics.FromImage(pictureBox1.Image);

            Pen maroonPen = new Pen(Brushes.Maroon);
            maroonPen.Width = 4;
            graph.DrawLine(maroonPen, 10, 20, 3200 , 200);
        }

        int x_start = 0;
        int y_start = 0;
        bool click = false;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (click == false)
            {
                x_start = e.X;
                y_start = e.Y;
                pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics graph = Graphics.FromImage(pictureBox1.Image);
                graph.FillEllipse(Brushes.Maroon, x_start, y_start, 6, 6);
                click = true;
            }
            else
            {
                click = false;
                pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics graph = Graphics.FromImage(pictureBox1.Image);

                Pen maroonPen = new Pen(Brushes.Maroon);
                maroonPen.Width = 4;
                
                graph.DrawLine(maroonPen, x_start, y_start, e.X, e.Y);
                
            }
        }
    }
}
