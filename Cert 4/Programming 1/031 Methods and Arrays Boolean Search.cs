using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Main
{
    class Program
    {
        static bool ContainsString(string[] strings, string search)
        {

            for(int i = 0; i<strings.Length; i++)
            {

                if(strings[i] == search)
                {

                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {

            string[] names = { "Jack", "Bob", "Harry", "Julien" };
            if(ContainsString(names, "Julien"))
            {
                Console.WriteLine("Found Julien");
            }
            else
            {
                Console.WriteLine("Jullien not found in array");
            }
        }
    }
}
