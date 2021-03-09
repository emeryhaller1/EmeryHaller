using System;

namespace StingManipulationParticipationExampleINClass
{
    class Program
    {
        static string QUOTE = "Programming today is a race between software engineers striving to build bigger" +
            " and better idiot-proof programs, and the universe trying to build " +
            "bigger and better idiots. So far, the universe is winning.";
        static void Main(string[] args)
        {
            Console.WriteLine(QUOTE);
            Console.WriteLine("What word would you like to search for?");
            string searchWord = Console.ReadLine();

            Console.WriteLine($"What do you wnat to replace {searchWord} with?");
            string newWord = Console.ReadLine();


            if (QUOTE.Contains(searchWord) == true)
            {
                string newQuote = QUOTE.Replace(searchWord, newWord);
                Console.WriteLine(newQuote);
            }
            else
            {
                Console.WriteLine($"Your word, {searchWord} is not found in the phrase.");
                string reverseWord = string.Empty;
                //must do this so that the starting value is clean and clear

                for (int i = searchWord.Length - 1; i >= 0; i = i - 1)
                    //must do >= 0 so that the whole string of variables entered by user gets put backwards
                {
                    reverseWord = reverseWord + searchWord[i];
                }
                Console.WriteLine(reverseWord);
            }
            //asking the program if the user searchword is in the phrase
            QUOTE.Contains(searchWord);

        }
    }
}
