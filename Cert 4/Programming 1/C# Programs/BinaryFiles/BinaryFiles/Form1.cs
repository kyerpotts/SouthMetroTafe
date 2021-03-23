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

namespace BinaryFiles
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
                using (BinaryWriter writer = new BinaryWriter(File.Open(@"C:\files\data.dat", FileMode.Create)))
                {
                    writer.Write(10);
                    writer.Write(true);
                    writer.Write("jack");
                    writer.Write(23.4);
                }
            }
            catch(IOException x)
            {
                MessageBox.Show("Exception:" + x.Message);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                using (BinaryReader reader = new BinaryReader(File.Open(@"C:\files\data.dat", FileMode.Open)))
                {
                    int num = reader.ReadInt32();
                    bool tf = reader.ReadBoolean();
                    string str = reader.ReadString();
                    double dbl = reader.ReadDouble();

                    lstOutput.Items.Add(num);
                    lstOutput.Items.Add(tf);
                    lstOutput.Items.Add(str);
                    lstOutput.Items.Add(dbl);

                }
            }
            catch(IOException x)
            {
                MessageBox.Show("Exception: " + x.Message);
            }
        }
    }
}
