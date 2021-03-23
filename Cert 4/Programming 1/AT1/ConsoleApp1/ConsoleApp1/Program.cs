using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int divisor = int.Parse(Console.ReadLine());
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
