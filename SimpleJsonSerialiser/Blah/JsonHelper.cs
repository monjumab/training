using System.Collections.Generic;
using System.Linq;

namespace JsonTraining
{
    public static class JsonHelper
    {
        public static string JsonSerialise(IEnumerable<int> numbers)
        {

            var numberList = numbers.ToList();
            var result = "{ \"numbers\":[ ";

            for (int i = 0; i < numberList.Count(); i++)
            {
                if (i == (numberList.Count() - 1))
                {
                    result += numberList[i];
                }
                else
                {
                    result += numberList[i] + ", ";
                }               
            }
            result += " ] }";

            return result;
        }
    }
}
