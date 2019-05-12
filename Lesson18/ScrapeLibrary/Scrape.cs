using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrapeLibrary
{
    public class Scrape
    {
        public string ScrapeWebpage(string url)
        {
            return GetWebPage(url);
        }

        public string ScrapeWebpage(string url, string filepath)
        {
            string reply = GetWebPage(url);
            System.IO.File.WriteAllText(filepath, reply);

            return reply;
        }

        private string GetWebPage(string url)
        {
            System.Net.WebClient client = new System.Net.WebClient();

            string content = client.DownloadString(url);
            content += "THAT'S ALL FOLKS!!!";

            return content;
        }
    }
}