using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;


namespace TextFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(@"C:\files\data.txt"))
                {
                    for(int i = 0; i < 10; i++)
                    {
                        writer.WriteLine("Line number " + (i + 1));
                    }
                }
            }
            catch(IOException ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader reader = new StreamReader(@"C:\files\data.txt"))
                {
                    string line;
                    while((line = reader.ReadLine()) != null)
                    {
                        lstOutput.Items.Add(line);
                    }
                }
            }
            catch(IOException ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }
    }
}
