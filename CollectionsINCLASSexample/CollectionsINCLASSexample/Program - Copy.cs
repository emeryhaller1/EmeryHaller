using System;

namespace CollectionsINCLASSexample
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> favoriteThings = new List<string>();

            string answer;

            do
            {
                Console.WriteLine("What is one of your most favorite things? >>");
                answer = Console.ReadLine();

                favoriteThings.Add(answer);

                Console.WriteLine("Do you have another favorite thing to add?");
                answer = Console.ReadLine();


            } while (answer.ToLower()[0] == 'y');

            Random rand = new Random();
            int randomTHingsIndex = rand.Next(0, favoriteThings.Count);

            string randomThing = favoriteThings[randomTHingsIndex]
            Console.WriteLine($"Your random favorite thing is :\n{randomThing}")



        }
    }
}
