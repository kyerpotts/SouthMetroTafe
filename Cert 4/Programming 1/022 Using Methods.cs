using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_2
{
    class Program
    {
        static void Greetings()
        {
            Console.WriteLine("Greetings");//program execution egins in the main method, it will not begin with this method
        }

        static void ShowMessage(string msg)//this is a formal parameter
        {
            Console.WriteLine(msg);
        }

        static void Sum(byte a, int b)// void methods do not return a value
        {
            int sum = a + b;
            Console.WriteLine("The sum of {0} and {1} is {2}", a, b, sum);
        }

        static double RoughPI()
        {
            return 3.14159;
        }

        static double CalculateArea(double radius)
        {
            double area = RoughPI() * radius * radius;
            return area;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("In main");
            Greetings();//calls the Greetings method into the main method
            Console.WriteLine("Back in main");
            ShowMessage("Hellow world");//within this line it is back to an argument, and is no longer a parameter
            Sum(5, 6);
            double pi = RoughPI();
            Console.WriteLine("Pi is roughly " + pi);

            Console.WriteLine("The area of a circle of radius 3 is " +
                CalculateArea(3));
        }   
        

    }
}
