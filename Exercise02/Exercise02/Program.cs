// Exercise 02
// Author: Nick Ling
// January 22, 2015

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//// control k + c to comment. ctrl ku
namespace Exercise02
{
    class VendingMachine
    {
        public const int SODA_COST = 35;
        public static PurchasePrice SODA_PURCHASE_PRICE;
        public static CanRack myCanRack;
        public static int currDeposit;
        public static string flavor;
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
            // questions:
            // Do all the sodas cost the same?

            testIsFullIsEmpty();

            DelayTermination();
        }

        public static void testIsFullIsEmpty()
        {
            myCanRack.RemoveACanOf(CanRack.Flavor.Lemon);
            myCanRack.RemoveACanOf(CanRack.Flavor.Lemon);
            myCanRack.RemoveACanOf(CanRack.Flavor.Lemon);
            Debug.Assert(myCanRack.IsEmpty(CanRack.Flavor.Lemon), "Test Failed: LemonRack is not empty.");

            myCanRack.AddACanOf(CanRack.Flavor.Lemon);
            myCanRack.AddACanOf(CanRack.Flavor.Lemon);
            myCanRack.AddACanOf(CanRack.Flavor.Lemon);
            myCanRack.AddACanOf(CanRack.Flavor.Lemon);
            Debug.Assert(myCanRack.IsFull(CanRack.Flavor.Lemon), "Test Failed: LemonRack is not full.");
        }

        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the .NET C# Soda Vending Machine ");
        }

        public static void DepositMoney()
        {
            if (isFlavorAvailable)
            {
                Console.Write("Please insert {0} cents: ", SODA_PURCHASE_PRICE.Price);
                string deposited = Console.ReadLine();
                Thread.Sleep(1400);
                bool isInt = Int32.TryParse(deposited, out currDeposit);
                Debug.WriteLine("DepositMoney: Verify if conversion successful: string = {0}, int = {1}", deposited, currDeposit);
                VerifyDeposit(isInt);
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
        public static void DispenseSoda(int deposit)
        {
            Thread.Sleep(1400);
            if (deposit >= SODA_COST)
            {
                myCanRack.RemoveACanOf(flavor);
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
            flavor = Console.ReadLine();
            verifyFlavor();
        }

        public static void verifyFlavor()
        {
            if (flavor.Equals(CanRack.Flavor.Lemon) | flavor.Equals(CanRack.Flavor.Regular) | flavor.Equals(CanRack.Flavor.Orange))
            {
                if(!myCanRack.IsEmpty(flavor))
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



//Console.WriteLine("soda costs {0} cents", SODA.Price);
//SODA.Price = 40;
//Console.WriteLine("soda cost was raised by 5 cents. it is now: {0}", SODA.Price);
