using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Exceptions
{
    class Program
    {
        enum WorkerResult { Started, Completed, Canceled, Error }
        class WorkerParams
        {
            public WorkerResult ResultStatus { get; set; }
            public Exception WorkerException { get; set; }
            public int Result { get; set; }
            public ManualResetEvent CompleteEvent { get; }

            public WorkerParams()
            {
                CompleteEvent = new ManualResetEvent(false);
            }
        }
        static void Worker(object obj)
        {
            WorkerParams p = (WorkerParams) obj;
            try
            {
                for (int i = 0; i < 100; i++)
                {
                    Thread.Sleep(30);
                }

                int a = 0;
                int b = 5 / a;

                p.ResultStatus = WorkerResult.Completed;
                p.Result = 42;
            }
            catch (Exception x)
            {
                Console.WriteLine("Something went wrong.");
                p.ResultStatus = WorkerResult.Error;
                p.WorkerException = x;
            }

            p.CompleteEvent.Set();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Work started...");
            var threadParams = new WorkerParams();

            var thread = new Thread(Worker);
            thread.Start(threadParams);

            Console.Write("Wait for the thread to complete: ");

            while (!threadParams.CompleteEvent.WaitOne(200)) Console.Write(".");

            if (threadParams.ResultStatus == WorkerResult.Error)
            {
                Console.WriteLine("Here is what happened: " + threadParams.WorkerException.Message);
            }

            Console.WriteLine();
            Console.WriteLine("Done.");

            Console.ReadLine();
        }
    }
}
