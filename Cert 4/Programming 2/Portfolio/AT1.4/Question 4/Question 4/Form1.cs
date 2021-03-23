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

namespace Question_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static int maxSize = 10;
        private static int entrySize = 4;
        string[,] gameArray = new string[maxSize, entrySize];
        int entries = 0;

        //clears textbox controls of user input
        private void ClearTbs()
        {
            tbGameTitle.Clear();
            tbGenre.Clear();
            tbPlatform.Clear();
            tbPublisher.Clear();
        }

        //adds text from textbox controls into 2D array and then clears textbox controls, increments entries counter
        private void AddItems(string gameTitle, string platform, string genre, string publisher)
        {
            if (tbGameTitle.Text != "" && tbPlatform.Text != "" && tbGenre.Text != "" && tbPublisher.Text != "" && entries < maxSize)
            {
                gameArray[entries, 0] = gameTitle;
                gameArray[entries, 1] = platform;
                gameArray[entries, 2] = genre;
                gameArray[entries, 3] = publisher;
                ClearTbs();
                entries++;
            }
            else
            {
                MessageBox.Show("Cannot enter data, please ensure all fields are entered correctly and the number entries has not exceeded " + maxSize, "Incorrect Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //displays data from 2D array into the output list
        private void Display()
        {
            lstMyGames.Items.Clear();
            for (int i = 0; i < entries; i++)
            {
                lstMyGames.Items.Add(gameArray[i, 0] + ", " + gameArray[i, 1] + ", " + gameArray[i, 2] + ", " + gameArray[i, 3]);
            }
        }

        //sorts data in 2D array by alphabetical order based upon first index of the 2nd dimension in array
        private void BubbleSort(string[,] gameArray)
        {
            for (int i = 0; i < entries - 1; i++)
            {
                for (int j = 0; j < entries - 1; j++)
                {
                    BubbleSwap(gameArray, j);
                }
            }
        }

        private void BubbleSwap(string[,] gameArray, int j)
        {
            if (gameArray[j, 0].CompareTo(gameArray[j + 1, 0]) > 0)
            {
                string[] temp = new string[4];
                temp[0] = gameArray[j, 0];
                temp[1] = gameArray[j, 1];
                temp[2] = gameArray[j, 2];
                temp[3] = gameArray[j, 3];

                gameArray[j, 0] = gameArray[j + 1, 0];
                gameArray[j, 1] = gameArray[j + 1, 1];
                gameArray[j, 2] = gameArray[j + 1, 2];
                gameArray[j, 3] = gameArray[j + 1, 3];

                gameArray[j + 1, 0] = temp[0];
                gameArray[j + 1, 1] = temp[1];
                gameArray[j + 1, 2] = temp[2];
                gameArray[j + 1, 3] = temp[3];
            }
        }

        //binary search method finds matched text from textbox control and matches to first index of second dimension, returns int to be used for selected index of lstMyGames
        private int Search(string[,] gameArray, string search)
        {
            int lowerBound = 0;
            int upperBound = entries - 1;
            int i;

            while (true)
            {
                i = (lowerBound + upperBound) / 2;
                if (gameArray[i, 0] == search)
                {
                    return i;
                }
                else if (lowerBound > upperBound)
                {
                    return -1;
                }
                else
                {
                    if (gameArray[i, 0].CompareTo(search) < 0)
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

        //writes data from 2D array into .dat file
        private void WriteFile(int Entries, string[,] gameArray)
        {
            try
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open("mygames.dat", FileMode.Create)))
                {
                    writer.Write(Entries);
                    for (int i = 0; i < Entries; i++)
                    {
                        for (int j = 0; j < gameArray.GetLength(1); j++)
                        {
                            writer.Write(gameArray[i, j]);
                        }
                    }
                }
            }
            catch (IOException x)
            {
                MessageBox.Show("Exception:" + x.Message);
            }
        }

        //Read entries and array data from .dat file
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
                            for (int j = 0; j < gameArray.GetLength(1); j++)
                            {
                                gameArray[i, j] = reader.ReadString();
                            }
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

        //adds items to array, sorts items by alphabetical order and displays them into lstMyGames output on button click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddItems(tbGameTitle.Text, tbPlatform.Text, tbGenre.Text, tbPublisher.Text);
            BubbleSort(gameArray);
            Display();
        }

        //finds entry based on matched text from Game Title textbox and then selects matched entry from lstMyGames output
        private void tbSearch_Click(object sender, EventArgs e)
        {
            if (Search(gameArray, tbGameTitle.Text) > -1)
            {
                lstMyGames.SetSelected(Search(gameArray, tbGameTitle.Text), true);
            }
            else
            {
                MessageBox.Show("Could not find the entry", "Search Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ClearTbs();
            }
        }

        //Clears all textbox controls of user entered data
        private void tbClear_Click(object sender, EventArgs e)
        {
            ClearTbs();
        }

        //calls WriteFile method on button click, saves all user entered data to .dat file
        private void tbSave_Click(object sender, EventArgs e)
        {
            WriteFile(entries, gameArray);
        }

        //calls ReadFile method on button click, loads all user entered data from .dat file into emptry 2D string array
        private void tbLoad_Click(object sender, EventArgs e)
        {
            ReadFile();
            Display();
        }
    }
}