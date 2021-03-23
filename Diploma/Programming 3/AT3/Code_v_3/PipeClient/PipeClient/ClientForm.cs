// <copyright file="ClientForm.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PipeClient
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// Partial Client Form Class.
    /// </summary>
    public partial class ClientForm : Form
    {
        private PipeClient pipeClient;

        private CSVReader csv = new CSVReader();

        private List<Movies> movieList;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientForm"/> class.
        /// </summary>
        public ClientForm()
        {
            this.InitializeComponent();
            this.CreateNewPipeClient();

            this.KeyPreview = true;
        }

        // Method to create Pipe Client Object with message receive and disconnect parameters
        private void CreateNewPipeClient()
        {
            if (this.pipeClient != null)
            {
                this.pipeClient.MessageReceived -= this.PipeClient_MessageReceived;
                this.pipeClient.ServerDisconnected -= this.PipeClient_ServerDisconnected;
            }

            // Initialise pipeClient Object
            this.pipeClient = new PipeClient();
            this.pipeClient.MessageReceived += this.PipeClient_MessageReceived;
            this.pipeClient.ServerDisconnected += this.PipeClient_ServerDisconnected;
        }

        private void PipeClient_ServerDisconnected()
        {
            this.Invoke(new PipeClient.ServerDisconnectedHandler(this.EnableStartButton));
        }

        private void EnableStartButton()
        {
            this.BtnConnect.Enabled = true;
        }

        private void PipeClient_MessageReceived(byte[] message)
        {
            this.Invoke(
                new PipeClient.MessageReceivedHandler(this.DisplayReceivedMessage),
                new object[] { message });
        }

        private void DisplayReceivedMessage(byte[] message)
        {
            this.tbReceived.Clear();

            ASCIIEncoding encoder = new ASCIIEncoding();
            string str = encoder.GetString(message, 0, message.Length);
            if (str == "User succesfully logged in.")
            {
                this.BtnImportCSV.Enabled = true;
                this.BtnShuffle.Enabled = true;
                this.BtnSort.Enabled = true;
                this.BtnSearch.Enabled = true;
            }

            if (str == "close")
            {
                this.pipeClient.Disconnect();

                this.CreateNewPipeClient();
                this.pipeClient.Connect(this.tbPipeName.Text);
            }

            this.tbReceived.Text += str + "\r\n";
        }

        // Button Method to connect to pipe Server
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            // Connection string for the pipe Server
            this.pipeClient.Connect(this.tbPipeName.Text);

            // Determines if pipe is already connected
            if (this.pipeClient.Connected)
            {
                this.BtnConnect.Enabled = false;
                this.tbReceived.Text = "Client Connected...";
            }
            else
            {
                this.tbReceived.Text = "Client unable to connect...";
            }
        }

        // Button Method to Login to Server
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.pipeClient.Connected)
                {
                    if (string.IsNullOrEmpty(this.tbUserID.Text))
                    {
                        this.tbReceived.Text += "Please enter a User ID.";
                    }
                    else if (string.IsNullOrEmpty(this.tbPassword.Text))
                    {
                        this.tbReceived.Text += "Please enter a Password.";
                    }
                    else
                    {
                        ASCIIEncoding encoder = new ASCIIEncoding();
                        this.pipeClient.SendMessage(encoder.GetBytes("l" + "," + this.tbUserID.Text + "," + this.tbPassword.Text));
                    }
                }
                else
                {
                    this.tbReceived.Text = "Client not connected.";
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Button Method to Create New User
        private void BtnCreateUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.pipeClient.Connected)
                {
                    if (string.IsNullOrEmpty(this.tbUserID.Text))
                    {
                        this.tbReceived.Text += "Please enter a User ID.";
                    }
                    else if (string.IsNullOrEmpty(this.tbPassword.Text))
                    {
                        this.tbReceived.Text += "Please enter a Password.";
                    }
                    else
                    {
                        ASCIIEncoding encoder = new ASCIIEncoding();
                        this.pipeClient.SendMessage(encoder.GetBytes("c" + "," + this.tbUserID.Text + "," + this.tbPassword.Text));
                    }
                }
                else
                {
                    this.tbReceived.Text = "Client not connected.";
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void DisplayMovies()
        {
            this.LstOutput.Items.Clear();
            foreach (Movies m in this.movieList)
            {
                this.LstOutput.Items.Add(m.Name);
            }
        }

        private List<T> ShuffleMovies<T>(List<T> inputList)
        {
            List<T> randomList = new List<T>();

            Random r = new Random();
            int randomIndex = 0;
            while (inputList.Count > 0)
            {
                randomIndex = r.Next(0, inputList.Count);
                randomList.Add(inputList[randomIndex]);
                inputList.RemoveAt(randomIndex);
            }

            return randomList;
        }

        private int SearchMovies(string search)
        {
            foreach (Movies m in this.movieList)
            {
                if (m.Name == search)
                {
                    return this.movieList.IndexOf(m);
                }
            }

            return -1;
        }

        #region MergeSort
        private List<Movies> MergeSort(List<Movies> unsorted)
        {
            if (unsorted.Count <= 1)
            {
                return unsorted;
            }

            List<Movies> right = new List<Movies>();
            List<Movies> left = new List<Movies>();

            int middle = unsorted.Count / 2;

            for (int i = 0; i < middle; i++)
            {
                left.Add(unsorted[i]);
            }

            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }

            left = this.MergeSort(left);
            right = this.MergeSort(right);
            return this.Merge(left, right);
        }

        private List<Movies> Merge(List<Movies> left, List<Movies> right)
        {
            List<Movies> result = new List<Movies>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First().Id <= right.First().Id)
                    {
                        result.Add(left.First());
                        left.Remove(left.First());
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());
                    right.Remove(right.First());
                }
            }

            return result;
        }
        #endregion

        private void BtnImportCSV_Click(object sender, EventArgs e)
        {
            this.csv.ReadCSV();
            this.movieList = new List<Movies>(this.csv.GetMovies());
            this.DisplayMovies();
        }

        private void BtnShuffle_Click(object sender, EventArgs e)
        {
            try
            {
                this.movieList = this.ShuffleMovies(this.movieList);
                this.DisplayMovies();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BtnSort_Click(object sender, EventArgs e)
        {
            this.movieList = this.MergeSort(this.movieList);
            this.DisplayMovies();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (this.SearchMovies(this.tbSearch.Text) != -1)
            {
                this.LstOutput.SelectedIndex = this.SearchMovies(this.tbSearch.Text);
            }
            else
            {
                MessageBox.Show("Movie not found, please try again", "Could not Find Movie", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ClientForm_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                // Ctrl + Q to close appliactions
                if (e.Control && e.KeyCode == Keys.Q)
                {
                    this.pipeClient.Disconnect();
                    Application.Exit();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
