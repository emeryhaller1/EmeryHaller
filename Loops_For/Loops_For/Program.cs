using System;

namespace Loops_For
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;

            //Const all the way up to 100
            for (int i = 1; i <= 1000; i++) ;

           
            {
                sum = sum + i;
            }
            Console.WriteLine($"{sum.ToString("n0")}");

            //if (i % 3 == 0)
            //{
            Console.WriteLine(i);
            //}
        }
    }
}
