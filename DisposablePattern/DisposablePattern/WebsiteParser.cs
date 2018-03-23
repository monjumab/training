using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace DisposablePattern
{
    public class WebsiteParser
    {
        private string _website;

        public WebsiteParser(string website)
        {
            this._website = website;
        }

        public HtmlDocument GetHtmlDocument()
        {
            System.Net.WebClient client = new WebClient();
            String htmlCode = client.DownloadString(_website);

            HtmlWeb xmlDoc = new HtmlWeb();
            var html = xmlDoc.Load(_website);
      
            return html;
        }
    }
}
