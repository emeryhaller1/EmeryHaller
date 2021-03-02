using System;

namespace Conditionals_Powerpoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Please enter the # of miles >>");
            string answer = Console.ReadLine();
            //double miles = Convert.ToDouble(answer);

            double miles;
            bool isSuccessful = double.TryParse(answer, out miles);

            if (isSuccessful == true)
            {
                Console.WriteLine("Good job entering a valid number!");
            }
            else
            {
                Console.WriteLine($"Invalid input. Goodbye.");
                //return;
                Environment.Exit(-2);
            }

            Console.WriteLine("Does your shipment contain hazardous material? yes or no.");
            answer = Console.ReadLine();

            double weight;

            if (double.TryParse(answer, out weight) == false)
            {
                Console.WriteLine("Invalid input. Googbye");
            }
            double quote = .55 * miles + .73 * weight;
            double hazardousCost;

            if (answer.ToLower() == "yes")
            {
                hazardousCost = 0.15 * weight;
            }
            else
            {
                hazardousCost = 0;
               
            }

            double netTotal = quote + hazardousCost;
            double discount;

            if (miles < 150 && weight > 500)
            {
                discount = 0.10 * netTotal;
            }

            //else 
            //{
             discount = 0;
            //}

            double total = netTotal - discount;
            Console.WriteLine();
            Console.WriteLine($"Quote: {quote.ToString("C")}");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Hazardous Cost: {hazardousCost.ToString("C")}");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Discount: {discount.ToString("C")}");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Total: {total.ToString("C")}");
            //this is how you ask the progam to have decimal places for a value
            //N2 means two decimal places for miles

        }
    }
}
