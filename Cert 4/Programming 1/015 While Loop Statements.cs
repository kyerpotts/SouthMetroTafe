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
            string password = "secret01";
            string attempt;

            Console.WriteLine("Enter the password");
            attempt = Console.ReadLine();

            while(attempt != password)//while runs 0 or more times, if password is entered first timethe while loop is ignored.
            {
                Console.WriteLine("Incorrect, please try again");
                attempt = Console.ReadLine();
            }
            Console.WriteLine("Access Granted");
        }   
        

    }
}
