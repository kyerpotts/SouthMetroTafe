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

namespace ComputerGamesCollection
{
    public partial class Form1 : Form
    {
        //create array of class so that instances can be used to populate fields, set order based on specific attributes etc etc
        string[] names = new string[20];
        string[] platforms = new string[20];
        string[] genres = new string [20];
        int entries = 0;

                    
            
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //create new entries into array, display new entry in array in alphabetical order
                names[entries] = tbName.Text;
                platforms[entries] = tbPlatform.Text;
                genres[entries] = tbGenre.Text;
                lstGames.Items.Add(names[entries]);
                entries++;
                
                //create new entry into array
                
            }
            catch(IOException f)
            {
                MessageBox.Show("Field input missing" + f, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
