using System;

namespace HomeworkTwoGPA
{
    class Program
    {
        
        static void Main(string[] args)
        {

            // User Input & Beginning terms
            Console.WriteLine("Please enter your overall grade for Accounting.");
            string InputAcct = Console.ReadLine();
            double accountingGrade;

            if (double.TryParse(InputAcct, out accountingGrade)== false)
            {
                Console.WriteLine($"Sorry, your entry {InputAcct} is an invalid input.");
                Environment.Exit(-1);
            }
            accountingGrade /= 100;

            Console.WriteLine("Please enter your overall grade for Marketing.");
            string InputMark = Console.ReadLine();
            double MarketingGrade;

            if (double.TryParse(InputMark, out MarketingGrade)== false)
            {
                Console.WriteLine($"Sorry, your entry {InputMark} is an invalid input.");
                Environment.Exit(-1);
            }
            MarketingGrade /= 100;

            Console.WriteLine("Please enter your overall grade for Economics.");
            string InputEcon = Console.ReadLine();
            double EconomicsGrade;

            if (double.TryParse(InputEcon, out EconomicsGrade)== false)
            {
                Console.WriteLine($"Sorry, your entry {InputEcon} is an invalid input.");
                Environment.Exit(-1);
            }
            EconomicsGrade /= 100;

            Console.WriteLine("Please enter your overall grade for MIS.");
            string InputMIS = Console.ReadLine();
            double MISGrade;

            if (double.TryParse(InputMIS, out MISGrade)== false)
            {
                Console.WriteLine($"Sorry, your entry {InputMIS} is an invalid input.");
                Environment.Exit(-1);
            }
            MISGrade /= 100;

            string MISGradeLetter, ACCTGradeLetter, ECONGradeLetter, MARKGradeLetter;

            //Output LetterGrade to User for Accounting

            double AccttotalPointsEarned = 0;

            if (accountingGrade >= .90)
            {
                ACCTGradeLetter = "A";
                AccttotalPointsEarned += AccttotalPointsEarned + 4;
            }
            else if (accountingGrade >= .80)
            {
                ACCTGradeLetter = "B";
                AccttotalPointsEarned += AccttotalPointsEarned + 3;
            }
            else if (accountingGrade >= .70)
            {
                ACCTGradeLetter = "C";
                AccttotalPointsEarned += AccttotalPointsEarned + 2;
            }
            else if (accountingGrade >= .60)
            {
                ACCTGradeLetter = "D";
                AccttotalPointsEarned += AccttotalPointsEarned + 1;
            }
            else
            {
                ACCTGradeLetter = "F";
                AccttotalPointsEarned += 0;
            }

            

            double MarktotalPointsEarned = 0;

            //Output letter grade to user for Marketing
            if (MarketingGrade >= .90)
            {
                MARKGradeLetter = "A";
                MarktotalPointsEarned += MarktotalPointsEarned + 4;
            }
            else if (MarketingGrade >= .80)
            {
                MARKGradeLetter = "B";
                MarktotalPointsEarned += MarktotalPointsEarned + 3;
            }
            else if (MarketingGrade >= .70)
            {
                MARKGradeLetter = "C";
                MarktotalPointsEarned += MarktotalPointsEarned + 2;
            }
            else if (MarketingGrade >= .60)
            {
                MARKGradeLetter = "D";
                MarktotalPointsEarned += MarktotalPointsEarned + 1;
            }
            else
            {
                MARKGradeLetter = "F";
                MarktotalPointsEarned += 0;
            }


            double EcontotalPointsEarned = 0;

            //Output letter grade for Economics
            if (EconomicsGrade >= .90)
            {
                ECONGradeLetter = "A";
                EcontotalPointsEarned += EcontotalPointsEarned + 4;
            }
            else if (EconomicsGrade >= .80)
            {
                ECONGradeLetter = "B";
                EcontotalPointsEarned += EcontotalPointsEarned + 3;
            }
            else if (EconomicsGrade >= .70)
            {
                ECONGradeLetter = "C";
                EcontotalPointsEarned += EcontotalPointsEarned + 2;
            }
            else if (EconomicsGrade >= .60)
            {
                ECONGradeLetter = "D";
                EcontotalPointsEarned += EcontotalPointsEarned + 1;
            }
            else
            {
                ECONGradeLetter = "F";
                EcontotalPointsEarned += 0;
            }

            

            double MIStotalPointsEarned = 0;

            //Output letter grade for MIS
            if (MISGrade >= .90)
            {
                MISGradeLetter = "A";
                MIStotalPointsEarned += MIStotalPointsEarned + 4;
            }
            else if (MISGrade >= .80)
            {
                MISGradeLetter = "B";
                MIStotalPointsEarned += MIStotalPointsEarned + 3.00;
            }
            else if (MISGrade >= .70)
            {
                MISGradeLetter = "C";
                MIStotalPointsEarned += MIStotalPointsEarned + 2.00;
            }
            else if (MISGrade >= .60)
            {
                MISGradeLetter = "D";
                MIStotalPointsEarned += MIStotalPointsEarned + 1.00;
            }
            else
            {
                MISGradeLetter = "F";
                MIStotalPointsEarned += 0;
            }

            

            //Output GPA 

            double totalCreditHours = 12;
            double totalAttempted = (EcontotalPointsEarned * 3) + (AccttotalPointsEarned * 3) + (MarktotalPointsEarned * 3) + (MIStotalPointsEarned * 3);

            double GPA = totalAttempted / totalCreditHours;


            Console.WriteLine($"Your letter grade for Accounting is {ACCTGradeLetter}");
            Console.WriteLine($"Your letter grade for Marketing is {MARKGradeLetter}.");
            Console.WriteLine($"Your letter grade for Economics is {ECONGradeLetter}");
            Console.WriteLine($"Your letter grade for MIS is {MISGradeLetter}");
            Console.WriteLine($"Your GPA for this semester is {GPA.ToString("N2")}");

        }
    }
}
