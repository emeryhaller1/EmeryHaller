using System;

namespace HomeworkThreeTutor
{
    class Program
    {
     

        static void Main(string[]args)
        {
            //Generate two random numbers to be added.
            Random rand = new Random();
            int NumberOne = rand.Next(1, 51);
            int NumberTwo = rand.Next(1, 51);
            int sum = NumberOne + NumberTwo;
            int answer;

            //Ask user for answer
            do
            {
                Console.WriteLine($"{NumberOne.ToString("n0")} + {NumberTwo.ToString("n0")} = ?");
                string input = Console.ReadLine();

                if (int.TryParse(input, out answer) == false)
                {
                    Console.WriteLine("Sorry, your answer is incorrect.");
                    Environment.Exit(-1);
                }

                if (sum != answer)
                {
                    Console.WriteLine("Incorrect, please try again.");
                }
            }while(sum != answer);

            Console.WriteLine("Congratulations! Your answer is correct.");
        }
    }
}
