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
            //Prompt for and test the number 6 or 9
            /*
            Console.WriteLine("Enter either a 6 or a 9");

            int num = int.Parse(Console.ReadLine());

            if (num == 6 || num == 9)
            {
                Console.WriteLine("{0} is correct", num);
            }
            else
            {
                Console.WriteLine("{0} is wrong dum dum", num);
            }
            */
            Console.WriteLine("Enter either a 6 or a 9");

            int num = int.Parse(Console.ReadLine());

            if (num != 6 && num != 9)
            {
                Console.WriteLine("{0} is wrong dum dum", num);
            }
            else
            {
                Console.WriteLine("{0} is correct", num);
            }

        }

    }
}
