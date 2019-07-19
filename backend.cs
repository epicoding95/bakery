using System;
using System.Collections.Generic;


namespace userShop.program
{
    class bakeryShop
    {
          
          private int _price{ get; set; }
            public bakeryShop()
            {
           
            _price = 0;
           

            }

         public bakeryShop(int breadPrice)
        {
        
         _price = breadPrice;
    }
        // public void breadprice()
        // {
        // newBreadPrice *3.33;

        // }
        public int getPrice()
        {
            return _price;
        }

    }

   class pastryShop
    {
          
          private int _price{ get; set; }
            public pastryShop()
            {
           
            _price = 0;
           

            }

         public pastryShop(int pastryPrice)
        {
        
         _price = pastryPrice;
         }
        // public  pastryPrice(NewPastryPrice)
        // {
        //  return (NewPastryPrice* 1.66);

        // }
        public int getPrice()
        {
            return _price;
        }

        //  public checkOut()
        // {
        //     Console.Clear();
        //      Console.WriteLine("Your total is" + newPastryPrice + newBreadPrice + ".");
        // }

    }


}
