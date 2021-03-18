using System;

namespace HomeworkFourI337Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            //input a sentence
            Console.WriteLine("Hello! Please input a sentence.");
            string sentence = Console.ReadLine().ToUpper();

            //Contains & Replace
            sentence = sentence.Replace("A", "4").Replace("E", "3").Replace("H", "-").Replace("S", "$").Replace("T", "7").Replace("U", "_").Replace("O", "0").Replace("P", "[]D");

            //Output sentence to user

            if (sentence[sentence.Length - 1] != '!')
            {
                sentence += '!';
            }


            Console.WriteLine($"{sentence}");
        }
    }
}
