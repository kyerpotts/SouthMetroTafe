using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30003389_AT1_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
           {
                Console.WriteLine("Enter 3 numbers");
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                int num3 = int.Parse(Console.ReadLine());

                if (num1 > num2 && num1 > num3)
                {
                    Console.WriteLine("{0} is largest", num1);
                    if (num2 > num3)
                    {
                        Console.WriteLine("{0} is smallest", num3);
                    }
                    else
                    {
                        Console.WriteLine("{0} is smallest", num2);
                    }
                }

                if (num2 > num1 && num2 > num3)
                {
                    Console.WriteLine("{0} is largest", num2);
                    if (num1 > num3)
                    {
                        Console.WriteLine("{0} is smallest", num3);
                    }
                    else
                    {
                        Console.WriteLine("{0} is smallest", num1);
                    }
                }

                if (num3 > num1 && num3 > num2)
                {
                    Console.WriteLine("{0} is largest", num3);
                    if (num1 > num2)
                    {
                        Console.WriteLine("{0} is smallest", num2);
                    }
                    else
                    {
                        Console.WriteLine("{0} is smallest", num1);
                    }
                }
            }
        }
    }

}
