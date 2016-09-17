using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class GroceryStore
    {
       /* <summary part1> 
       Oskar Enmalm 2016.09.15
        This program is for Assignment 1 in Programming using C#.
        It take the price of the product and the quantity
        and from this applies the appropriate tax amount and the net price to be paid

    NB: The tax rates given are Swedish.
        Price inputs are seperated with a "," instead of "." as per the SE custom
        </summary part1>
        */
        static void Main(string[] args)
        {
            Console.Title = ("Oskar's Fireworks, Liquor and Smoke Shack");
            Product product = new Product(); //object created
            product.Start(); //call the start

            Console.WriteLine("Press any key to exit!");
            Console.ReadKey();
        }
    }
}
;