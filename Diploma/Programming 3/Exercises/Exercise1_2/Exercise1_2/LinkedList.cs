using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1_2
{
    public partial class LinkedList : Form
    {
        public LinkedList()
        {
            InitializeComponent();
        }

        //linked list of cars
        LinkedList<string> myCarCollection = new LinkedList<string>();

        private void showLinkedList()
        {
            //clear all input boxes and the list box
            lstCarOutput.Items.Clear();
            tbCarName.Clear();
            tbNodeName.Clear();
            //display number of list nodes
            tbNodeCount.Text = numberOfNodes().ToString();
            //display linked list
            foreach (string c in myCarCollection)
            {
                lstCarOutput.Items.Add(c);
            }
        }



        private int numberOfNodes()
        {
            return myCarCollection.Count();
        }

        private void btnAddFirst_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbCarName.Text))
            {
                myCarCollection.AddFirst(tbCarName.Text);
                showLinkedList();
            }
            else
            {
                MessageBox.Show("Please enter a car name.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAddLast_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbCarName.Text))
            {
                myCarCollection.AddLast(tbCarName.Text);
                showLinkedList();
            }
            else
            {
                MessageBox.Show("Please enter a car name.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAddBefore_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(tbCarName.Text)) && (!string.IsNullOrEmpty(tbNodeName.Text)))
            {
                LinkedListNode<string> current = myCarCollection.Find(tbNodeName.Text);
                myCarCollection.AddBefore(current, tbCarName.Text);
                showLinkedList();
            }
            else
            {
                MessageBox.Show("Please enter a car name and node position.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAddAfter_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(tbCarName.Text)) && (!string.IsNullOrEmpty(tbNodeName.Text)))
            {
                LinkedListNode<string> current = myCarCollection.Find(tbNodeName.Text);
                myCarCollection.AddAfter(current, tbCarName.Text);
                showLinkedList();
            }
            else
            {
                MessageBox.Show("Please enter a car name and node position.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbCarName.Text))
            {
                myCarCollection.Remove(tbCarName.Text);
                showLinkedList();
            }
            else
            {
                MessageBox.Show("Please enter a car name.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            myCarCollection.Clear();
            showLinkedList();
        }

        private void lstCarOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbNodeName.Text = lstCarOutput.GetItemText(lstCarOutput.SelectedItem);
        }
    }
}
