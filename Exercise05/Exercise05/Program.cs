// Exercise 04
// Author: Nick Ling
// January 29, 2015

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
// control kc to comment. ctrl ku to uncomment

namespace Exercise05
{
    class VendingMachine
    {
        public const decimal SODA_COST = 35M;
        // public const int SODA_COST = 1; // PurchasePrice can also be created using an int.
        public static PurchasePrice SODA_PURCHASE_PRICE;
        public static CanRack myCanRack;
        public static Flavor AFlavor;
        public static bool isFlavorAvailable = false;
        private const int DUMMYARGUMENT = 0;

        /// <summary>
        /// A simple vending machine. 
        /// You can set the cost of the soda, then 
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            setup();

            bool keepDispensing = true;
            while (keepDispensing)
            {
                PickFlavor();
                DepositMoney();
                keepDispensing = nextPurchase();
            }

            // Tests - commented out when not testing
            //EmptyACanRackThenRefillIndividually();
            //FillACanRackThenRemoveCans();
            myCanRack.DisplayCanRack();

            // Terminate
            DelayTermination();
        }


        // Prepare the machine, pricing, welcome message
        public static void setup()
        {
            myCanRack = new CanRack();
            SetSodaCost();
            WelcomeMessage();
        }

        public static void EmptyACanRackThenRefillIndividually()
        {
            Flavor testFlavor = Flavor.REGULAR;
            myCanRack.EmptyCanRackOf(testFlavor);
            Debug.Assert(myCanRack.IsEmpty(testFlavor), "Test Failed: Regular Rack is not empty.");

            myCanRack.AddACanOf(testFlavor);
            myCanRack.AddACanOf(testFlavor);
            Debug.Assert(!myCanRack.IsEmpty(testFlavor), "Test Failed: Regular Rack is still empty.");
        }

        public static void FillACanRackThenRemoveCans()
        {
            Flavor testFlavor = Flavor.REGULAR;
            myCanRack.FillTheCanRack();
            Debug.Assert(myCanRack.IsFull(testFlavor), "TestFailed: Regular Rack is not full");

            myCanRack.RemoveACanOf(testFlavor);
            Debug.Assert(!myCanRack.IsFull(testFlavor), "TestFailed: Regular Rack is full");
        }

        public static bool nextPurchase()
        {
            bool keepDispensing = false;

            bool validResponse = false;
            while (!validResponse)
            {
                Console.WriteLine();
                Console.Write("Would you like to purchase another soda? (Y/N)");
                String response = Console.ReadLine();
                // take the response and process it.
                response = response.ToLower().Trim();
                if (response.StartsWith("y"))
                {
                    validResponse = true;
                    keepDispensing = true;
                }
                else if (response.StartsWith("n"))
                {
                    validResponse = true;
                    keepDispensing = false;
                }
                else
                {
                    Console.WriteLine("sorry, I didn't understand that response. ");
                }
            }
            return keepDispensing;
        }

        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the .NET C# Soda Vending Machine ");
        }

        public static void DepositMoney()
        {
            decimal balance = 0M;

            if (isFlavorAvailable)
            {
                Console.WriteLine("This machine accepts: nickels, dimes, quarters, and halfdollars");

                bool enoughMoney = false;
                while (!enoughMoney)
                {
                    Console.Write("Please insert {0} cents: ", SODA_PURCHASE_PRICE.PriceDecimal - balance);
                    string readCoin = Console.ReadLine().ToUpper().Trim();

                    Coin newCoin = new Coin(readCoin);
                    balance += newCoin.ValueOf;
                    if (balance >= SODA_PURCHASE_PRICE.PriceDecimal)
                    {
                        enoughMoney = true;
                    }
                }

                Debug.WriteLine("balance is: {0}", balance, DUMMYARGUMENT);
                // Check if enough $ was deposited.
                Thread.Sleep(400);
                DispenseSoda(balance);
            }
        }

        // Check if there's enough money for a soda
        public static void DispenseSoda(decimal balance)
        {
            Thread.Sleep(400);
            if (balance >= SODA_COST)
            {
                myCanRack.RemoveACanOf(AFlavor);
                Console.WriteLine("Thanks. Here is your {0} soda.", AFlavor);
                // and we take your change, lol
            }
            else
            {
                Console.WriteLine("That's not enough for a soda :(");
            }
        }

        public static void SetSodaCost()
        {
            SODA_PURCHASE_PRICE = new PurchasePrice(SODA_COST);
        }

        public static void DelayTermination()
        {
            Console.WriteLine("\r\n\r\n");
            Console.WriteLine("Press enter to terminate...");
            Console.ReadLine();
        }

        public static void PickFlavor()
        {
            Console.Write("Please pick a flavor: Regular, Orange, or Lemon: ");
            String flavor = Console.ReadLine();
            flavor = flavor.ToUpper().Trim();
            verifyFlavor(flavor);
        }

        public static void verifyFlavor(string flavor)
        {
            if (Enum.TryParse<Flavor>(flavor, out AFlavor))
            {
                //if (flavor.Equals(Flavor.LEMON) | flavor.Equals(Flavor.REGULAR) | flavor.Equals(Flavor.ORANGE))
                if (AFlavor == Flavor.REGULAR | AFlavor == Flavor.LEMON | AFlavor == Flavor.ORANGE)
                {
                    // Console.WriteLine("flavor is {0}", AFlavor);
                    if (myCanRack.IsEmpty(AFlavor))
                    {
                        isFlavorAvailable = false;
                        Console.WriteLine("Sorry for the inconvenience, we are out of {0}", AFlavor);
                    }
                    else
                    {
                        isFlavorAvailable = true;
                    }
                }
                else
                {
                    Console.WriteLine("That's not a flavor. Try again");
                }
            }
        }
    }
}