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
            //prompt the user for their name, display the name a user entered number of times, surrounded by stars

            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the amount of tiems you want your name to be shown");
            int num = int.Parse(Console.ReadLine());

            for(int i = 0; i < num; i++)
            {
                Console.WriteLine("***" + name + "***", i);
            }

        }   
        

    }
}
