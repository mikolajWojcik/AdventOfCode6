using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AdventOfCode6
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var url = new Uri("https://adventofcode.com/2021/day/6/input");

            var fishes = new List<Fish>();

            using (HttpClient client = new HttpClient())
            {
                var request = new HttpRequestMessage(HttpMethod.Get, url);
                request.Headers.Add("cookie",
                    "_ga=GA1.2.1029462445.1638344210; session=53616c7465645f5f9a5e19ea6eef045d8b1d6a50b62ba8cfe3509f809512b9eaa99c49a0b77d9fe0c04f4c55ccae7585; _gid=GA1.2.1726152084.1638543652");
                var response = await client.SendAsync(request);
                var stream = await response.Content.ReadAsStreamAsync();
                using (StreamReader reader = new StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        var text = await reader.ReadLineAsync();

                        if (string.IsNullOrEmpty(text))
                            continue;

                        fishes = text.Split(",").Select(x => new Fish(int.Parse(x))).ToList();
                    }
                }
            }

            var pack = new Pack(fishes);
            var result = pack.PassDaysFast(256);
            Console.WriteLine($"Result is {result}");
        }
    }
}