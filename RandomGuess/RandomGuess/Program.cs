// Aspen Roberts
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGuess
{
    class Program
    {
        static void Main(string[] args)
        {

            Random Rand = new Random();
            Console.WriteLine("Please enter the minimum for your random number. >>");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the maximum for your random number. >>");
            int max = Convert.ToInt32(Console.ReadLine());


            int generatedNumber = Rand.Next(min, max + 1);


            Console.WriteLine(generatedNumber);
            int ans = 0;

            while (ans != generatedNumber)
            {


                Console.WriteLine($"please guess a number between {min} and {max}. >>");


                string answer = Console.ReadLine();
                while (Int32.TryParse(answer, out answer) == false)
                {
                    Console.WriteLine("invalid input, please try again. >>");
                }
                ans = Convert.ToInt32(answer);

                if (ans == generatedNumber)
                {
                    Console.WriteLine("Congratulations! You guessed the right number!");
                }
                else
                {
                    Console.WriteLine("You didn't guess correctly. Guess again.");
                }

                //THIS IS THE LOOP, ITS A WHILE LOOP- BC WE DONT KNOW HOW MANY TIMES WE WILL GO THROUGH THE LOOP



            }

            Console.ReadKey();
        }
    }
}
