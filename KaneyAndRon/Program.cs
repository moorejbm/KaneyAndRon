using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace KaneyAndRon
{
    class Program
    {
        static void Main(string[] args)
        {
            QuoteGenerator.KanyQuote();

            QuoteGenerator.RonQuote();

            QuoteGenerator.KanyQuote();

        }
    }
}
