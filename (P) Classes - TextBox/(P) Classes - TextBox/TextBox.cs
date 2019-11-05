using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _P__Classes___TextBox
{
    class TextBox
    {
        public int Padding { get; set; }

        public ConsoleColor BackColor {get; set;}

        public ConsoleColor ForeColor { get; set;}

        public string Text { get; set; }

        public TextBox()
        {
            Padding = 0;
            BackColor = ConsoleColor.Blue;
            ForeColor = ConsoleColor.Black;
            Text = "";
        }

        public void DisplayText()
        {
            Console.BackgroundColor = BackColor;

            Console.ForegroundColor = ForeColor;

            Console.WriteLine(Text);

            for (int i = 0; i < Padding - 1; i++)
            {
                
            }

            Console.WriteLine($"{Padding}{Text}{Padding}");
        }
        

    }
}
