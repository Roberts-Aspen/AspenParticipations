using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Aspen Roberts
/*Write an application that will output all of the numbers from 1 to 100
 * added together as well as output all of the numbers from 1 to 100 multiplied together.*/

namespace Accumulators
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i < 101; i++) //i++ means it adds one to i
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);

            double multiply = 1;
            for (int i = 1; i < 101; i++)
            {
                multiply = multiply * i;
            }
            Console.WriteLine(multiply);

            Console.ReadKey();
        }
    }
}
