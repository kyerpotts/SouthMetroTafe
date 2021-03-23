using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeleteFromArray
{
    public partial class Form1 : Form
    {
        private string[] names;
        int numItems;

        public Form1()
        {
            InitializeComponent();
            names = new string[20];
            names[0] = "jack";
            names[1] = "fred";
            names[2] = "candi";
            names[3] = "sue";
            names[4] = "bob";
            names[5] = "luke";

            numItems = 6;

            DisplayNames();

        }

       

        private void DeleteAt(string[] strings, int index)
        {
            for(int i = index; i < numItems - 1; i++)
            {
                strings[i] = strings[i + 1];
            }
            numItems--;

        }

        private void DisplayNames()
        {
            lstOuput.Items.Clear();
            for(int i = 0; i < numItems; i++)
            {
                lstOuput.Items.Add(names[i]);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lstOuput.SelectedIndex;
            if(index == -1)
            {
                MessageBox.Show("Select an item");
                return;
            }

            DeleteAt(names, index);

            DisplayNames();
        }
    }
}
