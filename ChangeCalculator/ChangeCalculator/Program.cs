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
                while (change > 0)
                {   // Giant if-else loop of change! 
                    if (change >= 100)
                    {
                        num100bills = change / 100;
                        change = change % 100;
                    }
                    else if (change >= 50)
                    {
                        num50bills = change / 50;
                        change = change % 50;
                    }
                    else if (change >= 20)
                    {
                        num20bills = change / 20;
                        change = change % 20;
                    }
                    else if (change >= 10)
                    {
                        num10bills = change / 10;
                        change = change % 10;
                    }
                    else if (change >= 5)
                    {
                        num5bills = change / 5;
                        change = change % 5;
                    }
                    else if (change >= 1)
                    {
                        num1bills = (change / 1) - (change % 1);
                        change = change % 1;
                    }
                    else if (change >= 0.25)
                    {
                        numQuarters = change / 0.25;
                        change = change % 0.25;
                    }
                    else if (change >= 0.10)
                    {
                        numDimes = change / 0.10;
                        change = change % 0.10;
                    }
                    else if (change >= 0.05)
                    {
                        numNickels = change / 0.05;
                        change = change % 0.05;
                    }
                    else
                    {
                        numPennies = change / 0.01;
                        change = 0;
                    }
                }

                    // Print out how much change and how it should be divided
                    Console.WriteLine("The customer's change is $" + string.Format("{0:0.00}", change));
                    Console.WriteLine("$100 bill: " + num100bills);
                    Console.WriteLine("50 bill: " + num50bills);
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
