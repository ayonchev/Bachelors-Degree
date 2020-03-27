using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _3.ChildTasks
{
    class Program
    {
        static Task<int> CreateParentTask()
        {
            var parent = new Task<int>(() =>
            {
                var t1 = new Task<int>(() => 1);
                var t2 = new Task<int>(() => 2);
                var t3 = new Task<int>(() => 3);

                t1.Start();
                t2.Start();
                t3.Start();

                Task.WaitAll(t1, t2, t3);
                return t1.Result + t2.Result + t3.Result;
            });

            return parent;
        }
        static void Main(string[] args)
        {
            var t = CreateParentTask();
            t.Start();
            t.Wait();

            Console.WriteLine(t.Result);

            var p = new Task(() =>
            {
                var t1 = new Task(() =>
                {
                    Thread.Sleep(500);
                    Console.WriteLine("Child 1");
                }, TaskCreationOptions.AttachedToParent);
                var t2 = new Task(() =>
                {
                    Thread.Sleep(500);
                    Console.WriteLine("Child 2");
                }, TaskCreationOptions.AttachedToParent);
                var t3 = new Task(() =>
                {
                    Thread.Sleep(500);
                    Console.WriteLine("Child 3");
                }, TaskCreationOptions.AttachedToParent);

                t1.Start();
                t2.Start();
                t3.Start();
            });

            p.Start();
            p.Wait();

            Console.WriteLine("Parent is ready.");
        }
    }
}
