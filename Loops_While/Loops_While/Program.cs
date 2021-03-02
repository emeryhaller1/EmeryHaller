using System;

namespace Loops_While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your lucky #");
            string answer = Console.ReadLine();
            int luckyNbr;

            if (int.TryParse(answer, out luckyNbr) == false)
            {
                Console.WriteLine("Sorry you entered an invalid integer. Please enter another number");
                answer = Console.ReadLine();
            }

            Console.WriteLine("Yay you know how to enter an integer!");

            }
        }
    }
}
