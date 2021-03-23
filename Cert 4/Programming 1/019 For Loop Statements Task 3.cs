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
            //Read 5 numbers ina loop, for each number state whether it is odd or even

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter a number");
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.WriteLine("That number is even");
                }
                else
                {
                    Console.WriteLine("That number is odd");
                }
            }
         
        }   
        

    }
}
