using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Aspen Roberts
namespace CollectionExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare Variables.
            int[] studentIds = new int[3];
            studentIds[0] = 1;
            studentIds[0] = 2;
            studentIds[0] = 3;
            double[] gpas = { 2.5, 3.1, 4.0 }; //new double[3];  

            //Ask user for input and loop- foreach.
            for (int i = 0; i < studentIds.Length; i++)
            {
                int id = studentIds[i];
            }
            Console.WriteLine("Please pick an id from the list to see their gpa:");
            foreach (int id in studentIds)
            {
                Console.WriteLine(" " + id);
            }
            int userInput = Convert.ToInt32(Console.ReadLine());

            //another loop- for and produce output for user.
            for (int i = 0; i < studentIds.Length; i++)
            {
                if(studentIds[i] == userInput)
                {
                    Console.WriteLine($"The GPA for student with id {userInput} is {gpas[1]}");
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
