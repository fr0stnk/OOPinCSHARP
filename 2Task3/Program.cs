using System;
using System.Net;
using System.Text.RegularExpressions;

namespace Task3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            WebParser parser = new WebParser("google.com");
            Console.WriteLine(parser.FindContentInTag("h1"));
        }
    }

    class WebParser : WebClient
    {
        private string _url;

        public WebParser(string url)
        {
            _url = url;
        }

        public string FindContentInTag(string tag)
        {
            string page = DownloadString(_url);
            Regex exp = new Regex($"/<{tag}[^>] *>[^<] *<\/{tag}>/");

            return exp.Match(page).Value;
        }
    }
}
