using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Rectangle_and_Circle
{
    public class Rectangle
    {

        /// <summary>
        /// Gets or sets the length value.
        /// </summary>
        public double Length { get; set; }

        public double Width { get; set; }


        public double GetWidth()
        {
            return Width;
        }

        public void SetWidth(double width)
        {
            if (width < 0)
            {
                throw new ArgumentException("Width cannot be negative.");
            }
            Width = width;
        }

        public List<double> doubles { get; set; }
        public Rectangle()
        {
            Length = 0;
            Width = 0;
            doubles = new List<double>();
        }

        public double CalculateArea()
        {
            double area = 0;
            area = Width * Length;

            return  area; 
        }

        /// <summary>
        /// Calculates the perimeter of the rectangle based on its current length and width.
        /// </summary>
        /// <returns>The perimeter of the rectangle, calculated as twice the sum of its length and width.</returns>
        public double CalculatePerimeter()
        {
            double perimeter = 0;

            perimeter = 2 * (Length + Width);

            return perimeter;
        }

        public override string ToString()
        {
            return $"The rectangle has a length of {Length} and a width of {Width}. The area is {CalculateArea()} and the perimeter is {CalculatePerimeter()}.";
        }
    }
}
