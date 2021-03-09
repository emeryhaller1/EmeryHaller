using System;

namespace HomeworkOnePracticeSalesTotal
{
    class Program
    {
        const double SALESTAX = 0.085;
        static void Main(string[] args)
        {

            //User Input for the Item they are purchasing
            Console.WriteLine("What type of item are you purchasing?");
            string Item = Console.ReadLine();

            //User Input for the quantity they are buying
            Console.WriteLine($"What is the quantity of {Item} you wish to purchase?");
            string quanity = Console.ReadLine();
            double quanityDouble = Convert.ToDouble(quanity);

            //User Input for Item Price
            Console.WriteLine($"What is the price for each {Item}?");
            string price = Console.ReadLine();
            double priceDouble = Convert.ToDouble(price);

            //Calculate Subtotal (without tax)
            double subtotal = quanityDouble * priceDouble;

            //Calculate SalesTax
            double SalesTax = quanityDouble * SALESTAX;

            //Calculate Sales Total (SalesTax*Subtotal)
            double SalesTotal = subtotal + SalesTax;

            //Output all three to the User
            Console.WriteLine($"The subtotal for your {Item}'s is {subtotal.ToString("c")}");
            Console.WriteLine($"The sales tax for your {Item}'s is {SalesTax.ToString("c")}");
            Console.WriteLine($"The sales total for your {Item}'s is {SalesTotal.ToString("c")}");
        }
    }
}
