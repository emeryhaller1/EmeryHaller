using System;

namespace RandomNumberParticipation
{
    class Program
    {
        static void Main(string[] args)
        {


            //Output beginning question to the user
            Console.WriteLine("Please enter a minimum value.");
            string minimum = Console.ReadLine();
            int minimumNBR = Convert.ToInt32(minimum);

            Console.WriteLine("Please enter a maximum value.");
            string maximum = Console.ReadLine();
            int maximumMBR = Convert.ToInt32(maximum);

            //Generate a random number
            Random rand = new Random();
            int randomNBR = rand.Next(minimumNBR,maximumMBR);
            int answer;

            //Do While clause to repeat question back to user until they guess correctly

            do
            {
                Console.WriteLine($"Please guess a number between {minimumNBR} amd {maximumMBR}.");
                string guess = Console.ReadLine();
   

                if (int.TryParse(guess, out answer) == false)
                {
                    Console.WriteLine("Sorry, the answer you entered is not a valid input.");
                    Environment.Exit(-1);
                }

                if (randomNBR != answer)
                {
                    Console.WriteLine("Sorry, your guess is incorrect. Please try again.");
                }
            } while (randomNBR != answer);

            Console.WriteLine("Congratulations! You guessed the correct number!!");
        }
    }
}
