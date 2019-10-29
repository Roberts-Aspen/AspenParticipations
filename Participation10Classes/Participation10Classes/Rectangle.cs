using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participation10Classes
{
    class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle()
        {
            Length = 0;
            Width = 0;

        }

        public double CalculateArea()
        {
            double area = Length * Width;
            return area;
        }

        /// <summary>
        /// Calculates the perimeter of the rectangle
        /// </summary>
        /// <returns>
        /// A double that is the perimeter value
        /// </returns>

        public double CalculatePerimeter()
        {
            return 2 * (Length + Width);
        }
    }



}
