using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Aspen Roberts
namespace GuessANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare Variables
            Random rand = new Random();
            int generatedNumber = rand.Next(1, 101);

            Console.WriteLine(generatedNumber);
            int answer = 0;

            while (answer != generatedNumber) 
            {
                Console.WriteLine("Please guess the randmonly generated number between 1 and 100");
                string ans = Console.ReadLine();
                while (answer, out ans == false)
                {
                    Console.WriteLine("Invalid Input, Please try again.");
                    ans = Console.ReadLine();
                }

                if (ans == generatedNumber)
                {
                    Console.WriteLine("Congrats, you correctly guessed the number");
                }
                else
                {
                    Console.WriteLine("Sorry try again.");
                }

                Console.ReadKey();
            }
            
        }
    }
}
