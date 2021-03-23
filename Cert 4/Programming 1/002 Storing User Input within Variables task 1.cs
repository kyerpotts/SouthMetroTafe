using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming1
{
    class Program
    {
        static void Main(string[] args)
        {
            // prompt user for first name and last name, then output in for last name first name

            Console.WriteLine("Enter your first name");
                string firstName = Console.ReadLine();

            Console.WriteLine("Enter your second name");
                string secondName = Console.ReadLine();

            Console.WriteLine(secondName + ", " + firstName);


        }
    }
}
