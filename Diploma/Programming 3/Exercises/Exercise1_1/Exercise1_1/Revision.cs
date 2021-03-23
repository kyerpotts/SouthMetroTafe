using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1_1
{
    public partial class Revision : Form
    {
        public Revision()
        {
            InitializeComponent();
        }

        //create list of students
        List<string> studentList = new List<string>();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbStudent.Text != "")
            {
                //add name from textbox into List
                studentList.Add(tbStudent.Text);
                //clear student textbox
                tbStudent.Clear();
            }
            else
            {
                MessageBox.Show("No data available to add, please ensure all fields are entered correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            //clear entries in listbox
            lstStudents.Items.Clear();
            //add all entries from list into list box
            foreach (string s in studentList)
            {
                lstStudents.Items.Add(s);
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            studentList.Sort();
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            studentList.Reverse();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (tbStudent.Text != "")
            {
                studentList.Remove(tbStudent.Text);
            }
            else
            {
                MessageBox.Show("No data available to add, please ensure all fields are entered correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
            }
        }
    }
}
