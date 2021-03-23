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
            //Prompt for and read in a number between 1 and 10 inclusive

            Console.WriteLine("Enter a number between 1 and 10");

            int num = int.Parse(Console.ReadLine());

            if (num >= 1 && num <= 10)
            {
                Console.WriteLine("That is a correct input");
            }
            else
            {
                Console.WriteLine("That is an incorrect input");
            }
        }

    }
}
