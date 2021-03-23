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
            //Console.WriteLine("Greetings");
            string firstName;
            firstName = "Roger"; //A string is a sequence of chracters, must be enclosed within double quote marks

            string lastName = "Miller";

            string name = firstName + " " + lastName;

            //Console.WriteLine(name);

            char firstInitial = 'R'; //char must be a single character, and be enclosed within the single quotation mark instead of double quotes
            char lastInitial = 'M';

            //Console.WriteLine("{0} {1} is my friend", firstName, lastName);
            //Console.WriteLine("His initials are (" + firstInitial + lastInitial + ")");

            int age = 25;  //integer uses a 32 bit range
            byte numChildren = 3; //byte range from 0-255

            Console.WriteLine("{0} is {1} years old and he has {2} children", firstName, age, numChildren);
            
            float height = 1.85f;
            double bmi = 20.5;

            Console.WriteLine("He is {0} m tall and his bmi is {1}", height, bmi);

            decimal weeklyPay = 1020.90m;

            bool likesbeer = true;
            Console.WriteLine("He makes $" + weeklyPay + "per week");

            Console.WriteLine("It is {0} that he likes beer, and has " + numChildren + " children", likesbeer);

            // numChildren = 256;   //compiler error, exceeds max byte value

            const long PASSWORD = 123_456_789_123; // constants named with capitals, numbers won't change and are written with underscores and no spaces

            // PASSWORD = 4; //compiler error, cannot change constant variable

            int myInt = 10; //32 bits integral data type
            long myLong = 120; //64 bits inetgral data type
            float myFloat = 3.14f; //32 bits floating data type
            double myDouble = 6.7896758; //64 bits floating data type

            myLong = myInt;
            myFloat = myLong;

            //explicit type cast; typecasting allows transitional use between different types of variables
            myFloat = (float)myDouble;

            myLong = (long)myFloat;

            Console.WriteLine(myDouble);
            Console.WriteLine((int)myDouble);
            

        }
    }
}
