using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Aspen Roberts
namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word or phase.");
            String word = Console.ReadLine();

            String palindrome = String.Empty;

            int index = word.Length - 1;

            Console.WriteLine(index);

            while(index >= 0)
            {
                palindrome = palindrome + word[index];
                index--;
            }

            if (palindrome.ToLower() == word.ToLower())
            {
                Console.WriteLine($"The word {word} is a palindrome");
            }
            else
            {
                Console.WriteLine($"The word {word} isn't a palindrome");
            }

            Console.ReadKey();
        }
    }
}
