using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Aspen Roberts
namespace StudentGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare Variables
            const double HWPercent = .25;
            const double partPercent = .10;
            const double quizPercent = .10;
            const double midtermpercent = .25;
            const double finalPercent = .30;
            string firstName, lastName, studentIDAsString, quizAsString, partAsString, HWAsString, midtermAsString, finalAsString;
            double studentID;
            double quiz;
            double part;
            double HW;
            double midTerm;
            double final;

            //Get Input from user
            Console.WriteLine("What is your first name?");
            firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            lastName = Console.ReadLine();

            Console.WriteLine("What is your studentID?");
            studentIDAsString = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for homeworks?");
            HWAsString = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for participations?");
            partAsString = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for quizzes?");
            quizAsString = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for the midterm?");
            midtermAsString = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for the final?");
            finalAsString = Console.ReadLine();

            //Convert strings to data types
            studentID = Convert.ToDouble(studentIDAsString);
            HW = Convert.ToDouble(HWAsString);
            part = Convert.ToDouble(partAsString);
            quiz = Convert.ToDouble(quizAsString);
            midTerm = Convert.ToDouble(midtermAsString);
            final = Convert.ToDouble(finalAsString);

            double finalGrade = ((HW * HWPercent) + (part * partPercent) + (quiz * quizPercent) + (midTerm * midtermpercent) + (final * finalPercent))/100;

            //Output to the user
            Console.WriteLine($"{firstName} {lastName} ({studentIDAsString}), your final grade is {finalGrade.ToString("P")}");

            Console.ReadKey();
        }
    }
}
