using System;

namespace CollectionsINCLASSexample
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();


            string[] StudentIDs = new string[3];  //the size not the last index (3 letters)

            for (int i = 0; i < StudentIDs.Length; i++)
            {
                StudentIDs[0] = rand.Next(13000000, 14000000).ToString();
            }

            //StudentIDs[0] = rand.Next(13000000, 14000000).ToString();  //could copy and paste this three times OR we could create a loop like above


            double[] StudentGPAs = { 3.0, 4.0, 2.7 };

            //Display all the ID's 
          // for (int i = 0; i < StudentIDs.Length; i++)
           // {
           //    string id = StudentIDs[i];
           //  Console.WriteLine($"\t{id}");

           // }

            foreach (string id in StudentIDs)
            {
                Console.WriteLine($"\t{id}");
            }

            Console.WriteLine("Whose GPA do you want to see?");
            string idToLookFor = Console.ReadLine();

            for (int i = 0; i < StudentIDs.Length; i++)
            {
                if (StudentIDs[i] == idToLookFor)
                {
                    double GPA = StudentGPAs[i];
                    Console.WriteLine($"{idToLookFor} has a {GPA.ToString("N2")}");
                }
            }

        }
    }
}
