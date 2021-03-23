using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PipeClient
{
    public partial class ClientForm : Form
    {
        private PipeClient pipeClient;

        public ClientForm()
        {
            InitializeComponent();
            CreateNewPipeClient();
        }

        // Method to create Pipe Client Object with message receive and disconnect parameters
        void CreateNewPipeClient()
        {
            if(pipeClient != null)
            {
                pipeClient.MessageReceived -= pipeClient_MessageReceived;
                pipeClient.ServerDisconnected -= pipeClient_ServerDisconnected;
            }

            // Initialise pipeClient Object
            pipeClient = new PipeClient();
            pipeClient.MessageReceived += pipeClient_MessageReceived;
            pipeClient.ServerDisconnected += pipeClient_ServerDisconnected;
        }

        void pipeClient_ServerDisconnected()
        {
            Invoke(new PipeClient.ServerDisconnectedHandler(EnableStartButton));
        }

        void EnableStartButton()
        {
            btnConnect.Enabled = true;
        }

        void pipeClient_MessageReceived(byte[] message)
        {
            Invoke(new PipeClient.MessageReceivedHandler(DisplayReceivedMessage),
                new object[] { message });
        }

        void DisplayReceivedMessage(byte[] message)
        {
            tbReceived.Clear();

            ASCIIEncoding encoder = new ASCIIEncoding();
            string str = encoder.GetString(message, 0, message.Length);

            if (str == "close")
            {
                pipeClient.Disconnect();

                CreateNewPipeClient();
                pipeClient.Connect(tbPipeName.Text);
            }

            tbReceived.Text += str + "\r\n";
        }

        // Button Method to connect to pipe Server
        private void btnConnect_Click(object sender, EventArgs e)
        {
            // Connection string for the pipe Server
            pipeClient.Connect(tbPipeName.Text);

            // Determines if pipe is already connected
            if (pipeClient.Connected)
            {
                btnConnect.Enabled = false;
                tbReceived.Text = "Client Connected...";
            }
            else
            {
                tbReceived.Text = "Client unable to connect...";
            }
        }

        // Button Method to Login to Server
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (pipeClient.Connected)
                {
                    if (string.IsNullOrEmpty(tbUserID.Text))
                    {
                        tbReceived.Text += "Please enter a User ID.";
                    }
                    else if (string.IsNullOrEmpty(tbPassword.Text))
                    {
                        tbReceived.Text += "Please enter a Password.";
                    }
                    else
                    {
                        ASCIIEncoding encoder = new ASCIIEncoding();
                        pipeClient.SendMessage(encoder.GetBytes("l" + "," + tbUserID.Text + "," + tbPassword.Text));
                    }
                }
                else
                {
                    tbReceived.Text = "Client not connected.";
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Button Method to Create New User
        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (pipeClient.Connected)
                {
                    if (string.IsNullOrEmpty(tbUserID.Text))
                    {
                        tbReceived.Text += "Please enter a User ID.";
                    }
                    else if (string.IsNullOrEmpty(tbPassword.Text))
                    {
                        tbReceived.Text += "Please enter a Password.";
                    }
                    else
                    {
                        ASCIIEncoding encoder = new ASCIIEncoding();
                        pipeClient.SendMessage(encoder.GetBytes("c" + "," + tbUserID.Text + "," + tbPassword.Text));
                    }
                }
                else
                {
                    tbReceived.Text = "Client not connected.";
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
