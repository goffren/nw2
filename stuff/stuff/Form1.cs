using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stuff
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        List<Point> points = new List<Point>();
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            points.Add(new Point(e.X, e.Y));
            dataGridView1.Rows.Add(e.X, e.Y);

            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph = Graphics.FromImage(pictureBox1.Image);

            Pen maroonPen = new Pen(Brushes.Maroon);
            Pen pen = new Pen(Color.Brown, 1);
            maroonPen.Width = 4;

            Point[] array_points = points.ToArray();
            for (int i = 0; i < array_points.Length; i++)
            {
                graph.DrawEllipse(maroonPen, array_points[i].X - 2, array_points[i].Y - 2, 4, 4);
                if(i != 0)
                {
                    graph.DrawLine(pen, array_points[i].X, array_points[i].Y, array_points[i - 1].X, array_points[i - 1].Y);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph = Graphics.FromImage(pictureBox1.Image);

            Pen maroonPen = new Pen(Brushes.Maroon);
            Pen pen = new Pen(Color.Brown, 1);
            maroonPen.Width = 4;

            Point[] array_points = points.ToArray();
            for (int i = 0; i < array_points.Length; i++)
            {
                graph.DrawEllipse(maroonPen, array_points[i].X - 2, array_points[i].Y - 2, 4, 4);
                if (i != 0)
                {
                    graph.DrawLine(pen, array_points[i].X, array_points[i].Y, array_points[i - 1].X, array_points[i - 1].Y);
                }
            }
            graph.DrawLine(pen, array_points[0].X, array_points[0].Y, array_points[array_points.Length - 1].X, array_points[array_points.Length - 1].Y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            points.Clear();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            
            dataGridView1.Rows.Clear();
        }
    }
}
