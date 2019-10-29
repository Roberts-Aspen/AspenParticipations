using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Aspen Roberts
namespace Participation10Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle();
            rect1.Length = 5;
            rect1.Width = 10;
            double p1 = rect1.CalculatePerimeter();

            Console.WriteLine($"Rectangle 1 with {rect1.Length} length and {rect1.Width} width has a perimeter of {p1} and an area of {rect1.CalculateArea()}");

            Rectangle rect2 = new Rectangle();
            rect2.Length = 200;
            rect2.Width = 5;

            Console.WriteLine($"Rectangle 2 with {rect2.Length} length and {rect2.Width} width has a perimeter of {rect2.CalculatePerimeter()} and an area of {rect2.CalculateArea()}");

            Console.ReadKey();
        }
    }
}
