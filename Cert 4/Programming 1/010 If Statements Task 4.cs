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
            //Prompt for and test an even number

            Console.WriteLine("Enter an even number");

            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("{0} is correct", num);
            }
            else
            {
                Console.WriteLine("{0} is odd dum dum", num);
            }


        }

    }
}
