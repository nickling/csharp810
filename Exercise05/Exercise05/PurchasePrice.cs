// Nick Ling

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise05
{
    //  This class represents the purchase price of something.
    //  In our software project, we will use it to represent the price of
    //  one can of soda.
    class PurchasePrice
    {
        // Fields
        decimal _price = 0M;

        // This constructor sets the purchase price to zero
        public PurchasePrice()
        {
            // do not need to set anything here.
        }
        // This constructor allows a new purchase price to be set by the user
        public PurchasePrice(int initialPrice)
        {
            PriceDecimal = (decimal)initialPrice / 100M;
        }

        public PurchasePrice(decimal initialPrice)
        {
            PriceDecimal = initialPrice;
        }

        //  This property gets and sets the value the purchase price.
        [Obsolete("Use the decimal version of this property instead", false)]
        public int Price
        {
            get
            {
                return (int)(_price * 100);
            }
        }
        
        //  This property gets the value the purchase price. We changed the interface to return a decimal.
        public decimal PriceDecimal
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