using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2.AsyncAndAwait
{
    class Program
    {
        static Task DoSomethingAsync()
        {
            var t = Task.Run(() => Thread.Sleep(1000));

            return t;
        }
        static Task<int> GetTheUltimateAnswer()
        {
            return Task.Run(() => 42);
        }

        static async Task<int> CalcAnswerAsync()
        {
            Console.WriteLine($"1: {Thread.CurrentThread.ManagedThreadId}");
            await DoSomethingAsync();
            Console.WriteLine($"2: {Thread.CurrentThread.ManagedThreadId}");

            int result = await GetTheUltimateAnswer();
            Console.WriteLine($"3: {Thread.CurrentThread.ManagedThreadId}");

            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Main: {Thread.CurrentThread.ManagedThreadId}");

            CalcAnswerAsync().Wait();

            Console.WriteLine("Done");
        }
    }
}
