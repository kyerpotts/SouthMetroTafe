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
            //prompt the user for their name, display the name 10 times, surrounded by stars

            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            for(int i = 0; i< 10; i++)
            {
                Console.WriteLine("***" + name + "***", i);
            }

        }   
        

    }
}
