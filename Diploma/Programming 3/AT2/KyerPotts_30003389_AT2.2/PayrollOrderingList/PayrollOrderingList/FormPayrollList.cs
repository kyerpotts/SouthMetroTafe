using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PayrollOrderingList
{
    public partial class FormPayrollList : Form
    {
        public FormPayrollList()
        {
            InitializeComponent();

            // Sets the key and values for Student class in the lstOutput list box. This is so the key(Student.id) can be retrieved when removing
            // items from the binary tree and list box.
            lstOutput.DisplayMember = "name";
            lstOutput.ValueMember = "id";
        }

        // Intitialise value foor the student ID, this value wwill increment with every new Student object that is created, and then is used to
        // initialise the id variable for each respective object
        private int studentCounter = 1;

        // Instantiate the BST object. Type Object is used to allow certain functions to be used that are unavailable in the Student class.
        BinarySearchTree<Object> orderingList = new BinarySearchTree<Object>();

        // Display method allows all user entered data to be displayed in the lstOutpuit list box
        private void Display()
        {
            // lstOutput data is cleared.
            lstOutput.Items.Clear();

            // Display method traverses or "walks" the binary search tree and returns the data object within each node.
            foreach (Student n in orderingList.TraverseTree())
            {
                // The method then retrieves the key and value (id and name) and then displays them in lstOutput list box.
                lstOutput.Items.Add(new Student(n.id, n.name) { name = n.name, id = n.id });
            }
        }

        // Adds new data to the binary search tree
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // New Student object is instantiated using the studentCounter variable and the tbControl user entered data as parameter values
            Student student = new Student(studentCounter, tbControl.Text);
            
            // Adds newly created student object into BST using the Insert method
            orderingList.Insert(student);
            // studentCounter is then incremented for the next entry
            studentCounter++;
            // Display method is called to refresh the data within lstOutput
            Display();
            //Clears the tbControl textbox of any user entered data
            tbControl.Clear();
        }

        // Removes the selected object from the lstOutput list box and the Binary Search Tree
        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Checks to see whether an item has been selected from lstOutput list box
            if (lstOutput.SelectedIndex != -1)
            {
                // Removes the item selected from the lstOutput list box from it's respective entry in the BST
                orderingList.Remove(lstOutput.SelectedItem);
                // Display method is called to refresh teh data within lstOutput
                Display();
            }
        }

        // Method to search the BST and lstOutput list box for matched data
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Clears lstOutput of any previously selected item
            lstOutput.ClearSelected();

            // Loops items within lstOutput
            foreach (Student s in lstOutput.Items)
            {
                // Checks to see if Student.name value matches matches string entered into tbControl by user
               if(s.name == tbControl.Text)
                {
                    // Sets the selected index of the matched item within lstOutput to the index of the found item
                    lstOutput.SetSelected(lstOutput.Items.IndexOf(s), true);
                    break;
                }

               // Checks to see if the item was not found
                if(lstOutput.SelectedIndex == -1)
                {
                    // Display not found message in status label
                    toolStripStatusLabel1.Text = (tbControl.Text + " not found");
                }
            }
        }
    }
}
