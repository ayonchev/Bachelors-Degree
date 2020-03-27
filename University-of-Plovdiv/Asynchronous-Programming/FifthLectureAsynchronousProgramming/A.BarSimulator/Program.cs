using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace A.BarSimulator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bar bar = new Bar();
            List<Customer> customers = new List<Customer>();

            for (int i = 0; i < 20; i++)
            {
                customers.Add(new Customer(i.ToString(), bar));
            }

            //Run them all

            List<Thread> customerThreads = new List<Thread>();
            foreach (var customer in customers)
            {
                Thread t = new Thread(customer.Go);

                t.Start();
                customerThreads.Add(t);
            }

            foreach (var t in customerThreads)
            {
                t.Join();
            }

            Console.WriteLine();
            Console.WriteLine("Simulation complete");
            Console.WriteLine($"The bar had {bar.NumberOfOrders} orders for the night.");

            Console.ReadLine();
        }
    }
}
