using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Aspen Roberts
namespace StringManipulation
{
    class Program
    {
        static string quote = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";
        static void Main(string[] args)
        {
            Console.WriteLine(quote);

            Console.WriteLine("What word would you like to pick from the quote?");
            string word = Console.ReadLine();

            Console.WriteLine($"What word would you like to replace {word} with?");
            string replace = Console.ReadLine();

            if (quote.Contains(word))
            {
                string newQuote = quote.Replace(word, replace);
                Console.WriteLine(newQuote);
            }
            else
            {
                Console.WriteLine($"Sorry, I could not find your {word}.");
                for (int i = word.Length - 1;  i >= 0; i = i - 1)
                {
                    Console.Write(word[i]);
                }

                
            }
            Console.ReadKey();
        }
    }
}
