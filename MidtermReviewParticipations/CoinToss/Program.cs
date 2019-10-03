using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Aspen Roberts
namespace CoinToss
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 = Heads
            // 2 = Tails

            Random rand = new Random();

            int roll = rand.Next(1, 3);
            int userGuess = 0;

            Console.WriteLine("Call it in the air, Heads or Tails?");
            string answer = Console.ReadLine();

            if (answer == "heads")
            {
                userGuess = 1;
            }
            else if (answer == "tails")
            {
                userGuess = 2;
            }
            else
            {
                Console.WriteLine("Sorry Invalid guess, goodbye.");
                Environment.Exit(0);
            }

            if (userGuess == roll)
            {
                Console.WriteLine($"Congrats, it came up {answer} you guesses right!");
            }
            else
            {
                if (roll == 1)
                {
                    Console.WriteLine("Sorry the coin came up as heads");
                }
                else
                {
                    Console.WriteLine("Sorry the coin came up as tails");
                }

                Console.ReadKey();
            }
        }
    }
}
