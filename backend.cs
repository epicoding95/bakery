using System;
using System.Collections.Generic;


namespace userShop.program
{
    class bakeryShop
    {
          
          private double _price{ get; set; }
            public bakeryShop()
            {
            _price = 0;
            }
        ////////constructor
         public bakeryShop(double BreadPrice)
        {
        
         _price = BreadPrice;
    }
        public double breadPrice(int items2)
        {
         double price = getPrice() * .66;
         double totalPrice = price * items2;
         return totalPrice;

        }
        public double getPrice()
        {
            return _price;
        }

    }

   class pastryShop
    {
          
          private double _price{ get; set; }
            public pastryShop()
            {
           
            _price = 1;
           

            }

         public pastryShop(int pastryPrice)
        {
        
         _price = pastryPrice;
         }
          public double getPrice()
        {
            return _price;
        }

        public double pastryPrice(int items)
        {
            double price = getPrice() * 2.66;
            double totalPrice = price * items;
            return totalPrice;

        }
      
        //  public checkOut()
        // {
        //     Console.Clear();
        //      Console.WriteLine("Your total is" + newPastryPrice + newBreadPrice + ".");
        // }

    }


}
