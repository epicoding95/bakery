using System;
using System.Collections.Generic;
using userShop.program;

namespace program
{
    class program
    {
        public static void Main()
        {
             bakeryShop newBakery = new bakeryShop(0);
             pastryShop newPastry = new pastryShop(0);
           Console.WriteLine("\nHello! welcome to Kelars bakery.");
           Console.WriteLine("We have the best bread and pastries in town!");
           Console.WriteLine("Bread: Buy 2, get 1 free. A single loaf costs $5.");
           Console.WriteLine("Pastry: Buy 1 for $2 or 3 for $5.");
           Console.WriteLine("-------------------------------------");
           Console.WriteLine("1. How many pastries you like to buy?");
            string pastryAnswer = Console.ReadLine();
            int newPastryPrice = int.Parse(pastryAnswer);
           


        if(newPastryPrice == 0)
        {
           Console.WriteLine("You're missing out!");

        }else if(newPastryPrice == 1)
        {
            Console.WriteLine("Your total for your pastry is $2");

        }else if (newPastryPrice == 2)
        {
            Console.WriteLine("Your total for your pastry is $4");

        }
        
        else if (newPastryPrice >= 3)
        {
           Console.WriteLine(newBakery.pastryPrice());
        }


    
        Console.WriteLine("2. How many slices of bread would you like to buy? ");
             string breadAnswer = Console.ReadLine();
             int newBreadPrice = int.Parse(breadAnswer);


        if(newBreadPrice == 0)
        {
           Console.WriteLine("You're missing out!");
           Main();

        }else if(newBreadPrice == 1)
        {
            Console.WriteLine("Your total for your bread is $5");

        }else if (newBreadPrice == 2)
        {
            Console.WriteLine("Your total for your bread is $10 but you get a third loaf for free!");

        }

        // else(newBreadPrice >= 3)
        // {
        //     newBakery.breadPrice();
        // }

    }
}
}