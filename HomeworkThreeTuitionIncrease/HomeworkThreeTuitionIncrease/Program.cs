using System;

namespace HomeworkThreeTuitionIncrease
{
    class Program
    {
        const double INCREASE = 0.05;

        static void Main(string[] args)
        {
            double tuition = 12000;

            for (int i = 1; i <= 7; i++)
            {
               tuition = tuition +(tuition * INCREASE);

                Console.WriteLine($"The tuition after year {i} will be {tuition.ToString("c2")}");
            }
        }
    }
}
