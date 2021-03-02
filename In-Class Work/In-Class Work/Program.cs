using System;

namespace In_Class_Work
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your lucky # (whole number) >>");
            string answer = Console.ReadLine();
            int luckyNbr = Convert.ToInt32(answer);
            //int luckyNbr = Convert.ToInt32(console.readline());

            int remainder = luckyNbr % 7;

            if (remainder == 0)
            {
                //ctrl + k + d for formatting
                Console.WriteLine($"{luckyNbr.ToString("N0")} is really a lucky number !!!");
            }
            else if (luckyNbr % 5 == 0) 
            {
                Console.WriteLine($"{luckyNbr.ToString("N0")} is really a lucky number :(");
            }
            else if (luckyNbr % 3 == 0)
            {
                Console.WriteLine();
            }
            Console.WriteLine("What is your first name >>");
            string name = Console.ReadLine();

            switch (name)
            {
                case "adam":
                    Console.WriteLine("Thats's the coolest name ever!");
            break;
                case "darby":
                    Console.WriteLine("That's a cool name, but nothing like Adam");
                    break;
             default:
                    Console.WriteLine("Thats a cool name");
            }
        }
    }
}
