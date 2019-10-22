using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Aspen Roberts
namespace Functions3
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("What participation would you like to run? (Functions1 (1) /Functions2 (2)?");
            int userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput == 1)
            {
                Functions1();
            }
            else if (userInput == 2)
            {
                Functions2();
            }
            else
            {
                both();
            }

            Console.ReadKey();
        }

        static void Functions1()
        {
            double userInput = GetDoubleInputFromUser("Please enter your GPA >>");

            Console.WriteLine($"{userInput} * 5 = {userInput * 5}");

            userInput = GetDoubleInputFromUser("Please enter your major GPA >>");
            Console.WriteLine($"{userInput} * 5 = {userInput * 5}");
        }

        static double GetDoubleInputFromUser(string msg)
        {
            bool isSuccess;
            double input;
            do
            {
                Console.WriteLine(msg);
                string answer = Console.ReadLine();

                isSuccess = double.TryParse(answer, out input);

            } while (isSuccess == false);

            return input;

        }

        static void Functions2()
        {
            DeveloperInformation("Adam Ackerman", "MIS-3013", "10/22/2019");
            double lOperand, rOperand, result = 0;
            string answer = "";
            do
            {
                Console.WriteLine("What function do you want to perform (+, -, *, /)? >>");
                string operation = Console.ReadLine();

                if (answer == "R")
                {
                    lOperand = result;
                }
                else
                {
                    Console.WriteLine("What is the first operand? >>");
                    lOperand = Convert.ToDouble(Console.ReadLine());
                }

                Console.WriteLine("What is the second operand? >>");
                rOperand = Convert.ToDouble(Console.ReadLine());

                result = 0;
                if (operation == "+")
                {
                    result = Add(lOperand, rOperand);
                }
                else if (operation == "-")
                {
                    result = Subtract(lOperand, rOperand);
                }
                else if (operation == "*")
                {
                    result = Multiply(lOperand, rOperand);
                }
                else if (operation == "/")
                {
                    result = Divide(lOperand, rOperand);
                }
                else
                {
                    Console.WriteLine("INVALID OPERATION");
                }

                Console.WriteLine($"{lOperand.ToString("N2")} {operation} {rOperand.ToString("N2")} = {result.ToString("N2")}");

                Console.WriteLine("Do you want to perform a New (N) calculation, new with result as first operand (R) or Exit (E)? >>");

                answer = Console.ReadLine();
            } while (answer.ToLower() != "e");

            Console.WriteLine($"Thanks for playing!");
            Console.ReadKey();
        }

        static double Divide(double v1, double v2)
        {

            if (v2 == 0)
            {
                return 0;
            }
            double result = v1 / v2;

            return result;
        }

        static double Add(double val1, double val2)
        {
            double sum = val1 + val2;

            return sum;
        }

        static double Subtract(double val1, double val2)
        {
            double result = val1 - val2;

            return result;
        }

        static double Multiply(double val1, double val2)
        {
            double result = val1 * val2;

            return result;
        }

        static void DeveloperInformation(string devName, string className, string date)
        {

            Console.WriteLine($"Created by : {devName} for {className} on {date}.");

        }

        static void both()
        {
            Functions1();

            Functions2();

        }

        
    }
}
