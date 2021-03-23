using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Main
{
    class Program
    {
        static void PrintStrings(string[] strings)
        {
            for(int i = 0; i<strings.Length; i++)
            {
                Console.WriteLine(strings[i]);
            }
        }
        
        static void Main(string[] args)
        {
            int[] nums = new int[5];
            nums[0] = 10;
            nums[1] = 20;
            nums[2] = 30;
            nums[3] = 40;
            nums[4] = 50;
            // nums [5] = 60; compiler error, index outside bounds of array

            for (int i = 0; i< nums.Length; i++)
            {
                Console.WriteLine("Nums[{0}] = {1}", i, nums[i]);
            }

            string[] cities = { "Perth", "Adelaide", "Sydney", "Hobart" };
            PrintStrings(cities);

            Console.WriteLine("Here they are again");
            foreach(string s in cities)
            {
                Console.WriteLine(s);
            }
        }
    }
}
