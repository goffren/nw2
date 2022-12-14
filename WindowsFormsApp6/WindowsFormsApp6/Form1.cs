using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string infixExpr;
        string postfixExpr;
        Dictionary<char, int> operationPriority = new Dictionary<char, int>()
        {
            {'(',0 },
            {'+',1 },
            {'-',1 },
            {'*',2 },
            {'/',2 },
            {'^',3 },
            {'`',4 },

        };
        string GetStringNumber(string expr, ref int pos)
        {
            string strNumber = "";
            for (; pos < expr.Length; pos++)
            {
                char num = expr[pos];
                if (Char.IsDigit(num))
                    strNumber += num;
                else
                {
                    pos--;
                    break;
                }
            }
            return strNumber;
        }
        string ToPostfix(string infixExpr)
        {
            string postfixExpr = "";
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < infixExpr.Length; i++)
            {
                char c = infixExpr[i];
                if (Char.IsDigit(c))
                {
                    postfixExpr += GetStringNumber(infixExpr, ref i) + " ";
                }
                else if (c == '(')
                {
                    stack.Push(c);
                }
                else if (c == ')')
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                        postfixExpr += stack.Pop();
                    stack.Pop();
                }
                else if (operationPriority.ContainsKey(c))
                {
                    char op = c;
                    if (op == '-' && (i == 0 || (i > 1 && operationPriority.ContainsKey(infixExpr[i - 1]))))
                        op = '`';
                    while (stack.Count > 0 && (operationPriority[stack.Peek()] >= operationPriority[op]))
                        postfixExpr += stack.Pop();

                    stack.Push(op);
                }
            }
            foreach (char op in stack)
                postfixExpr += op;

            return postfixExpr;
        }
        public string Reverse(string text)
        {
            if (text == null) return null;
            char[] array = text.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            infixExpr = textBox1.Text;
            postfixExpr = "" + ToPostfix(infixExpr + "\r");
            textBox2.Text = postfixExpr;
            postfixExpr = "" + (Reverse(ToPostfix(infixExpr + "\r")));
            textBox3.Text = postfixExpr;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
