using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Aspen Roberts
namespace MidtermReviewParticipations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare Variables
            const double conNum = 7.777;
            double numOne;
            double numTwo;
            double numThree;
            string numOneAsString, numTwoAsString, numThreeAsString;

            //Get Input from user
            Console.WriteLine("Please enter a number");
            numOneAsString = Console.ReadLine();

            Console.WriteLine("Please enter a different number");
            numTwoAsString = Console.ReadLine();

            Console.WriteLine("Please enter a number that is different than your first and second numbers");
            numThreeAsString = Console.ReadLine();

            //Convert strings to number data types
            numOne = Convert.ToDouble(numOneAsString);
            numTwo = Convert.ToDouble(numTwoAsString);
            numThree = Convert.ToDouble(numThreeAsString);

            double sum = numOne + numTwo + numThree;
            double secValue = sum * conNum;

            string sentence = "The sum Of the numbers entered is " + sum.ToString("N3") +
                " That sum multiplied by 7.777 is " + secValue.ToString();

            //Output to user
            Console.WriteLine(sentence);

            Console.ReadKey();
        }
    }
}
