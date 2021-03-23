using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIDemos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello " + tbName.Text);
            MessageBox.Show("Hello " + tbName.Text, "Greetings");
            MessageBox.Show("Hello " + tbName.Text, "Greetings", MessageBoxButtons.OK);
            MessageBox.Show("Hello " + tbName.Text, "Greetings", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DialogResult dr = MessageBox.Show("Do you like apples?", "Apples", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            string insert;
            if(dr == DialogResult.Yes)
            {
                insert = "likes";
            }
            else
            {
                insert = "does not like";
            }
            tbOutPut.Text = String.Format("{0} {1} apples", tbName.Text, insert);
        
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            string description;

            if (cmbProduct.Text == "Hammer")
            {
                description = "Id: 1\r\nProduct: Hammer\r\nPrice: 12.50";
            }
            else if (cmbProduct.Text == "Drill")
            {
                description = "Id: 1\r\nProduct: Drill\r\nPrice: 152.50";
            }
            else 
            {
                description = "Id: 1\r\nProduct: Saw\r\nPrice: 89.00";
            }
            tbProducts.Text = description;
                    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbFish.Items.Add("Trout");
            cmbFish.Items.Add("Shark");
            cmbFish.Items.AddRange(new string[] { "Snapper", "Salmon", "Barramundi" });
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(cmbFish.SelectedIndex == -1)
            {
                MessageBox.Show("Select an item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lstFish.Items.Add(cmbFish.Text);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(lstFish.SelectedIndex == -1)
            {
                MessageBox.Show("Select item to remove", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lstFish.Items.Remove(lstFish.SelectedItem);
        }

        private void btnLoop_Click(object sender, EventArgs e)
        {
            foreach(string s in lstFish.Items)
            {
                MessageBox.Show(s);
            }
        }

        private void btnColour_Click(object sender, EventArgs e)
        {
            foreach(RadioButton rb in grpColours.Controls)
            {
                if(rb.Checked)
                {
                    MessageBox.Show(String.Format("You chose {0}", rb.Text),"Choice",MessageBoxButtons.OK, MessageBoxIcon.Information);

                    break;
                }
            }
        }

        private void btnShoppingList_Click(object sender, EventArgs e)
        {
            tbShoppingList.Clear();

            foreach(CheckBox chk in grpShoppingList.Controls)
            {
                if (chk.Checked)
                {
                    tbShoppingList.Text += chk.Text + "\r\n";
                }
                
            }
        }
    }
}
