// <copyright file="PasswordManager.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PipeServer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Class used to create Password Manager objects.
    /// </summary>
    public class PasswordManager
    {
        private HashComputer hashComputer = new HashComputer();

        /// <summary>
        /// Method used to generate a password hash.
        /// </summary>
        /// <param name="plainTextPassword">Variable used to pass through the plaintext password.</param>
        /// <param name="salt">Variable used to pass through the salt string.</param>
        /// <returns>Returns a generated password hash string.</returns>
        public string GeneratePasswordHash(string plainTextPassword, out string salt)
        {
            salt = SaltGenerator.GetSaltString();

            string finalString = plainTextPassword + salt;

            return this.hashComputer.GetPasswordHashAndSalt(finalString);
        }

        /// <summary>
        /// Method used to detect whether or not passwords match.
        /// </summary>
        /// <param name="password">Variable which passes through the password to be matched.</param>
        /// <param name="salt">Variable which passes through the salt to be matched.</param>
        /// <param name="hash">Variable which passes through the password hash.</param>
        /// <returns>Returns a true or false statement depending on whether the password has matched correctly.</returns>
        public bool IsPasswordMatch(string password, string salt, string hash)
        {
            string finalString = password + salt;
            return hash == this.hashComputer.GetPasswordHashAndSalt(finalString);
        }
    }
}
