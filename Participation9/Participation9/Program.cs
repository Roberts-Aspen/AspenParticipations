using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Aspen Roberts
namespace Participation9
{
    class Program
    {
        static void Main(string[] args)
        {
            double calculation = 0;
            string answer;
            string send = developerInformation;

            do
            {

                Console.WriteLine("What type of calculation do you want to perform? (+, -, *, /)");
                string userCalculation = Console.ReadLine();

                Console.WriteLine("What is the first value you want to use in your calculation?");
                double userValueOne = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("What is the second value you want to use in your calculation?");
                double userValueTwo = Convert.ToDouble(Console.ReadLine());


                if(userCalculation == "+")
                {
                    calculation = Add(userValueTwo, userValueTwo);
                }
                else if (userCalculation == "-")
                {
                    calculation = Subtract(userValueTwo, userValueTwo);
                }
                else if (userCalculation == "*")
                {
                    calculation = Multiply(userValueTwo, userValueTwo);
                }
                else if (userCalculation == "/")
                {
                    calculation = Divide(userValueTwo, userValueTwo);
                }
                else
                {
                    Console.WriteLine("Sorry, you did not enter a valid operator for the calculation?");
                }

                Console.WriteLine($"{userValueOne} {userCalculation} {userValueTwo} = {calculation}");

                Console.WriteLine("Do you want to perform another calculation? (yes/no)");
                answer = Console.ReadLine().ToLower();

            } while (answer == "yes");


            Console.ReadKey();
        }

        static double Add(double valOne, double valTwo)
        {
            return valOne + valTwo;
        }

        static double Subtract(double valOne, double valTwo)
        {
            return valOne - valTwo;
        }

        static double Multiply(double valOne, double valTwo)
        {
            return valOne * valTwo;
        }

        static double Divide(double valOne, double valTwo)
        {
            return valOne / valTwo;
        }

        static void DeveloperInformation(string developerName, string className, string dateOfWriting)
        {
            Console.WriteLine(developerName + " " + className + " " + dateOfWriting);

            return developerName + className + dateOfWriting;
        }
    }
}
