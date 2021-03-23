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

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientForm"/> class.
        /// </summary>
        public ClientForm()
        {
            this.InitializeComponent();
            this.CreateNewPipeClient();
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
    }
}
