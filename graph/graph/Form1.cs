using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(filename, textBox2.Text);
            MessageBox.Show("Файл сохранен");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку
            string fileText = System.IO.File.ReadAllText(filename);
            textBox2.Text = fileText;
            MessageBox.Show("Файл открыт");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox2.Text;
            string[] subs = str.Split(',', '\n');
            int[] num = new int[subs.Length];

            int count_vert = Convert.ToInt32(textBox2.Text);

            for (int i = 0; i < subs.Length; i++)
            {
                num[i] = Convert.ToInt32(subs[i]);
                if (num[i] > count_vert)
                {
                    MessageBox.Show("В ребрах большн вершин, чем в графе");
                    break;
                }
            }
            Point[] points = new Point[count_vert];

            for (int i = 0; i < count_vert; i++)
            {
                Random rdm = new Random();
                int a = rdm.Next(50, pictureBox1.Width - 50);
                int b = rdm.Next(50, pictureBox1.Height - 50);
                while (a >= points[i - 1].X - 50 || a <= points[i - 1].X - 50)
                {
                    a = rdm.Next(50, pictureBox1.Width - 50);
                }
                while (b >= points[i - 1].X - 50 || b <= points[i - 1].X - 50)
                {
                    b = rdm.Next(50, pictureBox1.Height - 50);
                }
                points[i] = new Point(a, b);
            }
        }
    }
}
