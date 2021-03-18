using System;

namespace TRYPARSE
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = "55s";
            int realNumber;
            bool b = int.TryParse(number, out realNumber);
            //before you convert it make sure that it is an integer

            if (b == true)
            {
                Console.WriteLine("Your input was correct.");
              
            }
            else
            {
                Console.WriteLine("Your input was incorrect");
                Environment.Exit(-1);
            }

            Console.WriteLine(number + 5);

        }
    }
}
