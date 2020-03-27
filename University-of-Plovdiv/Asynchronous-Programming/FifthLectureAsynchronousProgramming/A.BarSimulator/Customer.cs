using System;
using System.Threading;

namespace A.BarSimulator
{
    public class Customer
    {
        const int sleepInterval = 500;
        private static Random rand = new Random();

        public Customer(string name, Bar bar)
        {
            this.Name = name;
            this.Bar = bar;
        }

        public string Name { get; private set; }
        public bool InTheBar { get; set; }
        public Bar Bar { get; private set; }

        //Using that method because the Random class is not thread safe.
        private int GetRandomValue(int boundary)
        {
            lock (rand) return rand.Next(boundary);
        }

        private string ChooseADrink(int boundary)
        {
            int drinkNum = GetRandomValue(boundary);

            switch (drinkNum)
            {
                case 0:
                    return "Rakiya";
                case 1:
                    return "Whiskey";
                case 2:
                    return "Beer";
                default:
                    throw new ArgumentOutOfRangeException("No such drink!");
            }
        }

        public void Go()
        {
            while (true)
            {
                Thread.Sleep(sleepInterval);
                int action = GetRandomValue(3);

                if (InTheBar)
                {
                    switch (action)
                    {
                        case 0:
                            string drink = ChooseADrink(3);
                            bool hasDrink = Bar.BuyDrink(drink);

                            while(!hasDrink)
                            {
                                drink = ChooseADrink(3);
                                hasDrink = Bar.BuyDrink(drink);
                            }

                            Console.WriteLine($"{Name} is drinking {drink}.");
                            break;
                        case 1:
                            Console.WriteLine($"{Name} is dancing.");
                            break;
                        case 2:
                            Console.WriteLine($"{Name} is leaving the bar.");
                            Bar.LeaveBar();
                            InTheBar = false;
                            break;
                        default:
                            throw new ArgumentOutOfRangeException($"Customer action is invalid: " + action);
                    }
                }
                else
                {
                    switch (action)
                    {
                        case 0:
                            Console.WriteLine($"{Name} is going for a walk.");
                            break;
                        case 1:
                            Console.WriteLine($"{Name} is getting in the queue for the bar.");
                            Bar.EnterBar();
                            Console.WriteLine($"{Name} just entered the bar");
                            InTheBar = true;
                            break;
                        case 2:
                            Console.WriteLine($"{Name} is going home.");
                            return;
                        default:
                            throw new ArgumentOutOfRangeException("Invalid custom behavior!");
                    }
                }
            }
        }
    }
}
