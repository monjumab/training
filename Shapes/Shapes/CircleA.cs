using System;

namespace Shapes
{
    public class CircleA : Shape, IDrawable
    {
        protected double Radius { get; }
        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }


        public CircleA(double radius)
        {
            Radius = radius;
        }

        public void Draw()
        {
            throw new NotImplementedException();
        }
    }
}