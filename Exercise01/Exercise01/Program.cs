// Exercise 01
// Author: Nick Ling
// January 20, 2015

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercise01
{
    class VendingMachine
    {
        public const int SODA_COST = 35;
        /// <summary>
        /// A simple vending machine. You type in how much you want to pay!
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            // Welcome
            Console.WriteLine("Welcome to the .NET C# Soda Vending Machine ");

            string deposited;
            Console.Write("Please insert {0} cents: ", SODA_COST);
            deposited = Console.ReadLine();
            Thread.Sleep(1400);

            // Verify if input can be converted to an Int32.
            int deposit;
            bool isInt = Int32.TryParse(deposited, out deposit);
            if (isInt)
            {
                Console.WriteLine("You have inserted {0} cents", deposit);

                // Check if enough $ was deposited.
                dispenseSoda(deposit);
            }
            else
            {
                Console.WriteLine("Hey...we only take USD here");
            }

            // Terminate
            delayTermination();
        }

        // Check if there's enough money for a soda
        public static void dispenseSoda(int deposit)
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

        public static void delayTermination()
        {
            Console.WriteLine("\r\n\r\n");
            Console.WriteLine("Press enter to terminate...");
            Console.ReadLine();
        }
    }
}
