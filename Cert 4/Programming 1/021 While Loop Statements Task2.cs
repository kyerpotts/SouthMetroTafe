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
            // Prompt the user to guess your secret number between 1 and 100, give an unlimited number of tries.

            int secretnum = 54;
            
            Console.WriteLine("Try and guess my secret number between 1 and 100");

            int attempt = int.Parse(Console.ReadLine());
            int tries = 1;
            while (attempt != secretnum)
            {
                
                Console.WriteLine("That is not my secret number, try again");
                if (attempt < secretnum)
                {
                    Console.WriteLine("My secret number is higher than {0}", attempt);
                        attempt = int.Parse(Console.ReadLine());
                        tries++;
                }
                else
                {
                    Console.WriteLine("My secret number is lower than {0}", attempt);
                        attempt = int.Parse(Console.ReadLine());
                        tries++;
                }
                  
                
            }
            Console.WriteLine("That was the right number, it took you " + tries + " tries");
        


            

            
         
        }   
        

    }
}
