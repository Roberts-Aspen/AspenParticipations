using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Aspen Roberts
namespace MidtermReview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What month is it?");
            string month = Console.ReadLine();
            int days = 0;

            if (month == "january" || month == "march" || month == "may" || month == "july" || month == "august" || month == "october" || month == "december")
            {
                days = 31;
            }
            else if (month == "april" || month == "june" || month == "september" || month == "november")
            {
                days = 30;
            }
            else if (month == "february")
            {
                Console.WriteLine("Is it a leap year?");
                string leapYear = Console.ReadLine();

                if (leapYear == "yes")
                {
                    days = 29;
                }
                else
                {
                    days = 28;
                }
            }

            Console.WriteLine(days);
            Console.ReadKey();

        }

        
    }

}
