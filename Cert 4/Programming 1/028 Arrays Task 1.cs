using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Main
{
    class Program
    {
                
        static void Main(string[] args)
        {
            string[] colours = new string[5];
            for (int i=0; i<5; i++)
            {
                Console.WriteLine("Please enter a colour");
                colours[i] = Console.ReadLine();
            }

            for (int i=colours.Length - 1; i>=0; i--)
            {
                Console.WriteLine(colours[i]);
            }
        }
    }
}
