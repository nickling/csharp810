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
namespace Exercise03
{
    class VendingMachine
    {
        public const int SODA_COST = 35;
        public static PurchasePrice SODA_PURCHASE_PRICE;

        /// <summary>
        /// A simple vending machine. You type in how much you want to pay!
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            SetSodaCost();
            WelcomeMessage();
            int deposit;
            bool isInt = DepositMoney(out deposit);
            VerifyDeposit(isInt, deposit);
            DelayTermination();
        }

        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the .NET C# Soda Vending Machine ");
        }

        public static bool DepositMoney(out int deposit)
        {
            Console.Write("Please insert {0} cents: ", SODA_PURCHASE_PRICE.Price);
            string deposited = Console.ReadLine();
            Thread.Sleep(1400);
            bool isInt = Int32.TryParse(deposited, out deposit);
            Debug.WriteLine("DepositMoney: Check conversion successful: string = {0}, int = {1}", deposited, deposit);
            return isInt;
        }

        public static void VerifyDeposit(bool isInt, int deposit)
        {
            if (isInt)
            {
                Console.WriteLine("You have inserted {0} cents", deposit);

                // Check if enough $ was deposited.
                DispenseSoda(deposit);
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
                Console.Write("Thanks. Here is your soda.");
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
    }
}



//Console.WriteLine("soda costs {0} cents", SODA.Price);
//SODA.Price = 40;
//Console.WriteLine("soda cost was raised by 5 cents. it is now: {0}", SODA.Price);
