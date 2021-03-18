using System;

namespace HomeworkThreeTimeToBurnCalories
{
    class Program
    {
        const double CALORIESPERMINUTE = 3.9;

        static void Main(string[] args)
        {
            //Ask user how many calories they wish to burn
            Console.WriteLine("Hello! How many calories do you wish to burn today?");
            string answer = Console.ReadLine();
            double goalCalories;

            //Check to makes sure input is accurate
            if (double.TryParse(answer, out goalCalories) == false)
            {
                Console.WriteLine("Sorry, the answer you entered in invalid.");
                Environment.Exit(-1);
            }

            //Now for the outputs
            //Use while because the amount of times this loop will run is unknown.
            //establish double variables to use

            double caloriesBurned = 0;
            double timeInMinutes = 0;

            while (caloriesBurned < goalCalories)
            {
                timeInMinutes++;
                caloriesBurned = caloriesBurned + CALORIESPERMINUTE;
                Console.WriteLine($"After {timeInMinutes.ToString("N0")} minutes, you have burned {caloriesBurned.ToString("n2")}");

            }

        }
    }
}
