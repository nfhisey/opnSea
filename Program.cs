using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace programC

{
    class Program
    {
        static void Main(string[] args)
        {
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load("https://opensea.io/collection/rtfkt-mnlth");
            foreach (var item in doc.DocumentNode.SelectNodes("//div[@class='Overflowreact__OverflowContainer-sc-7qr9y8-0 jPSCbX']"))
            {
                Console.WriteLine(item.InnerText);
            }


        }
    }


}
