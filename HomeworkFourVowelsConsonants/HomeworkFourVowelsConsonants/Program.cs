using System;

namespace HomeworkFourVowelsConsonants
{
    class Program
    {
        static void Main(string[] args)
        {
            //User Sentence
            Console.WriteLine("Please input a sentence.");
            string sentence = Console.ReadLine().ToLower();


            //How many vowels 

            int vowels = 0;
            int consonants = 0;

            for (int i = 0; i < sentence.Length; i++)
            {
                char letter = sentence[i];
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                {
                    vowels++;
                }

                else if (letter == ' ' || letter == ',' || letter == '-' || letter == '1' || letter == '2' || letter == '3' || letter == '4' || letter == '5' || letter == '6' || letter == '7' || letter == '8' || letter == '9' || letter == '?' || letter == '!') ;

                else
                {
                    consonants++;
                }
            }
            Console.WriteLine($"You have {consonants.ToString("g0")} consonants.");
            Console.WriteLine($"You have {vowels.ToString("g0")} vowels.");
        }
    }
}
