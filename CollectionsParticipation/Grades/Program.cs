using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Aspen Roberts
namespace Grades
{
    class Program
    {
        static void Main(string[] args)
            //Look at professors EX this is wrong
        {

            List<Int32> gradeList = new List<Int32>();
            string gradeAsString;
            do
            {
                Console.WriteLine("Do you have a numerical grade to enter? If so enter it below, if not enter 'NO'");
                gradeAsString = Console.ReadLine();

                if (gradeAsString == "NO")
                {
                    double gradesAverage = gradeList.Average();
                    Console.WriteLine($"The average of your grades is {gradesAverage}");
                }
                else
                {
                    int grade = Convert.ToInt32(gradeAsString);
                    gradeList.Add(grade);
                }

            } while (gradeAsString != "NO");

            Console.ReadKey();
        }
    }
}
