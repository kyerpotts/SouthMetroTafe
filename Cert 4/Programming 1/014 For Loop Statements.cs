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
           for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Loop number {0}", i);
            }

           for(int i = 10; i >= 1; i--)
            {
                Console.WriteLine("Countdown: {0}", i);
            }
        }

    }
}
