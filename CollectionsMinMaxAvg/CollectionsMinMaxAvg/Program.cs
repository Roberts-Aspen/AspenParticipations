using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Aspen Roberts

/* Ask the user to enter all of their exam grades. 
 * Once they are done, calculate the minimum score, the maximum score and the average score for all of their scores.  Perform this using a Loop and not any built in functions.*/
namespace CollectionsMinMaxAvg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter all your exam grades below. >>");
            List<double> grades = new List<double>();
            string answer;
            double sum = 0;

            do
            {
                Console.WriteLine("Please enter your grade >>");
                grades.Add(Convert.ToDouble(Console.ReadLine()));

                Console.WriteLine("Do you have another grade you want to enter? Y/N >>");
                answer = Console.ReadLine().ToUpper()[0].ToString();

            } while (answer != "N");

            double min = 1000;
            double max = 0;
            double avg = 0;

            for (int i = 0; i < grades.Count; i++)
            {
                if (grades[i] < (min))
                {
                    min = grades[i];
                }
            }

            for (int i = 0; i < grades.Count; i++)
            {
                    if (grades[i] > (max))
                    {
                        max = grades[i];
                    }

            }

            for (int i = 0; i < grades.Count; i++)
            {
                sum += grades[i]; 
 
            }

            avg = sum / grades.Count;


            Console.WriteLine($"Your minimum score is {min}.");
            Console.WriteLine($"Your maximum score is {max}.");
            Console.WriteLine($"Your average score is {avg}.");



            Console.ReadKey();
            
        }
    }
}
