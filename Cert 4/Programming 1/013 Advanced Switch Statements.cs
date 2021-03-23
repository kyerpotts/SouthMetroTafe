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
            string product = "doll";
            double price;
            switch (product)
            {
                case "bike":
                    price = 124.56;
                    break;
                case "swing":
                    price = 150.20;
                    break;
                case "water pistol":
                    price = 9.50;
                    break;
                case "doll":
                case "bear":
                    price = 22.50;
                    break;
                default:
                    price = -1;
                    break;
            }
            if(price != -1)
            {
                Console.WriteLine("Product: {0}, Price: {1}", product, price);
            }
            else
            {
                Console.WriteLine("Product not found");
            }
        }

    }
}
