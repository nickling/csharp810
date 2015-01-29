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
        // Fields
        decimal _price = 0.0M;

        // This constructor sets the purchase price to zero
        public PurchasePrice()
        {
            // do not need to set anything here.
        }
        // This constructor allows a new purchase price to be set by the user
        public PurchasePrice(int initialPrice)
        {
            Price = (decimal)initialPrice;
        }

        public PurchasePrice(decimal initialPrice)
        {
            Price = initialPrice;
        }
        //  This property gets the value the purchase price. We changed the interface to return a decimal.
        public decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }
    } //end PurchasePrice
}