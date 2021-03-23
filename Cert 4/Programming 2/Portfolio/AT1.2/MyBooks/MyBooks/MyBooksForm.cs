using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBooks
{
    public partial class MyBooksForm : Form
    {
        public MyBooksForm()
        {
            InitializeComponent();
        }

        private static int bookCounter = 10;//static method to control size of the bookCollection array
        private int counter = 0;//pointer used as a reference to instance new classes in array and call fields to populate output list box
        private Book[] bookCollection = new Book[bookCounter];

        public void ClearTBs()//method to clear all textbox controls of user entered values
        {
            tbTitle.Clear();
            tbAuthor.Clear();
            tbDate.Clear();
            tbPublisher.Clear();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (tbTitle.Text == "" || tbAuthor.Text == "" || tbDate.Text == "" || tbPublisher.Text == "")
            {
                //generates error message if all fields are not pupulated with values from user
                MessageBox.Show("Please enter all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //instance books to next entry in array, add to counter for next instance
                bookCollection[counter] = new Book(tbTitle.Text, tbAuthor.Text, tbDate.Text, tbPublisher.Text);
                ClearTBs();//clears textbox controls after values collected and instanced
                lstOutput.Items.Add(bookCollection[counter].AddBook());//adds the fields collected to the output box based
                counter++;//increments counter ready for new entry
            }

        }
        
        
        
    }
}
