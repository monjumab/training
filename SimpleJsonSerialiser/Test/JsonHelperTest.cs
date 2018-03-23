using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsonTraining;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    public class JsonHelperTest
    {
        [Test]
        public void Json_serialise()
        {
            var numberArray = new []
            {
                1, 2, 4, 3, 5
            };

            var json = JsonHelper.JsonSerialise(numberArray);

            var expectedResult = "{ \"numbers\":[ 1, 2, 4, 3, 5 ] }";

            Console.WriteLine($"Actual result: {json} and expected result is {expectedResult}");

            Assert.AreEqual(expectedResult, json);
        }
    }
}
