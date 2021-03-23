/* Name: Kyer Potts
 * ID: 30003389
 * Date: 30/07/2019
 * Assignment: 2.1
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player
{
    public partial class MusicPlayer : Form
    {
        public MusicPlayer()
        {
            InitializeComponent();
        }

        private LinkedList<string> songList = new LinkedList<string>();

        private string currentSong = string.Empty;

        //Method will clear the lstSongOutput listbox object of any data, then will loop through the songList linked list object and print all of the collected song paths
        //into the lstSongOutput listbox object
        private void DisplaySongs()
        {
            //Clears the lstSongOutput control of all data
            lstSongOutput.Items.Clear();
            //Loops through songList object and adds each string to the lstSongOutput controls
            foreach(string s in songList)
            {
                lstSongOutput.Items.Add(s);
            }
        }

        //This method will play the the URL saved within the currentSong variable in the windows media player object
        private void PlaySong()
        {
            //Designates the current URL for the WMP object as the currentSog variable
            wmpMediaPlayer.URL = currentSong;
            //Plays the currentSong URL
            wmpMediaPlayer.Ctlcontrols.play();
        }

        //This button will opena  dialog box for the user to choose a song. It will then collect and store the song path within the songList linked list object run
        //the DisplaySongs method
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Create OpenFileDialog object
            OpenFileDialog ofd = new OpenFileDialog();
            //Checks to see whether or not FileDialog is okay
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //saves the file name of the selected item from the dialog box to strfilename variable
                var strfilename = ofd.SafeFileName;
                //converts the strfilename variable to string and adds it to the last node in songList object
                songList.AddLast(strfilename.ToString());
                //runs DisplaySongs method
                DisplaySongs();
            }
        }

        //Removes the song selected from the lstSongOutput list box fron the songList linked list object
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //checks to see whether an item within the lstSongOutput control has been selected
                if (lstSongOutput.SelectedIndex != -1)
                {
                    //initialises delete variable with the the text value from the selection from the lstSongOutput control
                    string delete = lstSongOutput.GetItemText(lstSongOutput.SelectedItem);
                    //Removes item with matched value of delete variable from the songList object
                    songList.Remove(delete);
                    //refreshes and redisplays updated list of songs in the lstSongOutput control
                    DisplaySongs();
                }
            }
            catch
            {
                MessageBox.Show("Error found, unable to delete song", "Error", MessageBoxButtons.OK);
            }
        }

        //Plays the first song that was added to songList
        private void btnPlayFirst_Click(object sender, EventArgs e)
        {
            try
            {
                //Sets the current song to First value within the songList object
                currentSong = songList.First();
                //runs the playSong method to play the first song
                PlaySong();
            }
            catch
            {
                MessageBox.Show("Error found, unable to play song", "Error", MessageBoxButtons.OK);
            }
        }

        //Plays the song that is previous to the current song in the songList linked list
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                //Checks to see whether the currentSong variable contains a value
                if(currentSong != string.Empty)
                {
                    //Create new LinkedListNode object to determine the current song within the songList linked list object
                    LinkedListNode<string> current = songList.Find(currentSong);
                    //Checks to see whether the previous node contains a value
                    if (current.Previous != null)
                    {
                        //sets currentSong variable to the previous value in songList object
                        currentSong = current.Previous.Value;
                        //plays the song URL contained in currentSong variable
                        PlaySong();
                    }
                    else
                    {
                        MessageBox.Show("No previous song available to play", "Important", MessageBoxButtons.OK);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error found, unable to play song", "Error", MessageBoxButtons.OK);
            }
        }

        //Plays the song that is next to the current song in the songList linked list
        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                //Checks to see whether the currentSong variable contains a value
                if (currentSong != string.Empty)
                {
                    //Create new LinkedListNode object to determine the current song within the songList linked list object
                    LinkedListNode<string> current = songList.Find(currentSong);
                    //Checks to see whether the next node contains a value
                    if (current.Next != null)
                    {
                        //sets currentSong variable to the next value in songList object
                        currentSong = current.Next.Value;
                        //plays the song URL contained in currentSong variable
                        PlaySong();
                    }
                    else
                    {
                        MessageBox.Show("No next song available to play", "Important", MessageBoxButtons.OK);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error found, unable to play song", "Error", MessageBoxButtons.OK);
            }
        }

        //Plays the last song added to the songList linked list object
        private void btnLast_Click(object sender, EventArgs e)
        {
            try
            {
                //Sets the current song to Last value within the songList object
                currentSong = songList.Last();
                //runs the playSong method to play the last song
                PlaySong();
            }
            catch
            {
                MessageBox.Show("Error found, unable to play song", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
