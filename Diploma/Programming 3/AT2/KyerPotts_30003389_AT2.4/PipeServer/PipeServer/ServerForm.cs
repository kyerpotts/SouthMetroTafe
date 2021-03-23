using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PipeServer
{
    public partial class ServerForm : Form
    {
        // Initialise PipeServer
        private PipeServer pipeServer = new PipeServer();

        // Initialise User Repository
        static UserRepository userRepo = new UserRepository();

        // Initialise Password Manager
        static PasswordManager pwdManager = new PasswordManager();


        public ServerForm()
        {
            InitializeComponent();

            // Pipe Message Recievers
            pipeServer.MessageReceived += pipeServer_MessageReceived;
            pipeServer.ClientDisconnected += pipeServer_ClientDisconnected;
        }

        void pipeServer_ClientDisconnected()
        {
            Invoke(new PipeServer.ClientDisconnectedHandler(ClientDisconnected));
        }

        void ClientDisconnected()
        {
            MessageBox.Show("Total connected clients: " + pipeServer.TotalConnectedClients);
        }

        void pipeServer_MessageReceived(byte[] message)
        {
            Invoke(new PipeServer.MessageReceivedHandler(DisplayMessageReceived), new object[] { message });
        }

        void DisplayMessageReceived(byte[] message)
        {
            try
            {
                tbReceived.Clear();

                ASCIIEncoding encoder = new ASCIIEncoding();

                // Receive incoming message and convert into array, seperated by commas
                string[] receivedMessage;
                string str = encoder.GetString(message, 0, message.Length);
                receivedMessage = str.Split(',');

                // Checks to see if login request
                if (string.Equals(receivedMessage[0], "l"))
                {
                    tbReceived.Text += "Login Request" + "\r\n";
                    tbReceived.Text += "Username: " + receivedMessage[1] + "\r\n";
                    tbReceived.Text += "Password: " + receivedMessage[2] + "\r\n";

                    string salt = null;
                    string passwordHash = pwdManager.GeneratePasswordHash(receivedMessage[2], out salt);

                    // User Login & Password comparison
                    string returnMessage = UserLogin(salt, receivedMessage[1], receivedMessage[2]);

                    // Add to Servers Textbox
                    tbReceived.Text += returnMessage + "\r\n";

                    // Send to Client
                    //byte[] messageBuffer = encoder.GetBytes(UserLogin(salt, words[1], words[2]));
                    byte[] messageBuffer = encoder.GetBytes(returnMessage);
                    pipeServer.SendMessage(messageBuffer);
                }

                // Checks to see if user creation request
                if (string.Equals(receivedMessage[0], "c"))
                {
                    tbReceived.Text += "Create Request" + "\r\n";
                    tbReceived.Text += "Username: " + receivedMessage[1] + "\r\n";
                    tbReceived.Text += "Password: " + receivedMessage[2] + "\r\n";

                    // User creation
                    string returnMessage = UserCreation(receivedMessage[1], receivedMessage[2]);

                    // Add to Servers Textbox
                    tbReceived.Text += returnMessage + "\r\n";

                    // Send to Client
                    byte[] messageBuffer = encoder.GetBytes(returnMessage);
                    pipeServer.SendMessage(messageBuffer);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
        }

        // User Login Method
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

                if(match == true)
                {
                    return "User succesfully logged in";
                }
                else
                {
                    return "Incorrect login credentials";
                }
            }
        }

        // User Creation Method
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

        // Method for start button
        private void btnStartServer_Click(object sender, EventArgs e)
        {
            // Begin the pipe server unless already running
            if (!pipeServer.Running)
            {
                pipeServer.Start(tbPipeName.Text);
                btnStartServer.Enabled = false;

                tbReceived.Text += "Server Initialised..." + "\r\n";

                //Create Admin Account
                string adminUser = "Admin";
                string adminPass = "AdminPass";
                UserCreation(adminUser, adminPass);

                //Send Admin Credentials to Received TB
                tbReceived.Text += "Admin Account created." + "\r\n";
                tbReceived.Text += "Admin User ID: " + adminUser + "\r\n";
                tbReceived.Text += "Admin Password: " + adminPass + "\r\n";

            }

        }
    }
}
