using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace A.BarSimulator
{
    public class Bar
    {
        private Semaphore semaphore;
        private Dictionary<string, int> drinks;

        public Bar(int seats = 10)
        {
            semaphore = new Semaphore(seats, seats);
            drinks = InitializeDrinks();
        }

        public int NumberOfOrders { get; set; }

        private Dictionary<string, int> InitializeDrinks()
        {
            var drinks = new Dictionary<string, int>();

            drinks.Add("Rakiya", 30);
            drinks.Add("Whiskey", 30);
            drinks.Add("Beer", -1);

            return drinks;
        }

        public void EnterBar()
        {
            semaphore.WaitOne();
        }

        public void LeaveBar()
        {
            semaphore.Release();
        }

        public bool BuyDrink(string drink)
        {
            if (drinks[drink] > 0)
                drinks[drink]--;
            else if (drinks[drink] == 0)
                return false;

            NumberOfOrders++;
            return true;
        }
    }
}
