using System;
using System.Collections.Generic;
using userShop.program;

namespace program
{
    class program
    {
        public static void Main()
        {
             Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
          ////sets up the inital prompt
             bakeryShop newBakery = new bakeryShop(1);
             pastryShop newPastry = new pastryShop(1);
           Console.WriteLine("\nHello! welcome to Kelars bakery.");
           Console.WriteLine("We have the best bread and pastries in town!");
           Console.WriteLine("Bread: Buy 2, get 1 free. A single loaf costs $5.");
           Console.WriteLine("Pastry: Buy 1 for $2 or 3 for $5.");
           Console.WriteLine("-------------------------------------");
           Console.WriteLine("1. How many pastries you like to buy?");
            string pastryAnswer = Console.ReadLine();
            int newPastryAnswer = int.Parse(pastryAnswer);
            ////////cant figure out how to get this line to work.
            // double newPastryAnswer2 = newPastryAnswer + Math.Round(1.1, 1);
           
           

///////////how many pastries the user wants to buy
        if(newPastryAnswer == 0)
        {
           Console.WriteLine("You're missing out!");
        }else if(newPastryAnswer == 1)
        {
            Console.WriteLine("Your total for your pastry is $2");
        }else if (newPastryAnswer == 2)
        {
            Console.WriteLine("Your total for your pastry is $4");
        }
        else if (newPastryAnswer >= 3)
        {
           Console.WriteLine("Your total for your pastries is " + newPastry.pastryPrice(newPastryAnswer));
        }else
        {
            Console.WriteLine("please enter a valid number");
        }

        Console.WriteLine("2. How many slices of bread would you like to buy? ");

        //////final total is how many items the customer bought
        /////// final price for the items bought 
             string breadAnswer = Console.ReadLine();
             int newBreadAnswer = int.Parse(breadAnswer);
           
        int itemTotal = newPastryAnswer + newBreadAnswer;
        double moneyTotal = newPastry.pastryPrice(newPastryAnswer) + newBakery.breadPrice(newBreadAnswer);


        if(newBreadAnswer == 0)
        {
           Console.WriteLine("You're missing out!");
           Main();
        }else if(newBreadAnswer == 1)
        {
            Console.WriteLine("Your total for your bread is $5");
        }else if (newBreadAnswer == 2)
        {
            Console.WriteLine("Your total for your bread is $10 but you get a third loaf for free!");
        }else if (newBreadAnswer >= 3)
        {
            Console.WriteLine("your total for your bread is " + newBakery.breadPrice(newBreadAnswer));
        }else
        {
            Console.WriteLine("Please enter a valid number");
        }

        Console.WriteLine("would you like to go back to the main menu or checkout?");
        string Decide = Console.ReadLine();

        if (Decide == "checkout")
        {
            Console.WriteLine("You had a combined total of "+ itemTotal +" items today"  +  " with a total price of " + moneyTotal);
        }else
        {
            Main();
        }

        }
    }
}