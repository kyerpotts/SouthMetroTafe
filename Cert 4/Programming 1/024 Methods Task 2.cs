using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Main
{
    class Program
    {
        static void PrintChars(char c, int numTimes)
        {
            for (int i = 0; numTimes < 5; i++)
                Console.Write(c);
        }
        Console.WriteLine();
        
        static void Main(string[] args)
        {
        PrintChars('*', 5);

        }
    }
}
