// Nick Ling

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise03
{
    //  This class represents the purchase price of something.
    //  In our software project, we will use it to represent the price of
    //  one can of soda.
    class PurchasePrice
    {
        int price = 0;
        decimal priceDecimal = 0.0M;

        // This constructor sets the purchase price to zero
        public PurchasePrice()
        {
            // don't define anything. set to 
        }
        // This constructor allows a new purchase price to be set by the user
        public PurchasePrice(int initialPrice)
        {
            Price = initialPrice;
        }

        public PurchasePrice(decimal initialPrice)
        {
            PriceDecimal = initialPrice;
        }
        //  This property gets the value the purchase price.
        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public decimal PriceDecimal
        {
            get
            {
                return priceDecimal;
            }
            set
            {
                priceDecimal = value;
            }
        }
    } //end PurchasePrice
}