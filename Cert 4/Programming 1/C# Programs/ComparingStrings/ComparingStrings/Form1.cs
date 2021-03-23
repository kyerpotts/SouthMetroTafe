using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComparingStrings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            if(txtA.Text.Length == 0 || txtB.Text.Length == 0)
            {
                MessageBox.Show("Enter two strings");
                return;
            }

            string strA = txtA.Text;
            string strB = txtB.Text;

            int comparisonResult = strA.CompareTo(strB);

            if (comparisonResult == 0)
            {
                MessageBox.Show("String A (" + strA + 
                    ") is equal to string B (" + strB + ")");
            }
            else if (comparisonResult < 0)
            {
                MessageBox.Show("String A (" + strA + 
                    ") comes before string B (" + strB + ") alphabetically");
            }
            else //    > 0
            {
                MessageBox.Show("String A (" + strA + 
                    ") comes after string B (" + strB + ") alphabetically");
            }

        }
    }
}
