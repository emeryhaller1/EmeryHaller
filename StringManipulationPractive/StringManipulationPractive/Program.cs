using System;

namespace StringManipulationPractive
{
    class Program
    {

        static void Main(string[] args)
        {


            int coins = 5;
            double penny = 0.01;
            double nickel = 0.05;
            double dime = 0.05;
            double quarter = 0.05;
            double coin;

                Console.WriteLine("Enter the name of your first coin.");
                string coinOne = Console.ReadLine().ToLower();


                for (int i = 0; i < 5; i--)
                {
                if (coins == penny)
                {
                    penny++;
                }
                else if (coins == nickel)
                {
                    nickel++;
                }
                else if (coins == dime)
                {
                    dime++;
                }
                else if (coins == quarter)
                {
                    quarter++;
                }
            }


            double amount = penny + nickel + dime + quarter;
            Console.WriteLine($"You have {amount.ToString("c2")} to spend at 711.");
        }
    }
}


