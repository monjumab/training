using System;
using NUnit.Framework;
using Shapes;

namespace Shapes.Test
{
    [TestFixture]
    public class InterfaceTest
    {
        [Test]
        public void RectangleArea()
        {
            var rec = new Rectangle(5, 8);
            var result = rec.Area();

            Assert.AreEqual(40, result);
        }

        [Test]
        public void CircleArea()
        {
            var cir = new Circle(6);
            var result = cir.Area();

            Assert.AreEqual(113, Math.Round(result));
        }
    }
}
