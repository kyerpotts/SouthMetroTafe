using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Main
{
    class Program
    {
        //Method called Largest that takes an array of ints as a parameter
        //and returns an int (the largest number in the parameter)
        static int Largest(int[] nums)
        {
            int largest = nums[0];
            
            for (int i=1; i<nums.Length; i++)
            {
                if (nums[i] > largest)
                {
                    largest = nums[i];
                }
            }
            return largest;
        }
        static void Main(string[] args)
        {
            //Declare an array of ints
            //Call the Largest method and pass in the integer array as an argument
            //Display the result
            int[] numbers = { 5,3,24,55};
            int biggest = Largest(numbers);
            Console.WriteLine(biggest);

        }
    }
}
