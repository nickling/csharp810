using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise05
{
    class CoinBox
    {
        private List<Coin> box;

        // constructor to create an empty coin box
        public CoinBox()
        {

        }

        // constructor to create a coin box with some coins in it
        public CoinBox(List<Coin> SeedMoney)
        {

        }

        // put a coin in the coin box
        public void Deposit(Coin ACoin)
        {

        }

        // take a coin of the specified denomination out of the box
        public Boolean Withdraw(Coin.Denomination ACoinDenomination)
        {
            return false;
        }

        // number of half dollars in the coin box
        public int HalfDollarCount()
        {
            return -1;
        }

        // number of quarters in the coin box
        public int QuarterCount()
        {
            return -1;
        }

        // number of dimes in the coin box
        public int DimeCount()
        {
            return -1;
        }

        // number of nickels in the coin box
        public int NickelCount()
        {
            return -1;
        }

        // number of worthless coins in the coin box
        public int SlugCount()
        {
            return -1;
        }

        // total amount of money in the coin box
        public decimal ValueOf()
        {
            return -1.0M;
        }
    }
}
