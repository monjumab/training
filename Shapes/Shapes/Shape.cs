using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
    {
        protected double Length { get; set; }
        protected double Width { get; set; }

        public virtual double Area()
        {
            return Length * Width;
        }
    }

    public abstract class Drawable
    {
        public virtual void Draw() { }
    }
}
