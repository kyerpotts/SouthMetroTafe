using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queues
{
    public partial class Form1 : Form
    {
        private MyQueue queue;

        public Form1()
        {
            InitializeComponent();
            queue = new MyQueue(5);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if(queue.isFull())
            {
                MessageBox.Show("Queue is already full");
                return;
            }

            queue.Insert(tbItem.Text);
            tbItem.Clear();
            tbItem.Focus();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(queue.isEmpty())
            {
                MessageBox.Show("Queue is already empty!");
                return;
            }

            MessageBox.Show(queue.Remove());
        }
    }
}
