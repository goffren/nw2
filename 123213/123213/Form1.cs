using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _123213
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Dictionary<string, string> op = new Dictionary<string, string>();
            int index;
            ListBox.SelectedIndexCollection collection = listBox1.SelectedIndices;

            if (collection.Count == 0)
                index = listBox1.Items.Count;
            else index = collection[0];

            listBox1.Items.Insert(index, textBox1.Text);
        }
    }
}
