using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : IShape
    {
        protected double Length { get; }
        protected double Width { get; }

        public double Area()
        {
            return Length * Width;
        }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }
    }
}
