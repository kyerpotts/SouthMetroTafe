using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeServer
{
    class UserRepository
    {
        List<User> users = new List<User>();

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public User GetUser(string userid)
        {
            return users.Single(u => u.UserId == userid);
        }

        public bool UserExists(string userId)
        {
            if(users.Any(cus => cus.UserId == userId))
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
