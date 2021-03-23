using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stacks
{
    public partial class Form1 : Form
    {
        private MyStack stack;

        public Form1()
        {
            InitializeComponent();
            stack = new MyStack(5);

        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            if (stack.IsFull())
            {
                MessageBox.Show("Stack is full");
                return;
            }

            stack.Push(tbItem.Text);
            tbItem.Clear();
            tbItem.Focus();
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            if (stack.IsEmpty())
            {
                MessageBox.Show("Stack is empty!");
                return;
            }
            MessageBox.Show(stack.Pop());
        }
    }
}
