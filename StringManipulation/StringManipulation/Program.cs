using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";

            //Show User the sentence
            Console.WriteLine("Programming today is a race between software engineers striving to build bigger and better idiot - proof programs, and the universe trying to build bigger and better idiots.So far, the universe is winning");
            

            //Ask what they wish to change in the above sentence
            Console.WriteLine("What word do you want to change from the sentence above?");
            string oldWord = Console.ReadLine();

            //Ask what they want to change oldWord to
            Console.WriteLine("What do you want to change the previous word to?");
            string newWord = Console.ReadLine();

            //Verify that the oldWord they stated is in the phrase

            bool b = phrase.Contains(oldWord);


           if (b)
            {
                string replacement = phrase.Replace(oldWord, newWord);
                Console.WriteLine($"{replacement}");
                
            }
           else
            {
                Console.WriteLine($"Sorry,{oldWord} included in the sentence above.");
                string reverse = "";

                int length = newWord.Length;

                for (int i = length; i >= 0; i--)
                {
                    reverse = reverse + newWord[i];
                    Console.WriteLine($"{reverse}");
                }
                
                
            }
            
        }
    }
}
