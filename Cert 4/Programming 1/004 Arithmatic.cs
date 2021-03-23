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
            int firstNum = 12;
            int secondNum = 5;

            int sum = firstNum + secondNum;
            int difference = firstNum - secondNum; //expressions are the operands and the operator together
            int product = firstNum * secondNum;
            int quotient = firstNum / secondNum;
            int remainder = firstNum % secondNum;

            Console.WriteLine("Sum " + sum);
            Console.WriteLine("Difference " + difference);
            Console.WriteLine("Product " + product);
            Console.WriteLine("Quotient " + quotient);
            Console.WriteLine("Remainder " + remainder);

            double mon, tue, wed, average; //can use commas to declare multiple variables of all one type within a single line

            mon = 2;
            tue = 5;
            wed = 3;

            average = (mon + tue + wed) / 3;

            Console.WriteLine("Average {0:N2}" + average);

            int i = 0;
            i++; //++ operator increments a variable
            Console.WriteLine(i);

            i--; //-- operator decrements a variable
            Console.WriteLine(i);

            --i; //operator placed at the end of the variable determines whether or not it uses the value before or after the operator computates [--i] is before, [i--] is after

            //compund assignment operators

            int x = 10;

            x += 5; //same as x = x + 5, will work with most basic operators

            Console.WriteLine("x=" + 5);


            average = (2 + 5 + 3) / 3; //will work out the interger values before assigning the value to the type of the variable
            //fraction part lost before assignment to int, because operands are all int literals

            average = ((double)2 + 5 + 3) / 3; //typecasting one of the valeus to a double causing the operands to be computed as doubles within the equation

            average = (2 + 5 + 3) / 3.0; //changing one of the values into a decminal will change then entire output of all ofthe numbers to be computed with decminals

            Console.WriteLine("Average? " + average);

            byte b1 = 5;
            byte b2 = 6;
            byte ans = (byte) (b1 + b2); //bytes are automatically promoted to ints within an expression
        }
    }
}
