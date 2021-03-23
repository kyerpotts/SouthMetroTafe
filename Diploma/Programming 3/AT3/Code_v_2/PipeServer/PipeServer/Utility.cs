// <copyright file="Utility.cs" company="PlaceholderCompany">
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
    /// Class that creates a Utility object.
    /// </summary>
    internal static class Utility
    {
        /// <summary>
        /// Method used to convert a string to byte[].
        /// </summary>
        /// <param name="str">Variable which contains a string to be converted.</param>
        /// <returns>Returns a byte[] containing the converted string data.</returns>
        public static byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        /// <summary>
        /// Method used to convert a byte[] to a string.
        /// </summary>
        /// <param name="bytes">Variable containing the byte[] to be converted.</param>
        /// <returns>Returns a string containing the converted byte[] data.</returns>
        public static string GetString(byte[] bytes)
        {
            char[] chars = new char[bytes.Length / sizeof(char)];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }
    }
}
