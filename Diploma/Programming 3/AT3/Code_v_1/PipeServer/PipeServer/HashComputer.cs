// <copyright file="HashComputer.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PipeServer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Class is used to create a HashComputer object.
    /// </summary>
    internal class HashComputer
    {
        /// <summary>
        /// Method used to hash and salt passwords.
        /// </summary>
        /// <param name="message">Variable passes through password data.</param>
        /// <returns>Returns a hashed string.</returns>
        public string GetPasswordHashAndSalt(string message)
        {
            // Let us use SHA256 algorithm to
            // generate the hash from this salted password
            SHA256 sha = new SHA256CryptoServiceProvider();
            byte[] dataBytes = Utility.GetBytes(message);
            byte[] resultBytes = sha.ComputeHash(dataBytes);

            // return the hash string to the caller
            return Utility.GetString(resultBytes);
        }
    }
}
