using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenStack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            GenericStack<string> names = new GenericStack<string>(5);

            names.Push("Abe");
            names.Push("Bob");
            names.Push("Candy");
            names.Push("Don");
            names.Push("Earl");

            while (!names.IsEmpty())
            {
                MessageBox.Show(names.Pop());
            }

            GenericStack<int> scores = new GenericStack<int>(5);

            scores.Push(10);
            scores.Push(20);
            scores.Push(30);
            scores.Push(40);
            scores.Push(50);

            while (!scores.IsEmpty())
            {
                MessageBox.Show(scores.Pop().ToString());
            }

        }
    }
}
