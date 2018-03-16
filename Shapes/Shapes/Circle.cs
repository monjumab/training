using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : IShape, IDrawable
    {
        protected double Radius { get; }

        public double Area()
        {
            return Math.PI * (Radius * Radius);
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
