using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Main
{
    class Program
    {
        static bool IsNegative(int num)
        {
            if(num<0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a negative number");
            int num = int.Parse(Console.ReadLine());

            while (!IsNegative(num))//! operater flips boolean could aslo have been while (IsNegative(num) == false)
            {
                Console.WriteLine("{0} is not negative", num);
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Input Accepted");

        }
    }
}
