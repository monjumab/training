using System;
using System.Configuration;
using System.Net;
using System.Xml;
using NUnit.Framework;

namespace DisposablePattern.Test
{
    [TestFixture]
    public class WebsiteParserTest
    {
        private WebsiteParser _websiteParser;
        [Test]
        public void ParseImageTest()
        {
            var images = _websiteParser.GetHtmlDocument();

            foreach (var img in images.DocumentNode.SelectNodes("//img/@src"))
            {
                Console.WriteLine(img.OuterHtml);
            }   
        }

        [Test]
        public void DownloadImages()
        {
            var images = _websiteParser.GetHtmlDocument();

            foreach (var img in images.DocumentNode.SelectNodes("//img/@src"))
            {
                using (WebClient client = new WebClient())
                {
                    string localFileName = @"C:\Users\MonjumaB\source\repos\DisposablePattern\images" + img.Attributes["src"].Value;

                    client.DownloadFile(@"http://www.cloudhouse.com" + img.Attributes["src"].Value , localFileName);
                }
            }

        }

        [Test]
        public void CountScripTags()
        {
            var tags = _websiteParser.GetHtmlDocument();

            int tagsCount = tags.DocumentNode.SelectNodes("//script/@src").Count;

            Assert.AreEqual(7, tagsCount);
        }

        [SetUp]
        public void SetUp()
        {
            _websiteParser = new WebsiteParser("http://www.cloudhouse.com/");
        }
    }
}
