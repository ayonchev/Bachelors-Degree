using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace B.IntroToTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new WebClient();

            var currency = "USD";

            var downloadHtmlTask = client.DownloadStringTaskAsync("https://mediapool.bg");

            var extractCurrencyValueTask = downloadHtmlTask.ContinueWith<string>(
                    (content) =>
                    {
                        var webpageContent = content.Result;
                        var regex = new Regex(currency + @"\s+(?<value>\d+\.\d+)");

                        var price = regex.IsMatch(webpageContent) ? 
                                    regex.Match(webpageContent).Groups["value"].Value :
                                    "No value provided for that currency!";

                        return price;
                    }
                );

            Console.WriteLine(extractCurrencyValueTask.Result);
        }
    }
}
