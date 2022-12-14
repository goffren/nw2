using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string cross_zero = "X";
        bool game_over = false;

        private void resetButtons()
        {
            button1.Text = string.Empty;
            button2.Text = string.Empty;
            button3.Text = string.Empty;
            button4.Text = string.Empty;
            button5.Text = string.Empty;
            button6.Text = string.Empty;
            button7.Text = string.Empty;
            button8.Text = string.Empty;
            button9.Text = string.Empty;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button1.BackColor = Color.WhiteSmoke;
            button2.BackColor = Color.WhiteSmoke;
            button3.BackColor = Color.WhiteSmoke;
            button4.BackColor = Color.WhiteSmoke;
            button5.BackColor = Color.WhiteSmoke;
            button6.BackColor = Color.WhiteSmoke;
            button7.BackColor = Color.WhiteSmoke;
            button8.BackColor = Color.WhiteSmoke;
            button9.BackColor = Color.WhiteSmoke;
        }

        private void blockButtons()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        private void checkWin()
        {
            if (button1.Text == button2.Text && button2.Text == button3.Text &&
                    button1.Enabled == false && button2.Enabled == false && button3.Enabled == false)
            {
                blockButtons();
                button1.BackColor = Color.Gold;
                button2.BackColor = Color.Gold;
                button3.BackColor = Color.Gold;
                game_over = true;
            }
            else if (button4.Text == button5.Text && button5.Text == button6.Text &&
                    button4.Enabled == false && button5.Enabled == false && button6.Enabled == false)
            {
                blockButtons();
                button4.BackColor = Color.Gold;
                button5.BackColor = Color.Gold;
                button6.BackColor = Color.Gold;
                game_over = true;
            }
            else if (button7.Text == button8.Text && button8.Text == button9.Text &&
                    button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
            {
                blockButtons();
                button7.BackColor = Color.Gold;
                button8.BackColor = Color.Gold;
                button9.BackColor = Color.Gold;
                game_over = true;
            }
            else if (button1.Text == button4.Text && button4.Text == button7.Text &&
                    button1.Enabled == false && button4.Enabled == false && button7.Enabled == false)
            {
                blockButtons();
                button1.BackColor = Color.Gold;
                button4.BackColor = Color.Gold;
                button7.BackColor = Color.Gold;
                game_over = true;
            }
            else if (button2.Text == button5.Text && button5.Text == button8.Text &&
                    button2.Enabled == false && button5.Enabled == false && button8.Enabled == false)
            {
                blockButtons();
                button2.BackColor = Color.Gold;
                button5.BackColor = Color.Gold;
                button8.BackColor = Color.Gold;
                game_over = true;
            }
            else if (button3.Text == button6.Text && button6.Text == button9.Text &&
                    button3.Enabled == false && button6.Enabled == false && button9.Enabled == false)
            {
                blockButtons();
                button3.BackColor = Color.Gold;
                button6.BackColor = Color.Gold;
                button9.BackColor = Color.Gold;
                game_over = true;
            }
            else if (button4.Text == button5.Text && button5.Text == button6.Text &&
                    button4.Enabled == false && button5.Enabled == false && button6.Enabled == false)
            {
                blockButtons();
                button4.BackColor = Color.Gold;
                button5.BackColor = Color.Gold;
                button6.BackColor = Color.Gold;
                game_over = true;
            }
            else if (button7.Text == button8.Text && button8.Text == button9.Text &&
                    button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
            {
                blockButtons();
                button7.BackColor = Color.Gold;
                button8.BackColor = Color.Gold;
                button9.BackColor = Color.Gold;
                game_over = true;
            }
            else if (button1.Text == button5.Text && button5.Text == button9.Text &&
                    button1.Enabled == false && button5.Enabled == false && button9.Enabled == false)
            {
                blockButtons();
                button1.BackColor = Color.Gold;
                button5.BackColor = Color.Gold;
                button9.BackColor = Color.Gold;
                game_over = true;
            }
            else if (button3.Text == button5.Text && button5.Text == button7.Text &&
                    button3.Enabled == false && button5.Enabled == false && button7.Enabled == false)
            {
                blockButtons();
                button3.BackColor = Color.Gold;
                button5.BackColor = Color.Gold;
                button7.BackColor = Color.Gold;
                game_over = true;
            }
            else
            {
                if (button1.Enabled == false &&
                    button2.Enabled == false &&
                    button3.Enabled == false &&
                    button4.Enabled == false &&
                    button5.Enabled == false &&
                    button6.Enabled == false &&
                    button7.Enabled == false &&
                    button8.Enabled == false &&
                    button9.Enabled == false)
                {
                    label1.Text = "Ничья!";
                }
            }
            if (game_over == true && label1.Text == string.Empty)
            {
                if (cross_zero == "X")
                    label1.Text = $"Победил игрок О";
                else
                    label1.Text = $"Победил игрок X";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = cross_zero;
            cross_zero = cross_zero == "X" ? "O" : "X";
            button1.Enabled = false;
            checkWin();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = cross_zero;
            cross_zero = cross_zero == "X" ? "O" : "X";
            button8.Enabled = false;
            checkWin();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            game_over = false;
            resetButtons();
            cross_zero = "X";
            label1.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = cross_zero;
            cross_zero = cross_zero == "X" ? "O" : "X";
            button2.Enabled = false;
            checkWin();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = cross_zero;
            cross_zero = cross_zero == "X" ? "O" : "X";
            button3.Enabled = false;
            checkWin();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = cross_zero;
            cross_zero = cross_zero == "X" ? "O" : "X";
            button4.Enabled = false;
            checkWin();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = cross_zero;
            cross_zero = cross_zero == "X" ? "O" : "X";
            button5.Enabled = false;
            checkWin();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = cross_zero;
            cross_zero = cross_zero == "X" ? "O" : "X";
            button6.Enabled = false;
            checkWin();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = cross_zero;
            cross_zero = cross_zero == "X" ? "O" : "X";
            button7.Enabled = false;
            checkWin();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = cross_zero;
            cross_zero = cross_zero == "X" ? "O" : "X";
            button9.Enabled = false;
            checkWin();
        }
    }
}
