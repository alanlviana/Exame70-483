using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _1_018_AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = DownloadContent().Result;
            Console.WriteLine(result);

        }

        public static async Task<string> DownloadContent() {
            using (var httpClient = new HttpClient()) {
                var result = await httpClient.GetStringAsync("https://www.microsoft.com");
                return result;
            }

        } 
    }
}
