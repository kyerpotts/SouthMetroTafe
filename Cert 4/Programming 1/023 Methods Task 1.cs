using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Main
{
    class Program
    {
        static void CountDown()
        {
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            CountDown();
        }
    }
}
