using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise05
{
    class CoinBox
    {
        // You add a bunch of coins. eg: slug, slug, slug, dime, etc. You don't keep count.
        private List<Coin> box;
        private const int DUMMYARGUMENT = 0;

        // constructor to create an empty coin box
        public CoinBox()
        {
            box = new List<Coin>();
            // upon constructing this, you will need to populate the List<CoinBox>
            // use LINQ queries in WithDraw(), and each of the properites that returns the # of
            // coins of a particular denomination
        }

        // constructor to create a coin box with some coins in it
        public CoinBox(List<Coin> SeedMoney)
        {
            box = SeedMoney;
        }

        // put a coin in the coin box
        public void Deposit(Coin ACoin)
        {
            box.Add(ACoin);
        }

        // take a coin of the specified denomination out of the box
        public Boolean Withdraw(Coin.Denomination ACoinDenomination)
        {
            Boolean successfulWithdrawal = false;
            Coin myCoin = new Coin(ACoinDenomination);

            var containsCoins =
                from coin in box
                where coin == myCoin
                select coin;

            if (containsCoins.Count() > 0)
            {
                Debug.WriteLine("withdrawing a {0} from the CoinBox", myCoin, DUMMYARGUMENT);
                box.Remove(myCoin);
                successfulWithdrawal = true;
            }
            else
            {
                Debug.WriteLine("*** Failed attempt to remove a coin from the CoinBox. ({0})", myCoin, DUMMYARGUMENT);
            }
            return successfulWithdrawal;


            /*
            // non-LINQ query version.
            Boolean successfulWithdrawal = false;
            Coin coin = new Coin(ACoinDenomination);
            if(box.Contains(coin))
            {
                Debug.WriteLine("withdrawing a {0} from the CoinBox", coin, DUMMYARGUMENT);
                box.Remove(coin);
                successfulWithdrawal = true;
            }
            else
            {
                Debug.WriteLine("*** Failed attempt to remove a coin from the CoinBox. ({0})", coin, DUMMYARGUMENT)
            }
            return successfulWithdrawal;
             */
        }

        // number of half dollars in the coin box
        public int HalfDollarCount
        {
            get
            {
                Coin halfDollar = new Coin("HALFDOLLAR");
                var halfCount =
                    from coin in box
                    where coin.ValueOf == halfDollar.ValueOf
                    select coin;

                return halfCount.Count();
            }
        }

        // number of quarters in the coin box
        public int QuarterCount
        {
            get
            {
                Coin quarter = new Coin("QUARTER");
                var quarterCount =
                    from coin in box
                    where coin.ValueOf == quarter.ValueOf
                    select coin;

                return quarterCount.Count();
            }
        }

        // number of dimes in the coin box
        public int DimeCount
        {
            get
            {
                Coin dime = new Coin("DIME");
                var dimeCount =
                    from coin in box
                    where coin.ValueOf == dime.ValueOf
                    select coin;

                return dimeCount.Count();
            }
        }

        // number of nickels in the coin box
        public int NickelCount
        {
            get
            {
                Coin nickel = new Coin("NICKEL");
                var nickelCount =
                    from coin in box
                    where coin.ValueOf == nickel.ValueOf
                    select coin;

                return nickelCount.Count();
            }
        }

        // number of worthless coins in the coin box
        public int SlugCount
        {
            get
            {
                Coin slug = new Coin("SLUG");
                var slugCount =
                    from coin in box
                    where coin.ValueOf == slug.ValueOf
                    select coin;

                return slugCount.Count();
            }
        }

        // total amount of money in the coin box
        public decimal ValueOf()
        {
            Decimal tally = 0.0M;
            foreach (Coin coin in box)
            {
                tally += coin.ValueOf;
            }
            tally /= 100;
            return tally;
        }
    }
}
