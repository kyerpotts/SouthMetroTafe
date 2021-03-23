using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Main
{
    class Program
    {
        static int CityName(string city1, string city2, string city3)
        {
            int CityName = city1.Length;
            if(city2.Length>CityName)
            {
                CityName = city2.Length;
            }
            if(city3.Length>CityName)
            {
                CityName = city3.Length;
            }
            return CityName;
        }
       

        static void Main(string[] args)
        {
            int longest = CityName("Delaware", "Perth", "London");
            Console.WriteLine("Longest string is " + longest + " chars");
            
        }
    }
}
