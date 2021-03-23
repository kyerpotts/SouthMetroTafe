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
            //prompt the user to enter age, output will be "in 10 years you will be x"

            Console.WriteLine("Enter your age");

            int age = int.Parse(Console.ReadLine());

            age += 10;

            Console.WriteLine("In 10 years you will be " + age);


            //prompt user for a number, output will be the cube of that number

            Console.WriteLine("Enter a number");

            int num = int.Parse(Console.ReadLine());
            
            Console.WriteLine("The cube of " + num + " is " + (num * num) * num);
        }
    }
}
