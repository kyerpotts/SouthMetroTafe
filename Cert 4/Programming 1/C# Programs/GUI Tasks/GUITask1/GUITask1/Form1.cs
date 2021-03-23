using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUITask1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddInfo_Click(object sender, EventArgs e)
        {
            if(tbFirstName.Text == "" || tbSurname.Text =="")
            {
                MessageBox.Show("Input a valid name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string gender;
            if(radMale.Checked)
            {
                gender = radMale.Text;
            }
            else
            {
                gender = radFemale.Text;
            }
            string line = tbFirstName.Text + " " + tbSurname.Text + "\r\n" + gender;

            tbInfo.Text += line + "\r\n";

            tbFirstName.Text = "";
            tbSurname.Text = "";
        }
    }
}
