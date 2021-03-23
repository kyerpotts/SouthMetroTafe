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
            string response = "";
            int num = 1;

            do //Do while runs at least once
            {
                Console.WriteLine("The square of {0} is {1}", num, num * num);
                Console.WriteLine("See another square (y/n)?");
                response = Console.ReadLine();
                if (response != "y" && response != "n")
                {
                    Console.WriteLine("Invalid response");
                }
                num++;

            } while (response == "y");
        }   
        

    }
}
