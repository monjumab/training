using NUnit.Framework;

namespace Shapes.Test
{
    [TestFixture]
    public class AbstractTest
    {
        [Test]
        public void RectangleArea()
        {
            var rec = new RectangleA(5, 8);
            var result = rec.Area();

            Assert.AreEqual(40, result);
        }

        [Test]
        public void CircleArea()
        {
            var cir = new CircleA(6);
            var result = cir.Area();

            Assert.AreEqual(113, System.Math.Round(result));
        }
    }
}