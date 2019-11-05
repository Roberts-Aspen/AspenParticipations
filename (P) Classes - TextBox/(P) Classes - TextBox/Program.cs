using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Aspen Roberts
namespace _P__Classes___TextBox
{
    class Program
    {
        static void Main(string[] args)
        {
            TextBox tb = new TextBox();
            TextBox tb1 = new TextBox();
            TextBox tb2 = new TextBox();

            tb1.Padding = 10;
            tb1.BackColor = ConsoleColor.DarkGray;
            tb1.ForeColor = ConsoleColor.DarkYellow;
            tb1.Text = "My Name is Aspen";

            tb2.Padding = 5;
            tb2.BackColor = ConsoleColor.DarkRed;
            tb2.ForeColor = ConsoleColor.White;
            tb2.Text = "I love MIS";

            tb1.DisplayText();
            tb2.DisplayText();
            Console.ReadKey();
        }
    }
}
