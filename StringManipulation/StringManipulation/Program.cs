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
        static string s1;
        static void Main(string[] args)
        {
            string s1 = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";

            Console.WriteLine("Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning." + Environment.NewLine);

            Console.WriteLine("What word do you want to look for in the above sentence?"+ Environment.NewLine);

            string word = Console.ReadLine();

            bool a = s1.Contains(word);

            if (a == true)
            {
                Console.WriteLine("\nWhat word do you want to change it to?\n");

                string newWord = Console.ReadLine();

                string modified = s1.Replace(word, newWord);

                Console.WriteLine($"\n{modified}");
            }

            else
            {
                char[] array = word.ToCharArray();
                string reverse = String.Empty;
                for (int i = array.Length - 1; i > -1; i--)
                {
                    reverse += array[i];
                }
                

                Console.WriteLine($"\nSorry, I could not find your {reverse}." + Environment.NewLine);
            }

            Console.ReadKey();

            

           
        }
    }
}
