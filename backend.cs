using System;
using System.Collections.Generic;


namespace userShop.program
{
    public class bakeryShop
    {
          public double price {get; set;}
            
        ////////constructor
         public bakeryShop(double BreadPrice)
        {
        
         price = BreadPrice;
    }
        public double breadPrice(int items)
        {
        price =1;
         price = price * 3.33;
         int totalPrice = (int)Math.Round((price * items), 1);
         return totalPrice;

        }
   

    }

        public class pastryShop
    {
         public double price{ get; set; }
           
        //////////constructor
         public pastryShop(int pastryPrice)
        {
         price = pastryPrice;
         }
          
        
        public double pastryPrice(int items)
        {
            price =1;
             price = price * 1.66;
            int totalPrice = (int)Math.Round((price * items), 1);
            return totalPrice;

        }
    }
}
