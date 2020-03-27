using System;
using System.Diagnostics;
using System.Dynamic;
using System.Collections.Generic;
using System.Threading;

namespace ThirdLectureAsynchronousProgramming
{
    class Program
    {
        const int inputDataSize = 100_000;
        static Point[] inputData = new Point[inputDataSize];

        const int searchDataSize = 1000;
        static Point[] searchData = new Point[searchDataSize];
        static Point[] resultData = new Point[searchDataSize];

        static void GenerateRandomData(Point[] array)
        {
            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Point()
                {
                    X = rand.NextDouble() * 100_000,
                    Y = rand.NextDouble() * 100_000
                };
            }
        }

        static void LinearSearch()
        {
            for (int i = 0; i < searchDataSize; i++)
            {
                SearchOne(i);
            }
        }

        static void SearchOne(int i)
        {
            var searchPoint = searchData[i];
            foreach (var p in inputData)
            {
                if (resultData[i] == null)
                {
                    resultData[i] = p;
                }
                else
                {
                    double oldDistance = searchPoint.GetDistanceFrom(resultData[i]);
                    double newDistance = searchPoint.GetDistanceFrom(p);
                    if (newDistance < oldDistance)
                    {
                        resultData[i] = p;
                    }
                }
            }
        }

        static void AllThreadSearch()
        {
            List<Thread> threads = new List<Thread>();
            for (int i = 0; i < searchDataSize; i++)
            {
                var thread = new Thread(
                    obj =>
                    {
                        int index = (int) obj;
                        SearchOne(index);
                    });
                thread.Start(i);
                threads.Add(thread);
            }

            foreach (var thread in threads)
            {
                thread.Join();
            }
        }

        static void FewThreadSearch()
        {
            int threadCount = Environment.ProcessorCount;
            int workSize = searchDataSize / threadCount;

            List<Thread> threads = new List<Thread>();
            for (int i = 0; i < threadCount; i++)
            {
                var thread = new Thread(
                    obj =>
                    {
                        int[] range = (int[]) obj;
                        int from = range[0];
                        int to = range[1];

                        for (int index = from; index < to; index++)
                        {
                            SearchOne(index);
                        }
                    });
                int rangeFrom = workSize * i;
                int rangeTo = workSize * (i + 1);
                thread.Start(new int[] {rangeFrom, rangeTo});
                threads.Add(thread);
            }

            foreach (var t in threads) t.Join();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Generating data...");
            GenerateRandomData(inputData);
            GenerateRandomData(searchData);
            Console.WriteLine("Done.");
            Console.WriteLine();

            Console.WriteLine("Linear searching...");
            Stopwatch watch = new Stopwatch();
            watch.Restart();
            LinearSearch();
            watch.Stop();
            Console.WriteLine($"Done in {watch.ElapsedMilliseconds} ms.");

            Console.WriteLine("All threads searching...");
            watch.Restart();
            AllThreadSearch();
            watch.Stop();
            Console.WriteLine($"Done in {watch.ElapsedMilliseconds} ms.");

            Console.WriteLine("Few threads searching...");
            watch.Restart();
            FewThreadSearch();
            watch.Stop();
            Console.WriteLine($"Done in {watch.ElapsedMilliseconds} ms.");

            Console.WriteLine("Done.");
            //Console.ReadLine();
            
        }
    }
}
