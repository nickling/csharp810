// Exercise 03
// Author: Nick Ling
// January 27, 2015

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//// control k + c to comment. ctrl ku
namespace Exercise03
{
    class VendingMachine
    {
        public const decimal SODA_COST = 0.35M;
        // public const int SODA_COST = 1; // PurchasePrice can also be created using an int.
        public static PurchasePrice SODA_PURCHASE_PRICE;
        public static CanRack myCanRack;
        public static decimal currDeposit;
        public static string flavor;
        public static Flavor AFlavor;
        public static bool isFlavorAvailable = false;

        /// <summary>
        /// A simple vending machine. 
        /// You can set the cost of the soda, then 
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            // Prepare the machine, pricing, welcome message
            myCanRack = new CanRack();
            SetSodaCost();
            WelcomeMessage();
            PickFlavor();
            DepositMoney();

            // Tests
            EmptyACanRackThenRefillIndividually();
            FillACanRackThenRemoveCans();

            // Terminate
            DelayTermination();
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

        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the .NET C# Soda Vending Machine ");
        }

        public static void DepositMoney()
        {
            if (isFlavorAvailable)
            {
                Console.Write("Please insert {0:c} cents: ", SODA_PURCHASE_PRICE.Price);
                string deposited = Console.ReadLine();
                Thread.Sleep(400);
                bool isDecimal = Decimal.TryParse(deposited, out currDeposit);
                Debug.WriteLine("DepositMoney: Verify if conversion successful: string = {0}, int = {1}", deposited, currDeposit);
                VerifyDeposit(isDecimal);
            }
        }

        public static void VerifyDeposit(bool isInt)
        {
            if (isInt)
            {
                Console.WriteLine("You have inserted {0} cents", currDeposit);

                // Check if enough $ was deposited.
                DispenseSoda(currDeposit);
            }
            else
            {
                Console.WriteLine("Hey...we only take USD here");
            }
        }

        // Check if there's enough money for a soda
        public static void DispenseSoda(decimal deposit)
        {
            Thread.Sleep(400);
            if (deposit >= SODA_COST)
            {
                myCanRack.RemoveACanOf(AFlavor);
                Console.Write("Thanks. Here is your {0} soda.", flavor);
                // and we take your change, lol
            }
            else
            {
                Console.Write("That's not enough for a soda :(");
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
                if (AFlavor == Flavor.REGULAR | AFlavor == Flavor.LEMON | AFlavor == Flavor.ORANGE )
                {
                    Console.WriteLine("flavor is {0}", AFlavor);
                    if (!myCanRack.IsEmpty(AFlavor))
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



//Console.WriteLine("soda costs {0} cents", SODA.Price);
//SODA.Price = 40;
//Console.WriteLine("soda cost was raised by 5 cents. it is now: {0}", SODA.Price);
