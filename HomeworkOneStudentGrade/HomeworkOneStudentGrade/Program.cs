using System;

namespace HomeworkOneStudentGrade
{
    class Program
    {
        const double participationPercent = 0.08;
        const double homeworkPercent = 0.12;
        const double midtermPercent = 0.40;
        const double finalPercent = 0.40;
        const double quizPercent = 0.00;

        static void Main(string[] args)
        {
            //Enter First Name
            Console.WriteLine("Please enter your first Name.");
            string FirstName = Console.ReadLine();

            //Enter Last Name
            Console.WriteLine("Please enter your Last Name.");
            string LastName = Console.ReadLine();

            //Enter Student ID
            Console.WriteLine("Please enter your student id.");
            string StudentID = Console.ReadLine();

            //Enter Quiz Grade Percentage
            Console.WriteLine("Please enter your overall percentage grade for Quizzes.");
            string QuizPercentage = Console.ReadLine();
            double QuizPercentageDouble = Convert.ToDouble(QuizPercentage);

            //Enter Participation Grade Percentage
            Console.WriteLine("Please enter your overall percentage grade for Participations.");
            string ParticipationPercentage = Console.ReadLine();
            double ParticipationPercentageDouble = Convert.ToDouble(ParticipationPercentage);

            //Enter Homework Grade Percentage
            Console.WriteLine("Please enter your overall percentage grade for Homework.");
            string HomeworkPercentage = Console.ReadLine();
            double HomeworkPercentageDouble = Convert.ToDouble(HomeworkPercentage);

            //Enter Midterm Grade Percentage
            Console.WriteLine("Please enter your overall percentage grade for Midterm.");
            string MidtermPercentage = Console.ReadLine();
            double MidtermPercentageDouble = Convert.ToDouble(MidtermPercentage);

            //Enter Final Grade Percentage
            Console.WriteLine("Please enter your overall percentage grade for Final.");
            string FinalPercentage = Console.ReadLine();
            double FinalPercentageDouble = Convert.ToDouble(FinalPercentage);

            //Calculate Final Grade
            double MIDTERM = MidtermPercentageDouble * midtermPercent;
            double FINAL = FinalPercentageDouble * finalPercent;
            double PARTICIPATION = ParticipationPercentageDouble * participationPercent;
            double HOMEWORK = HomeworkPercentageDouble * homeworkPercent;
            double QUIZ = QuizPercentageDouble * quizPercent;

            double FinalGrade = (MIDTERM + FINAL + PARTICIPATION + HOMEWORK + QUIZ) / 100;

            //Output to User What thier final grade for the class isp2
            Console.WriteLine($"{FirstName} {LastName} your final grade for MIS 3031 is {FinalGrade.ToString("p0")}");


        }
    }
}
