using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Aspen Roberts
namespace CollectionsParticipation
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is wrong look at professor example
            Console.WriteLine("Please enter three course subjects seperated by a ',' (EX. MIS, MATH, etc.");
            string userSubjects = Console.ReadLine();
            string[] spieces = userSubjects.Split(',');

            Console.WriteLine("Please enter three course numbers seperated by a ',' (EX. 3013, 3113, etc.");
            string userNumbers = Console.ReadLine();
            string[] npiecesAsString = userNumbers.Split(',');

            for (int i = 0; i < 3; i++) //picked for because we know how many times
            {
                Console.WriteLine(spieces[i] + npiecesAsString[i]);
            }
            Console.ReadKey();
            {

            }
        }
    }
}
