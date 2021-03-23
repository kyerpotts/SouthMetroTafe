using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExceptionHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DoStuff(int x)
        {
            if (x != 5)
            {
                MessageBox.Show("doing stuff with " + x);
            }
            else
            {
                throw new Exception("Number cannot be 5");
            }
        }
        

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(tbNum.Text);
                int product = num * 2;

                MessageBox.Show("Your number double is " + product);

                DoStuff(num);
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
            catch(Exception x)
            {
                MessageBox.Show("Exception: " + x.Message);
            }
            finally
            {
                //Commonly used to clean u presources eg. close file handles and network connections.
                MessageBox.Show("Finally always runs");
            }
        }
    }
}
