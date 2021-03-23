// <copyright file="ServerForm.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PipeServer
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
    /// This is the Server Form.
    /// </summary>
    public partial class ServerForm : Form
    {
        // Initialise User Repository
        private static UserRepository userRepo = new UserRepository();

        // Initialise Password Manager
        private static PasswordManager pwdManager = new PasswordManager();

        // Initialise PipeServer
        private PipeServer pipeServer = new PipeServer();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerForm"/> class.
        /// Initializes this form.
        /// </summary>
        public ServerForm()
        {
            this.InitializeComponent();

            // Pipe Message Recievers
            this.pipeServer.MessageReceived += this.PipeServer_MessageReceived;
            this.pipeServer.ClientDisconnected += this.PipeServer_ClientDisconnected;
        }

        /// <summary>
        /// Method used to login a user.
        /// </summary>
        /// <param name="salt">Variable which passes through salt data.</param>
        /// <param name="userId">Variable which passes through user ID data.</param>
        /// <param name="password">Variable which passes through password data.</param>
        /// <returns>Returns a string that identifies whether a user has logged on.</returns>
        public static string UserLogin(string salt, string userId, string password)
        {
            // Checks to see if user already exists
            if (!userRepo.UserExists(userId))
            {
                return "No User with those credentials currently exists, please create a new User";
            }
            else
            {
                User userComparison = userRepo.GetUser(userId);
                bool match = pwdManager.IsPasswordMatch(password, userComparison.Salt, userComparison.PasswordHash);

                if (match == true)
                {
                    return "User succesfully logged in.";
                }
                else
                {
                    return "Incorrect login credentials";
                }
            }
        }

        /// <summary>
        /// Method used to create a new user.
        /// </summary>
        /// <param name="userId">Variable which passes through user ID data.</param>
        /// <param name="password">Variable which passes through password data.</param>
        /// <returns>Returns a string that identifies whether user creation has succeeded.</returns>
        public static string UserCreation(string userId, string password)
        {
            // Checks to see if user already exists
            if (userRepo.UserExists(userId))
            {
                return "A User with those login credentials already exists";
            }
            else
            {
                // Hash and Salt the password
                string salt = null;
                string passwordHash = pwdManager.GeneratePasswordHash(password, out salt);

                // Store the data
                User user = new User { UserId = userId, PasswordHash = passwordHash, Salt = salt };
                userRepo.AddUser(user);

                return "User creation successful";
            }
        }

        private void PipeServer_ClientDisconnected()
        {
            this.Invoke(new PipeServer.ClientDisconnectedHandler(this.ClientDisconnected));
        }

        private void ClientDisconnected()
        {
            MessageBox.Show("Total connected clients: " + this.pipeServer.TotalConnectedClients);
        }

        private void PipeServer_MessageReceived(byte[] message)
        {
            this.Invoke(new PipeServer.MessageReceivedHandler(this.DisplayMessageReceived), new object[] { message });
        }

        private void DisplayMessageReceived(byte[] message)
        {
            try
            {
                this.tbReceived.Clear();

                ASCIIEncoding encoder = new ASCIIEncoding();

                // Receive incoming message and convert into array, seperated by commas
                string[] receivedMessage;
                string str = encoder.GetString(message, 0, message.Length);
                receivedMessage = str.Split(',');

                // Checks to see if login request
                if (string.Equals(receivedMessage[0], "l"))
                {
                    this.tbReceived.Text += "Login Request" + "\r\n";
                    this.tbReceived.Text += "Username: " + receivedMessage[1] + "\r\n";
                    this.tbReceived.Text += "Password: " + receivedMessage[2] + "\r\n";

                    string salt = null;
                    string passwordHash = pwdManager.GeneratePasswordHash(receivedMessage[2], out salt);

                    // User Login & Password comparison
                    string returnMessage = UserLogin(salt, receivedMessage[1], receivedMessage[2]);

                    // Add to Servers Textbox
                    this.tbReceived.Text += returnMessage + "\r\n";

                    // Send to Client
                    // byte[] messageBuffer = encoder.GetBytes(UserLogin(salt, words[1], words[2]));
                    byte[] messageBuffer = encoder.GetBytes(returnMessage);
                    this.pipeServer.SendMessage(messageBuffer);
                }

                // Checks to see if user creation request
                if (string.Equals(receivedMessage[0], "c"))
                {
                    this.tbReceived.Text += "Create Request" + "\r\n";
                    this.tbReceived.Text += "Username: " + receivedMessage[1] + "\r\n";
                    this.tbReceived.Text += "Password: " + receivedMessage[2] + "\r\n";

                    // User creation
                    string returnMessage = UserCreation(receivedMessage[1], receivedMessage[2]);

                    // Add to Servers Textbox
                    this.tbReceived.Text += returnMessage + "\r\n";

                    // Send to Client
                    byte[] messageBuffer = encoder.GetBytes(returnMessage);
                    this.pipeServer.SendMessage(messageBuffer);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
        }

        // Method for start button
        private void BtnStartServer_Click(object sender, EventArgs e)
        {
            // Begin the pipe server unless already running
            if (!this.pipeServer.Running)
            {
                this.pipeServer.Start(this.tbPipeName.Text);
                this.BtnStartServer.Enabled = false;

                this.tbReceived.Text += "Server Initialised..." + "\r\n";

                // Create Admin Account
                string adminUser = "Admin";
                string adminPass = "AdminPass";
                UserCreation(adminUser, adminPass);

                // Send Admin Credentials to Received TB
                this.tbReceived.Text += "Admin Account created." + "\r\n";
                this.tbReceived.Text += "Admin User ID: " + adminUser + "\r\n";
                this.tbReceived.Text += "Admin Password: " + adminPass + "\r\n";
            }
        }
    }
}
