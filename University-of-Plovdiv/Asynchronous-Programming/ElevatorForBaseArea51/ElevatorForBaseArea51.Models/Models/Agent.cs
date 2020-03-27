using ElevatorForBaseArea51.Data.Interfaces;
using System;

namespace ElevatorForBaseArea51.Data.Models
{
    public class Agent : IAgent
    {
        private static readonly Object obj = new Object();
        private static Random rand = new Random();
        public Agent(string name, SecurityLevel securityLevel, Floor floor, Elevator elevator)
        {
            this.Name = name;
            this.SecurityLevel = securityLevel;
            this.CurrentFloor = floor;
            this.Elevator = elevator;
        }

        public string Name { get; private set; }
        public SecurityLevel SecurityLevel { get; private set; }
        public Floor CurrentFloor { get; private set; }
        public Elevator Elevator { get; private set; }

        public void UseElevator()
        {
            lock (obj)
            {
                Console.WriteLine($"{Name} called the elevator on {CurrentFloor} floor.");
                Elevator.Call(CurrentFloor);

                Elevator.Enter();
                Console.WriteLine($"{Name} entered the elevator on {CurrentFloor} floor.");

                PressElevatorButton();

                Elevator.Leave();
                Console.WriteLine($"{Name} left the elevator on {CurrentFloor} floor.");
            }
        }

        private void PressElevatorButton()
        {
            var destinationFloor = ChooseFloor();

            Console.WriteLine($"{Name} pressed {destinationFloor} button.");
            var transportationSucceeded = Elevator.PressButton(Name, destinationFloor, SecurityLevel);

            while (!transportationSucceeded)
            {
                destinationFloor = ChooseFloor();
                Console.WriteLine($"{Name} pressed {destinationFloor} button.");

                transportationSucceeded = Elevator.PressButton(Name, destinationFloor, SecurityLevel);
            }

            CurrentFloor = destinationFloor;
        }

        private Floor ChooseFloor()
        {
            var floorsCount = typeof(Floor).GetEnumValues().Length;
            var number = GetRandomValue(floorsCount);

            var floor = (Floor)number;

            return floor;
        }

        private int GetRandomValue(int boundary)
        {
            lock (rand) return rand.Next(1, boundary);
        }
    }
}
