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
            //prompt the user for their name, display the name a user entered number of times, surrounded by stars

            
            int num;
            int sum = 0;

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter a number");
                num = int.Parse(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine("The sum is " + sum);
        }   
        

    }
}
