using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30003389_AT1_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a fire level");

            int fireLevel = int.Parse(Console.ReadLine());
            switch(fireLevel)
            {
                case 1:
                    Console.WriteLine("Green: Low-Moderate");
                    break;
                case 2:
                    Console.WriteLine("Blue: High");
                    break;
                case 3:
                    Console.WriteLine("Yellow: Very High");
                    break;
                case 4:
                    Console.WriteLine("Orange: Severe");
                    break;
                case 5:
                    Console.WriteLine("Red: Extreme");
                    break;
                case 6:
                    Console.WriteLine("Red-Black: Catastrophic");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;


            }
        }
    }
}
