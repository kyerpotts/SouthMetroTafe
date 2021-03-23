using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt for a user name and a password, and then test whether or not the input is a correct username/password

            Console.WriteLine("Enter your username");

            string username = Console.ReadLine();

            Console.WriteLine("Enter your password");

            string password = Console.ReadLine();

            


            if (username == "bob" && password == "abc123")
            {
                Console.WriteLine("Welcome Bob");
            }
            else if (username == "sue" && password == "cutecat")
            {
                Console.WriteLine("Welcome Sue");
            }
            else
            {
                Console.WriteLine("Access Denied Cretin");
            }
        }

    }
}
