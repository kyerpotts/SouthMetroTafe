// <copyright file="User.cs" company="PlaceholderCompany">
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
    /// Class that creates a user object.
    /// </summary>
    internal class User
    {
        /// <summary>
        /// Gets or sets UserId.
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets PasswordHash.
        /// </summary>
        public string PasswordHash { get; set; }

        /// <summary>
        /// Gets or sets salt.
        /// </summary>
        public string Salt { get; set; }
    }
}
