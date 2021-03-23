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
        //global variables to hold array data
        string[] names = new string[20];
        string[] platforms = new string[20];
        string[] genres = new string[20];
        //pointer for next empty index, increments with each click of the add button, decrements with delete
        int entries = 0;

        public Form1()
        {
            InitializeComponent();
        }
        //Display names method to populate entries into listbox
        private void DisplayNames()
        {
            lstGames.Items.Clear();
            for (int i = 0; i < entries; i++)
            {
                lstGames.Items.Add(names[i] + " " + platforms[i] + " " + genres[i]);
            }
        }
        //Clears the textbox controls of any data
        private void ClearTBs()
        {
            tbName.Clear();
            tbPlatform.Clear();
            tbGenre.Clear();
        }

        //Sorts entries by alhpabetical order of names array
        private void BubbleSort(string[] names)
        {
            for (int outer = entries - 1; outer > 0; outer--)
            {
                for (int inner = 0; inner < outer; inner++)
                {
                    if (names[inner].CompareTo(names[inner + 1]) > 0)
                    {
                        string tmpnames = names[inner + 1];
                        string tmpplatforms = platforms[inner + 1];
                        string tmpgenres = genres[inner + 1];
                        names[inner + 1] = names[inner];
                        platforms[inner + 1] = platforms[inner];
                        genres[inner + 1] = genres[inner];
                        names[inner] = tmpnames;
                        platforms[inner] = tmpplatforms;
                        genres[inner] = tmpgenres;
                    }
                }
            }
        }
        //Searches the listbox for matched strings based on user input in the "Name" control
        private int BinarySearch(string[] names, string search)
        {   
            int lowerBound = 0;
            int upperBound = entries - 1;
            int i;

            while (true)
            {
                i = (lowerBound + upperBound) / 2;
                if (names[i].CompareTo(search) == 0)
                {
                    return i; //found search
                }
                else if (lowerBound > upperBound)
                {
                    return -1; //search not found
                }
                else
                {
                    if (names[i].CompareTo(search) < 0)//continue search
                    {
                        lowerBound = i + 1;
                    }
                    else
                    {
                        upperBound = i - 1;
                    }
                }
            }
        }
        //Save "entries" and array data into binary file
        private void WriteFile(int entries, string[] names, string[] platforms, string[] genres)
        {
            try
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open("mygames.dat", FileMode.Create)))
                {
                    writer.Write(entries);
                    for (int i = 0; i < entries; i++)
                    {
                        writer.Write(names[i]);
                        writer.Write(platforms[i]);
                        writer.Write(genres[i]);
                    }
                }
            }
            catch (IOException x)
            {
                MessageBox.Show("Exception:" + x.Message);
            }
        }
        //Read "entries" and array data from previously saved binary file
        private void ReadFile()
        {
            if (File.Exists("mygames.dat"))
            {
                try
                {
                    using (BinaryReader reader = new BinaryReader(File.Open("mygames.dat", FileMode.Open)))
                    {
                        entries = reader.ReadInt32();
                        for (int i = 0; i < entries; i++)
                        {
                            names[i] = reader.ReadString();
                            platforms[i] = reader.ReadString();
                            genres[i] = reader.ReadString();
                        }
                    }
                }
                catch (IOException x)
                {
                    MessageBox.Show("Exception: " + x.Message);
                }
            }
            else
            {
                MessageBox.Show("No save file currently exists. New save file will be created on program termination", "No Save File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbPlatform.Text == "" || tbGenre.Text == "")
            {
                MessageBox.Show("Please enter all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //create new entries into array, display new entry in array in alphabetical order
                names[entries] = tbName.Text;
                platforms[entries] = tbPlatform.Text;
                genres[entries] = tbGenre.Text;
                ClearTBs();
                entries++;//increments amount of entries to be used as counters
                BubbleSort(names); //sorts all arrays on alphabetical order of names
                DisplayNames(); //repopulates listbox fields from sorted arrays
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            int index = lstGames.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Select an item");
                return;
            }

            for (int i = index; i < entries - 1; i++)
            {
                names[i] = names[i + 1];
                platforms[i] = platforms[i + 1];
                genres[i] = genres[i + 1];

            }
            entries--;
            ClearTBs();
            DisplayNames();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTBs();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearTBs();
            entries = 0;
            DisplayNames();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(tbName.Text == "" || tbPlatform.Text == "" || tbGenre.Text == "")
            {
                MessageBox.Show("Please enter all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                names[lstGames.SelectedIndex] = tbName.Text;
                platforms[lstGames.SelectedIndex] = tbPlatform.Text;
                genres[lstGames.SelectedIndex] = tbGenre.Text;
                BubbleSort(names);
                DisplayNames();
            }
        }

        private void lstGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstGames.SelectedIndex == -1)//if nothing is selected, return
            {
                return;
            }
            tbName.Text = names[lstGames.SelectedIndex];
            tbPlatform.Text = platforms[lstGames.SelectedIndex];
            tbGenre.Text = genres[lstGames.SelectedIndex];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = tbName.Text;
            int index = BinarySearch(names, search);
            if (index > -1)//if BinarySearch found a result
            {
                lstGames.SetSelected(index, true);
            }
            else
            {
                MessageBox.Show("Could not find the entry", "Search Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ClearTBs();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            WriteFile(entries, names, platforms, genres);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            ReadFile();
            DisplayNames();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            WriteFile(entries, names, platforms, genres);
        }
    }
}
