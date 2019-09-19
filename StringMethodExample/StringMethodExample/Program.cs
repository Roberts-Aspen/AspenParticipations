using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Aspen Roberts

namespace StringMethodExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your favorite word >>");
            string answer = Console.ReadLine().ToUpper().Trim();
            string anotherString = "Something else";
            string answerASBIGLETTERS = answer.ToUpper();

            for (int i = 0; i < answer.Length; i++)
            {
                Console.Write(answerASBIGLETTERS[i] + " ");
            }
            
            Console.WriteLine($"Your favorite word has {answer.Length} characters in it");




            Console.ReadKey();
        }
    }
}
