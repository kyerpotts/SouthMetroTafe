using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Main
{
    class Program
    {
        //Method called SumArray - takes a single parameter
        //which is an array of int
        //Returns and int (the sum of the numbers in the array)
        static int SumArray(int[] nums)
        {
            //return the sum
            int sum = 0;
            for (int i = 0;i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }

        static void Main(string[] args)
        {
            //create an initialise an array of ints
            //call the SumArray method, assign the return value
            //to a variable. Then display the variable.
            int[] myNumbers = { 2, 5, 9, 10 };
            int sum = SumArray(myNumbers);
            Console.WriteLine("Sum: " + sum);
            

        }
    }
}
