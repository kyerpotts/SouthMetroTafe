using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30003389_AT1_Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sentinel = true;

            Console.WriteLine("Enter a maximum value");

            int counter = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a minimum value");

            int minValue = int.Parse(Console.ReadLine());

            while (sentinel == true)
            {
                if (counter >= minValue)
                {
                    Console.WriteLine(counter);
                    counter = --counter;
                }
                else
                {
                    sentinel = false;
                }
            }
        }
    }
}
