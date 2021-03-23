using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3000889_AT1_Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a divisor");

            int divisor = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number you want divisibles of");

            int numLoops = int.Parse(Console.ReadLine());
            int result;

            if (numLoops >= divisor)
                for (int i = 1; i <= numLoops; i++)
                {
                    result = (i % divisor);
                    if (result == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                    
        }
    }
}
