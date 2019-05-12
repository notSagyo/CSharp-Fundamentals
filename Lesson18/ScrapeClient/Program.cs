using ScrapeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ScrapeLibrary.Scrape myScrape = new Scrape();
            string value = myScrape.ScrapeWebpage("https://github.com");

            Console.WriteLine(value);

            Console.ReadLine();
        }
    }
}