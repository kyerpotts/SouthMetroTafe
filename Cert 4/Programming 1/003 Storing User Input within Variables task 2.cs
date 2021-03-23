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
            // Prompt user for an interger, then prompt for a floating point number, then output an ordered pair

            Console.WriteLine("Enter a whole number");
                int wholeNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a decimal number");
                double decimalNumber = double.Parse(Console.ReadLine()); //could use float type within this code, however it will be less precise, using the decimal type will be far more precise but will use a differing numerical system.

            Console.WriteLine(wholeNumber + ", " + decimalNumber);
            //Console.WriteLine("{0}, {1}", wholeNumber, decimalNumber); could also use this format 
        }
    }
}
