using System;
using System.Threading;

namespace _2.ThreadPool
{
    class Program
    {
        static ManualResetEvent workCompleted = new ManualResetEvent(false);
        static void SomeWorker(object state)
        {
            Console.WriteLine("Hello from the Thread pool");
            workCompleted.Set();
        }
        static void Main(string[] args)
        {
            System.Threading.ThreadPool.QueueUserWorkItem(SomeWorker);
            Console.WriteLine("Item queued to the thread pool.");

            workCompleted.WaitOne();

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
