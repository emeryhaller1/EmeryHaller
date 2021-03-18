using System;

namespace LoopsParticipationPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //define variables
            Console.WriteLine("Please enter a minimum value.");
            string minimum = Console.ReadLine();
            int minimumValue = Convert.ToInt32(minimum);

            Console.WriteLine("Please enter a maximum value");
            string maximum = Console.ReadLine();
            int maximimValue = Convert.ToInt32(maximum);

            Random rand = new Random();
            int randomNBR = rand.Next(minimumValue, maximimValue);
            int answer;

            do
            {

                Console.WriteLine($"Please guess a number between {minimumValue} and {maximimValue}");
                string guess = Console.ReadLine();

                if (int.TryParse(guess, out answer)== false)
                {
                    Console.WriteLine("Your input is not valid. Goodbye.");
                    Environment.Exit(-1);
                }

                if (answer != randomNBR)
                {
                    Console.WriteLine("Sorry, your guess was incorrect. Please try again.");
                }

            } while (answer != randomNBR);

            Console.WriteLine("You guessed the random number!! Congratulations!");
            

        }
    }
}
