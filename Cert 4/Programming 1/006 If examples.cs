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
            int width = 5;
            int length = 5;

            if(width > 3)
            {
                Console.WriteLine("Shape is wide"); //boolean expression key operators are > greater than, < less than >=gt or equal, <=lt or equal, ==true equal,!negation, !=inequality
                                                    //compund expressions: && and, || or

            }
            if (length > 4)
            {
                Console.WriteLine("Shape is long");
            }
            if(width > 3 && length > 4)
            {
                Console.WriteLine("Shape is wide and also long");
            }
            if(length == width)
            {
                Console.WriteLine("Shape is a square");
            }
            else //else block is optional
            {
                Console.WriteLine("Shape is a rectangle");
            }

            int area = length * width;

            if(area <10)
            {
                Console.WriteLine("Shape is small");
            }
            else if (area < 20)
            {
                Console.WriteLine("Shape is medium size");
            }
            else if(area<30)
            {
                Console.WriteLine("Shape is large");
            }
            else //else block at the end of else ladder is not a requirement
            {
                Console.WriteLine("Shape is extra large");
            }
        }

    }
}
