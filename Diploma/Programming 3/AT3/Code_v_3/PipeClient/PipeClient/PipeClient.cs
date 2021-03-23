// <copyright file="PipeClient.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PipeClient
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Win32.SafeHandles;

    /// <summary>
    /// Allow pipe communication between a server and a client.
    /// </summary>
    public class PipeClient
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern SafeFileHandle CreateFile(
           string pipeName,
           uint dwDesiredAccess,
           uint dwShareMode,
           IntPtr lpSecurityAttributes,
           uint dwCreationDisposition,
           uint dwFlagsAndAttributes,
           IntPtr hTemplate);

        /// <summary>
        /// Handles messages received from a server pipe.
        /// </summary>
        /// <param name="message">The byte message received.</param>
        public delegate void MessageReceivedHandler(byte[] message);

        /// <summary>
        /// Event is called whenever a message is received from the server pipe
        /// </summary>
        public event MessageReceivedHandler MessageReceived;

        /// <summary>
        /// Handles server disconnected messages.
        /// </summary>
        public delegate void ServerDisconnectedHandler();

        /// <summary>
        /// Event is called when the server pipe is severed.
        /// </summary>
        public event ServerDisconnectedHandler ServerDisconnected;

        const int BUFFER_SIZE = 4096;

        FileStream stream;
        SafeFileHandle handle;
        Thread readThread;

        /// <summary>
        /// Is this client connected to a server pipe.
        /// </summary>
        public bool Connected { get; private set; }

        /// <summary>
        /// The pipe this client is connected to.
        /// </summary>
        public string PipeName { get; private set; }

        /// <summary>
        /// Connects to the server with a pipename.
        /// </summary>
        /// <param name="pipename">The name of the pipe to connect to.</param>
        public void Connect(string pipename)
        {
            if (this.Connected)
            {
                throw new Exception("Already connected to pipe server.");
            }

            this.PipeName = pipename;

            this.handle =
               CreateFile(
                  this.PipeName,
                  0xC0000000, // GENERIC_READ | GENERIC_WRITE = 0x80000000 | 0x40000000
                  0,
                  IntPtr.Zero,
                  3, // OPEN_EXISTING
                  0x40000000, // FILE_FLAG_OVERLAPPED
                  IntPtr.Zero);

            // could not create handle - server probably not running
            if (this.handle.IsInvalid)
            {
                return;
            }

            this.Connected = true;

            // start listening for messages
            this.readThread = new Thread(this.Read)
            {
                IsBackground = true,
            };
            this.readThread.Start();
        }

        /// <summary>
        /// Disconnects from the server.
        /// </summary>
        public void Disconnect()
        {
            if (!this.Connected)
            {
                return;
            }

            // we're no longer connected to the server
            this.Connected = false;
            this.PipeName = null;

            // clean up resource
            if (this.stream != null)
            {
                this.stream.Close();
            }

            this.handle.Close();

            this.stream = null;
            this.handle = null;
        }

        void Read()
        {
            this.stream = new FileStream(this.handle, FileAccess.ReadWrite, BUFFER_SIZE, true);
            byte[] readBuffer = new byte[BUFFER_SIZE];

            while (true)
            {
                int bytesRead = 0;

                using (MemoryStream ms = new MemoryStream())
                {
                    try
                    {
                        // read the total stream length
                        int totalSize = this.stream.Read(readBuffer, 0, 4);

                        // client has disconnected
                        if (totalSize == 0)
                        {
                            break;
                        }

                        totalSize = BitConverter.ToInt32(readBuffer, 0);

                        do
                        {
                            int numBytes = this.stream.Read(readBuffer, 0, Math.Min(totalSize - bytesRead, BUFFER_SIZE));

                            ms.Write(readBuffer, 0, numBytes);

                            bytesRead += numBytes;
                        }
                        while (bytesRead < totalSize);
                    }
                    catch
                    {
                        // read error has occurred
                        break;
                    }

                    // client has disconnected
                    if (bytesRead == 0)
                    {
                        break;
                    }

                    // fire message received event
                    if (this.MessageReceived != null)
                    {
                        this.MessageReceived(ms.ToArray());
                    }
                }
            }

            // if connected, then the disconnection was
            // caused by a server terminating, otherwise it was from
            // a call to Disconnect()
            if (this.Connected)
            {
                // clean up resource
                this.stream.Close();
                this.handle.Close();

                this.stream = null;
                this.handle = null;

                // we're no longer connected to the server
                this.Connected = false;
                this.PipeName = null;

                if (this.ServerDisconnected != null)
                {
                    this.ServerDisconnected();
                }
            }
        }

        /// <summary>
        /// Sends a message to the server.
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <returns>True if the message is sent successfully - false otherwise.</returns>
        public bool SendMessage(byte[] message)
        {
            try
            {
                // write the entire stream length
                this.stream.Write(BitConverter.GetBytes(message.Length), 0, 4);

                this.stream.Write(message, 0, message.Length);
                this.stream.Flush();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
