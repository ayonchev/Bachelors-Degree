using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SecondLectureAsynchronousDevelopment
{
    class Program
    {
        //static bool IsWorkerComplete { get; set; } = false;

        enum WorkerResult { Started, Completed, Canceled }

        static WorkerResult Result;

        static ManualResetEvent WorkCompleteEvent;
        static ManualResetEvent WorkCancelEvent;
        static void Worker()
        {
            Result = WorkerResult.Started;

            for (int i = 0; i < 100; i++)
            {
                if (WorkCancelEvent.WaitOne(0))
                {
                    Result = WorkerResult.Canceled;
                    break;
                }
                Thread.Sleep(100);
            }

            if (Result == WorkerResult.Started)
            {
                Result = WorkerResult.Completed;
            }

            //IsWorkerComplete = true;
            WorkCompleteEvent.Set();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Started some work. Press 'c' to cancel.");
            WorkCompleteEvent = new ManualResetEvent(false);
            WorkCancelEvent = new ManualResetEvent(false);
            var thread = new Thread(Worker);
            thread.Start();

            Console.Write("Progress: ");
            while (!WorkCompleteEvent.WaitOne(0))/*(!IsWorkerComplete)*/
            {
                if (Console.KeyAvailable)
                {
                    var ch = Console.ReadKey();
                    if (ch.KeyChar == 'c')
                    {
                        WorkCancelEvent.Set();
                    }
                }

                Console.Write(".");
                Thread.Sleep(500);
            }

            switch (Result)
            {
                case WorkerResult.Completed:
                    Console.WriteLine(Environment.NewLine + "Work completed.");
                    break;
                case WorkerResult.Canceled:
                    Console.WriteLine(Environment.NewLine + "Work canceled.");
                    break;
                default:
                    throw new Exception("Something unexpected happened!");
            }

            Console.ReadLine();
        }
    }
}
