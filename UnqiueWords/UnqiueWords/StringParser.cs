using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnqiueWords
{
    public class StringParser
    {
        public List<string> UniqueWords(string word)
        {
            word = word.Replace(".", string.Empty);
            List<string> individualWords = word.Split(' ').ToList();

            foreach (var individualWord in individualWords)
            {
                Console.WriteLine(individualWord);
            }
            individualWords.ForEach(Console.WriteLine);

            var individual = individualWords.GroupBy(g => g, StringComparer.CurrentCultureIgnoreCase).Where(j => j.Count() == 1);
            return individual.Select(i => i.Key).ToList();
        }
    }
}
