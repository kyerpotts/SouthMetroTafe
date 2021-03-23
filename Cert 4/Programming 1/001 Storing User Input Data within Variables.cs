using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name;

            name = Console.ReadLine(); //parentheses required if an "argument" is needed, not needed with the ReadLine method

            Console.WriteLine("Hello " + name);

            Console.WriteLine("Enter your age");


            int age = int.Parse(Console.ReadLine()); //used to return an interger value

            Console.WriteLine("Enter PI to as many digits as you know");
            double pi = double.Parse(Console.ReadLine()); //used to return a float value

            Console.WriteLine("Age" + age);
            Console.WriteLine("PI" + pi);





        }
    }
}
