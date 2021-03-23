// <copyright file="PipeServer.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PipeServer
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.InteropServices;
    using System.Threading;
    using Microsoft.Win32.SafeHandles;

    /// <summary>
    /// Allow pipe communication between a server and a client.
    /// </summary>
    public class PipeServer
    {
        [DllImport("kernel32.dll", SetLastError = true)]
#pragma warning disable SA1400 // Access modifier should be declared
        static extern SafeFileHandle CreateNamedPipe(
#pragma warning restore SA1400 // Access modifier should be declared
#pragma warning disable SA1121 // Use built-in type alias
#pragma warning disable SA1114 // Parameter list should follow declaration
           string pipeName,
#pragma warning restore SA1114 // Parameter list should follow declaration
#pragma warning restore SA1121 // Use built-in type alias
           uint dwOpenMode,
           uint dwPipeMode,
           uint nMaxInstances,
           uint nOutBufferSize,
           uint nInBufferSize,
           uint nDefaultTimeOut,
           IntPtr lpSecurityAttributes);

        [DllImport("kernel32.dll", SetLastError = true)]
#pragma warning disable SA1400 // Access modifier should be declared
        static extern int ConnectNamedPipe(
#pragma warning restore SA1400 // Access modifier should be declared
           SafeFileHandle hNamedPipe,
           IntPtr lpOverlapped);

        [DllImport("kernel32.dll", SetLastError = true)]
#pragma warning disable SA1400 // Access modifier should be declared
        static extern bool DisconnectNamedPipe(SafeFileHandle hHandle);
#pragma warning restore SA1400 // Access modifier should be declared

        [StructLayoutAttribute(LayoutKind.Sequential)]
        struct SECURITY_DESCRIPTOR
        {
            public byte revision;
            public byte size;
            public short control;
            public IntPtr owner;
            public IntPtr group;
            public IntPtr sacl;
            public IntPtr dacl;
        }

        [StructLayout(LayoutKind.Sequential)]
#pragma warning disable SA1202 // Elements should be ordered by access
        public struct SECURITY_ATTRIBUTES
#pragma warning restore SA1202 // Elements should be ordered by access
        {
            public int nLength;
            public IntPtr lpSecurityDescriptor;
            public int bInheritHandle;
        }

#pragma warning disable SA1201 // Elements should appear in the correct order
        private const uint SECURITY_DESCRIPTOR_REVISION = 1;
#pragma warning restore SA1201 // Elements should appear in the correct order

        [DllImport("advapi32.dll", SetLastError = true)]
#pragma warning disable SA1400 // Access modifier should be declared
        static extern bool InitializeSecurityDescriptor(ref SECURITY_DESCRIPTOR sd, uint dwRevision);
#pragma warning restore SA1400 // Access modifier should be declared

        [DllImport("advapi32.dll", SetLastError = true)]
        static extern bool SetSecurityDescriptorDacl(ref SECURITY_DESCRIPTOR sd, bool daclPresent, IntPtr dacl, bool daclDefaulted);

        public class Client
        {
            public SafeFileHandle handle;
            public FileStream stream;
        }

#pragma warning disable SA1201 // Elements should appear in the correct order
                              /// <summary>
                              /// Handles messages received from a client pipe.
                              /// </summary>
                              /// <param name="message">The byte message received.</param>
        public delegate void MessageReceivedHandler(byte[] message);
#pragma warning restore SA1201 // Elements should appear in the correct order

        /// <summary>
        /// Event is called whenever a message is received from a client pipe
        /// </summary>
        public event MessageReceivedHandler MessageReceived;

#pragma warning disable SA1201 // Elements should appear in the correct order
        /// <summary>
        /// Handles client disconnected messages.
        /// </summary>
        public delegate void ClientDisconnectedHandler();
#pragma warning restore SA1201 // Elements should appear in the correct order

        /// <summary>
        /// Event is called when a client pipe is severed.
        /// </summary>
        public event ClientDisconnectedHandler ClientDisconnected;

#pragma warning disable SA1201 // Elements should appear in the correct order
#pragma warning disable SA1400 // Access modifier should be declared
        const int BUFFER_SIZE = 4096;
#pragma warning restore SA1400 // Access modifier should be declared
#pragma warning restore SA1201 // Elements should appear in the correct order

        Thread listenThread;
#pragma warning disable SA1400 // Access modifier should be declared
        readonly List<Client> clients = new List<Client>();
#pragma warning restore SA1400 // Access modifier should be declared

        /// <summary>
        /// The total number of PipeClients connected to this server.
        /// </summary>
        public int TotalConnectedClients
        {
            get
            {
                lock (this.clients)
                {
                    return this.clients.Count;
                }
            }
        }

        /// <summary>
        /// The name of the pipe this server is connected to.
        /// </summary>
        public string PipeName { get; private set; }

        /// <summary>
        /// Is the server currently running.
        /// </summary>
        public bool Running { get; private set; }

        /// <summary>
        /// Starts the pipe server on a particular name.
        /// </summary>
        /// <param name="pipename">The name of the pipe.</param>
        public void Start(string pipename)
        {
            this.PipeName = pipename;

            // start the listening thread
            this.listenThread = new Thread(this.ListenForClients)
            {
                IsBackground = true,
            };

            this.listenThread.Start();

            this.Running = true;
        }

#pragma warning disable SA1400 // Access modifier should be declared
        void ListenForClients()
#pragma warning restore SA1400 // Access modifier should be declared
        {
#pragma warning disable SA1129 // Do not use default value type constructor
            SECURITY_DESCRIPTOR sd = new SECURITY_DESCRIPTOR();
#pragma warning restore SA1129 // Do not use default value type constructor

            // set the Security Descriptor to be completely permissive
            InitializeSecurityDescriptor(ref sd, SECURITY_DESCRIPTOR_REVISION);
            SetSecurityDescriptorDacl(ref sd, true, IntPtr.Zero, false);

            IntPtr ptrSD = Marshal.AllocCoTaskMem(Marshal.SizeOf(sd));
            Marshal.StructureToPtr(sd, ptrSD, false);

            SECURITY_ATTRIBUTES sa = new SECURITY_ATTRIBUTES
            {
                nLength = Marshal.SizeOf(sd),
                lpSecurityDescriptor = ptrSD,
                bInheritHandle = 1,
            };

            IntPtr ptrSA = Marshal.AllocCoTaskMem(Marshal.SizeOf(sa));
            Marshal.StructureToPtr(sa, ptrSA, false);

            while (true)
            {
                // Creates an instance of a named pipe for one client
                SafeFileHandle clientHandle =
                    CreateNamedPipe(
                        this.PipeName,

                        // DUPLEX | FILE_FLAG_OVERLAPPED = 0x00000003 | 0x40000000;
                        0x40000003,
                        0,
                        255,
                        BUFFER_SIZE,
                        BUFFER_SIZE,
                        0,
                        ptrSA);

                // could not create named pipe instance
                if (clientHandle.IsInvalid)
                {
                    continue;
                }

                int success = ConnectNamedPipe(clientHandle, IntPtr.Zero);

                // could not connect client
                if (success == 0)
                {
                    // close the handle, and wait for the next client
                    clientHandle.Close();
                    continue;
                }

                Client client = new Client
                {
                    handle = clientHandle,
                };

                lock (this.clients)
                {
                    this.clients.Add(client);
                }

                Thread readThread = new Thread(this.Read)
                {
                    IsBackground = true,
                };
                readThread.Start(client);
            }

            // free up the ptrs (never reached due to infinite loop)
#pragma warning disable CS0162 // Unreachable code detected
            Marshal.FreeCoTaskMem(ptrSD);
#pragma warning restore CS0162 // Unreachable code detected
            Marshal.FreeCoTaskMem(ptrSA);
        }

        void Read(object clientObj)
        {
            Client client = (Client)clientObj;
            client.stream = new FileStream(client.handle, FileAccess.ReadWrite, BUFFER_SIZE, true);
            byte[] buffer = new byte[BUFFER_SIZE];

            while (true)
            {
                int bytesRead = 0;

                using (MemoryStream ms = new MemoryStream())
                {
                    try
                    {
                        // read the total stream length
                        int totalSize = client.stream.Read(buffer, 0, 4);

                        // client has disconnected
                        if (totalSize == 0)
                        {
                            break;
                        }

                        totalSize = BitConverter.ToInt32(buffer, 0);

                        do
                        {
                            int numBytes = client.stream.Read(buffer, 0, Math.Min(totalSize - bytesRead, BUFFER_SIZE));

                            ms.Write(buffer, 0, numBytes);

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

            // the clients must be locked - otherwise "stream.Close()"
            // could be called while SendMessage(byte[]) is being called on another thread.
            // This leads to an IO error & several wasted days.
            lock (this.clients)
            {
                // clean up resources
                DisconnectNamedPipe(client.handle);
                client.stream.Close();
                client.handle.Close();

                this.clients.Remove(client);
            }

            // invoke the event, a client disconnected
            if (this.ClientDisconnected != null)
            {
                this.ClientDisconnected();
            }
        }

#pragma warning disable SA1202 // Elements should be ordered by access
        /// <summary>
        /// Sends a message to all connected clients.
        /// </summary>
        /// <param name="message">The message to send.</param>
        public void SendMessage(byte[] message)
#pragma warning restore SA1202 // Elements should be ordered by access
        {
            lock (this.clients)
            {
                // get the entire stream length
                byte[] messageLength = BitConverter.GetBytes(message.Length);

                foreach (Client client in this.clients)
                {
                    // length
                    client.stream.Write(messageLength, 0, 4);

                    // data
                    client.stream.Write(message, 0, message.Length);
                    client.stream.Flush();
                }
            }
        }
    }
}