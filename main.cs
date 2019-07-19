using System;
using System.Collections.Generic;
using userShop;

namespace program
{
    class program
    {
        public static void Main()
        {
            
           Console.WriteLine("\nHello! welcome to Kelars bakery.");
           Console.WriteLine("We have the best bread and pastries in town!");
           Console.WriteLine("Bread: Buy 2, get 1 free. A single loaf costs $5.");
           Console.WriteLine("Pastry: Buy 1 for $2 or 3 for $5.");
           Console.WriteLine("-------------------------------------");
           Console.WriteLine("1. How many pastries you like to buy?");
            string pastryAnswer = Console.ReadLine();
             Console.WriteLine("2. How many slices of bread would you like to buy? ");
             string breadAnswer = Console.ReadLine();
        }
    }
}