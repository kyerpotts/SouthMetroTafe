// <copyright file="UserRepository.cs" company="PlaceholderCompany">
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
    /// Creates a User Repository object.
    /// </summary>
    internal class UserRepository
    {
        private List<User> users = new List<User>();

        /// <summary>
        /// Method used to add a user to the User Repository object.
        /// </summary>
        /// <param name="user">Variable which passes through User object.</param>
        public void AddUser(User user)
        {
            this.users.Add(user);
        }

        /// <summary>
        /// Method used to return an instance of a user object.
        /// </summary>
        /// <param name="userid">Variable used to return a matched user object from the Repository.</param>
        /// <returns>Returns a user object.</returns>
        public User GetUser(string userid)
        {
            return this.users.Single(u => u.UserId == userid);
        }

        /// <summary>
        /// Method used to check whether or not a user exists within the repository.
        /// </summary>
        /// <param name="userId">Variable used to pass through a matchable userID.</param>
        /// <returns>Returns true or false statement depending on whether a match has been found.</returns>
        public bool UserExists(string userId)
        {
            if (this.users.Any(cus => cus.UserId == userId))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
