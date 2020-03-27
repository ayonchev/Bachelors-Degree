using System;
using System.Collections.Generic;
using System.Threading;

namespace ThreadPriorities
{
    class Program
    {
        static ManualResetEvent StopEvent = new ManualResetEvent(false);
        static void Worker()
        {
            while (!StopEvent.WaitOne(0))
            {

            }
        }
        static void Main(string[] args)
        {
            List<Thread> threads = new List<Thread>();
            for (int i = 0; i < Environment.ProcessorCount - 1; i++)
            {
                var thread = new Thread(Worker);
                thread.Priority = ThreadPriority.Lowest;
                thread.Start();
                threads.Add(thread);
            }

            Console.WriteLine("All work started. Press ENTER to stop.");

            Console.ReadLine();
            StopEvent.Set();

            Console.WriteLine("Exiting");

            foreach (var t in threads)
            {
                t.Join();
            }

            Console.WriteLine("Bye");

            Console.ReadLine();
        }
    }
}
