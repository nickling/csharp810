// Nick Ling

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    class PurchasePrice
    {
        // fields
        //private int purchasePrice;

        // This constructor sets the purchase price to zero
        public PurchasePrice()
        {
            Price = 0;
        }
        // This constructor allows a new purchase price to be set by the user
        public PurchasePrice(int initialPrice)
        {
            Price = initialPrice;
        }
        // This property gets and sets the value the purchase price.
        public int Price
        {
            get;
            set;
            // this get/set is only necessary if we are using a private field: purchasePrice
            //get
            //{
            //    return purchasePrice;
            //}
            //set
            //{
            //    purchasePrice = value;
            //}
        }
    }

}
