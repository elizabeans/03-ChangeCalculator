using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator
{
    class Program
    {

        private static double num100bills;
        private static double num50bills;
        private static double num20bills;
        private static double num10bills;
        private static double num5bills;
        private static double num1bills;
        private static double numQuarters;
        private static double numDimes;
        private static double numNickels;
        private static double numPennies;

        static double GetDoubleFromConsole(string prompt)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(prompt);
                    string input = Console.ReadLine();
                    double x = Math.Round(double.Parse(input), 2);
                    return x;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please enter a number.");
                }
            }
        }

        static void Main(string[] args)
        {
            // Get cost and payment
            double cost = GetDoubleFromConsole("How much does the item cost?");
            double payment = GetDoubleFromConsole("How much has the customer given you?");

            // Calculate change 
            double change = payment - cost;

            /* Checks if customer gave enough money to cover cost
             * If not enough money, shows how much money is needed
             * If enough money is given, calculates change
             */

            if (change < 0)
            {
                change = change * -1;
                Console.WriteLine("You need $" + string.Format("{0:0.00}", change) + " more to cover the cost.");
            }
            else
            {
                Console.WriteLine("The customer's change is $" + string.Format("{0:0.00}", change));

                // Calculate how many of each amount needed
                num100bills = Math.Floor(change / 100);
                num50bills = Math.Floor(change % 100 / 50);
                num20bills = Math.Floor(change % 100 % 50 / 20);
                num10bills = Math.Floor(change % 100 % 50 % 20 / 10);
                num5bills = Math.Floor(change % 100 % 50 % 20 % 10 / 5);
                num1bills = Math.Floor(change % 100 % 50 % 20 % 10 % 5 / 1);
                numQuarters = Math.Floor(change % 100 % 50 % 20 % 10 % 5 % 1 / 0.25);
                numDimes = Math.Floor(change % 100 % 50 % 20 % 10 % 5 % 1 % 0.25 / 0.10);
                numNickels = Math.Floor(change % 100 % 50 % 20 % 10 % 5 % 1 % 0.25 % 0.10 / 0.05);
                numPennies = Math.Floor(change % 100 % 50 % 20 % 10 % 5 % 1 % 0.25 % 0.10 % 0.05 / 0.01);

                // Print out how much change and how it should be divided
                Console.WriteLine("$100 bill: " + num100bills);
                Console.WriteLine("$50 bill: " + num50bills);
                Console.WriteLine("20 bill: " + num20bills);
                Console.WriteLine("10 bill: " + num10bills);
                Console.WriteLine("5 bill: " + num5bills);
                Console.WriteLine("1 bill: " + num1bills);
                Console.WriteLine("Quarters: " + numQuarters);
                Console.WriteLine("Dimes: " + numDimes);
                Console.WriteLine("Nickels: " + numNickels);
                Console.WriteLine("Pennies: " + numPennies);
            }

            Console.ReadLine();
        }
    }
}