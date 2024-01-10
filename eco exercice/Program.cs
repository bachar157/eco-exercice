using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eco_exercice
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1)--Please enter your interest rate (high, medium, or low):");
            decimal interestRateValue = interestRate(Console.ReadLine());

            Console.WriteLine("2)--Enter growth rate (high, medium, or low):");
            decimal growthRateValue = growthRate(Console.ReadLine());

            Console.WriteLine("3)--Enter the most recent dividend (integer greater than 0 but less than 100):");
            decimal recentDividend = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("4)--Enter the number of shares (integer greater than 0):");
            int shares = Convert.ToInt32(Console.ReadLine());

            decimal stockValue = valueOfStock(recentDividend, interestRateValue, growthRateValue);
            decimal marketValue = CalculateMarketValue(stockValue, shares);

            Console.WriteLine($"The projected market value of the investment is: {marketValue}");
            Console.ReadLine();
        }

        // Function to get and display the interest rate
        public static decimal interestRate(string userInput)
        {
            while (true)
            {
                switch (userInput.ToLower())
                {
                    case "high":
                        Console.WriteLine("Implies interest rate is projected to be 20%");
                        return 0.20m;
                    case "medium":
                        Console.WriteLine("Interest rate is projected to be 10%");
                        return 0.10m;
                    case "low":
                        Console.WriteLine("Interest rate is projected to be 8%");
                        return 0.08m;
                    default:
                        Console.WriteLine("Invalid input. Please enter high, medium, or low.");
                        userInput = Console.ReadLine();
                        break;
                }
            }
        }

        // Function to get and display the growth rate
        public static decimal growthRate(string userInput)
        {
            while (true)
            {
                switch (userInput.ToLower())
                {
                    case "high":
                        Console.WriteLine("Growth rate is projected to be 7.5%");
                        return 0.075m;
                    case "medium":
                        Console.WriteLine("Growth rate is projected to be 5%");
                        return 0.05m;
                    case "low":
                        Console.WriteLine("Growth rate is projected to be 2.5%");
                        return 0.025m;
                    default:
                        Console.WriteLine("Invalid input. Please enter high, medium, or low.");
                        userInput = Console.ReadLine();
                        break;
                }
            }
        }

        // Function to calculate the value of a stock
        public static decimal valueOfStock(decimal recentDividend, decimal interestRateValue, decimal growthRateValue)
        {
            return recentDividend / (interestRateValue - growthRateValue);
        }

        // Function to calculate the market value
        public static decimal CalculateMarketValue(decimal stockValue, int shares)
        {
            return stockValue * shares;
        }
    }
}
