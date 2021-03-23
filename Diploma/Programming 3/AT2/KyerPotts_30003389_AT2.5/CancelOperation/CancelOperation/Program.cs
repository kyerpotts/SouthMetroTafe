using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CancelOperation
{
    class Program
    {
        static void Main(string[] args)
        {

            ConsoleKeyInfo cki;

            Console.Clear();

            Console.CancelKeyPress += new ConsoleCancelEventHandler(myHandler);

            //while loop continues until requested key is pressed or cancel key shortcut is pressed
            while (true)
            {
                Console.WriteLine("This application will read key input and determine whether the user wants to close by pressing the 'F' key");
                Console.WriteLine("Or interrupt the operation by pressing the CTRL+C shortcut");
                Console.WriteLine("If the process is not interrupted by pressing the 'F' key, the operation will continue to laugh at you indefinitely.");
                Console.WriteLine("Please press the 'F' key to avoid being the subject of this programs ridicule");
                Thread.Sleep(5000);
                Console.WriteLine("For humilities sake, stop it before it begins!");
                Thread.Sleep(5000);
                Console.WriteLine("Okay, I warned you...");
                Thread.Sleep(5000);
                Console.WriteLine(LaughingGas());

                bool laugh = true;

                //Loop reads and displays key input, if keys requested by the program are pressed, laugh variable is set to false and breaks operation of the loop
                while (laugh)
                {
                    cki = Console.ReadKey(true);
                    Console.WriteLine(LaughingGas());
                    Console.WriteLine($" Key pressed: {cki.Key}\n");
                    //if statement to determine if operation shutdown key "F" has been pressed, breaks while loop if true
                    if (cki.Key == ConsoleKey.F)
                    {
                        laugh = false;
                        Console.WriteLine("There you go chief you did it!");
                        Thread.Sleep(2000);
                        break;
                    }
                }
                break;
            }
        }

        //handler for cancel key operation
        protected static void myHandler(object sender, ConsoleCancelEventArgs args)
        {
            Console.WriteLine("\n Operation has been interrupted.");

            Console.WriteLine($" Key pressed: {args.SpecialKey}");

            args.Cancel = true;
        }

        //Method used to simulate program laughing at the user within the while loop
        protected static string LaughingGas()
        {
            Random rand = new Random();
            string laughCycle = "HA";
            for (int i = 0; i < rand.Next(3,15); i++)
            {
                laughCycle = (laughCycle + " HA"); 
            }
            return laughCycle;
        }
    }
}
