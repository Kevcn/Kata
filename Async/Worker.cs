using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Async
{
    public class Worker
    {
        public void Work1()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Work1 Complete!");
        }
        
        public int Work2()
        {
            Console.WriteLine("Work2 Complete!");
            return 10;
        }
        
        public void Work3()
        {
            Console.WriteLine("Work3 Complete!");
        }

        public async Task<string> ThisCouldBeTheServiceLayer()
        {
            var theString = await InputOutputN();
            return theString;
        }

        private async Task<string> InputOutputN()
        {
            var client = new HttpClient();
            var content = await client.GetStringAsync("whatever");

            return content;
        }
    }
}