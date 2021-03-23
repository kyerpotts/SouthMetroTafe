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
            //Prompt for a number that is larger than 5. Read the number in, test it and output a suitable message
            Console.WriteLine("Enter a number");

            int num = int.Parse(Console.ReadLine());

            if (num > 3)
            {
                Console.WriteLine("The number you entered was larger than 3 ");
            }
            else
            {
                Console.WriteLine("The number you entered was less than 3");
            }

            
        }

    }
}
