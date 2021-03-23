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
            int choice = 4;

            switch (choice)
            {
                case 0:
                    Console.WriteLine("Monday");
                    break;
                case 1:
                    Console.WriteLine("Tuesday");
                    break;
                case 2:
                    Console.WriteLine("Wednesday");
                    break;
                case 3:
                    Console.WriteLine("Thursday");
                    break;
                case 4:
                    Console.WriteLine("Friday");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
        }

    }
}
