using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eco_exercice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" 1)--please enter your interest rate if it is high or midium or low :");

            string interestRateInput = Console.ReadLine();
            interestRate(interestRateInput);

            Console.WriteLine(" 2)--enter growth rate  either high or midium or low :");
            string growthRateInput = Console.ReadLine();


            Console.ReadLine();
        }
        // in this meathod i am trying to get the interest rate from 
        // the user and the i give user feadback which kind of inrest he/she has 
        public static void interestRate(string userInput)
        {
            switch (userInput)
            {
                case "high":
                case "HIGH":
                    Console.WriteLine(" implies interest rate is projected to be 20%");
                    break;
                case "medium":
                case "MEDIUM":
                    Console.WriteLine("interest rate is projected to be 10% ");
                    break;
                case "low":
                case "LOW":
                    Console.WriteLine(" interest rate is projected to be 8% ");
                    break;

                default:
                    Console.WriteLine("out of the order");
                    break;
            }
        }
        public static void growthRate(string growthRateInput)
        {
            switch (growthRateInput)
            {
                case "high":
                case "HIGH":
                    Console.WriteLine(" growth rate is projected to be 7.5%");
                    break;
                case "medium":
                case "MEDIUM":
                    Console.WriteLine(" growth rate is projected to be 5%");
                    break;
                case "low":
                case "LOW":
                    Console.WriteLine("growth rate is projected to be 2.5%");
                    break;

                default:
                    Console.WriteLine("out of the order");
                    break;
            }
        }
    }
}
