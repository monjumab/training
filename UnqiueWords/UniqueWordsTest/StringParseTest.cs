using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using UnqiueWords;

namespace UniqueWordsTest
{
    [TestFixture]
    public class StringParseTest
    {
        [Test]
        public void UniqueWordInString()
        {
           StringParser words = new StringParser();
           List<string> unique = words.UniqueWords("Looking for C# developer. To become a c# DeveloPer you need to work hard");
         
           Assert.AreEqual(new List<string>{"Looking", "for", "become", "a", "you", "need", "work", "hard"}, unique);
    
        }

    }
}
