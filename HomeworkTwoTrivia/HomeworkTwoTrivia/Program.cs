using System;

namespace HomeworkTwoTrivia
{
    class Program
    {

        static void Main(string[] args)
        {
            //User Input to established questions
            Console.WriteLine("The color of the sky is blue (t/f).");
            string AnswerOne = Console.ReadLine();
            //this is true

            double Points = 0;

            //Answer One Points for accuracy
            if (AnswerOne.ToUpper() == "T")
            {
                Points = Points + 1;
            }
            else if (AnswerOne.ToUpper() == "F")
            {
                Points = Points + 0;
            }
            else
            {
                Console.WriteLine("Sorry, you did not enter t or f. Please try again.");
                Environment.Exit(-1);
            }


            //User Input to established questions
            Console.WriteLine("My favorite color is pink.");
            string AnswerTwo = Console.ReadLine();
            //True

            //Answer Two Points for Accuracy
            if (AnswerTwo.ToUpper() == "T")
            {
                Points = Points + 1;
            }
            else if (AnswerTwo.ToUpper() == "F")
            {
                Points = Points + 0;
            }
            else
            {
                Console.WriteLine("Sorry, you did not enter t or f. Please try again.");
                Environment.Exit(-1);
            }

            Console.WriteLine("My favorite animal is a cat.");
            string AnswerThree = Console.ReadLine();
            //False

            //Answer Two Points for Accuracy
            if (AnswerThree.ToUpper() == "T")
            {
                Points = Points + 0;
            }
            else if (AnswerThree.ToUpper() == "F")
            {
                Points = Points + 1;
            }
            else
            {
                Console.WriteLine("Sorry, you did not enter t or f. Please try again.");
                Environment.Exit(-1);
            }

            Console.WriteLine("I love mornings.");
            string AnswerFour = Console.ReadLine();
            //True

            //Answer Four Points for Accuracy
            if (AnswerFour.ToUpper() == "T")
            {
                Points = Points + 1;
            }
            else if (AnswerFour.ToUpper() == "F")
            {
                Points = Points + 0;
            }
            else
            {
                Console.WriteLine("Sorry, you did not enter t or f. Please try again.");
                Environment.Exit(-1);
            }

            Console.WriteLine("I am a junior.");
            string AnswerFive = Console.ReadLine();
            //False

            //Answer Two Points for Accuracy
            if (AnswerFive.ToUpper() == "T")
            {
                Points = Points + 0;
            }
            else if (AnswerFive.ToUpper() == "F")
            {
                Points = Points + 1;
            }
            else
            {
                Console.WriteLine("Sorry, you did not enter t or f. Please try again.");
                Environment.Exit(-1);
            }

            double Percent = Points / 5;

            Console.WriteLine($"You answered {Points.ToString("N0")} out of 5 correctly.");
            Console.WriteLine($"You recieved a {Percent.ToString("P0")}");
        }
    }
}
