using System;
using System.Threading.Tasks;

namespace Async
{
    class Program
    {
        static void Main(string[] args)
        {
            var worker = new Worker();

            // Demonstrate by doing Task.Run, we are putting the work onto a background thread
            // Which allow the main thread to continue execute
            Task.Run(() => worker.Work1());
            Task.Run(() => worker.Work2());
            Task.Run(() => worker.Work3());

            // This Task<string> is propagated from an external async source (httpClient),
            // we could get the result string by await this task
            var result = worker.ThisCouldBeTheServiceLayer();
            
            Console.Read();
        }
    }
}