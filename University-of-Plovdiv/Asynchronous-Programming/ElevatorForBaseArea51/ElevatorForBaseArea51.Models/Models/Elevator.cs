using ElevatorForBaseArea51.Data.Interfaces;
using System;
using System.Threading;

namespace ElevatorForBaseArea51.Data.Models
{
    public class Elevator : IElevator
    {
        private const int elevatorCapacity = 1;
        private const int elevatorDelay = 1000;
        private int elevatorSpeedInFloors = 1;
        private Semaphore semaphore;

        private static readonly Object obj = new Object();

        public Elevator(Floor currentFloor, SecurityChecker securityChecker)
        {
            semaphore = new Semaphore(elevatorCapacity, elevatorCapacity);
            CurrentFloor = currentFloor;
            SecurityChecker = securityChecker;
        }

        public Floor CurrentFloor { get; private set; }
        public Floor DestinationFloor { get; private set; }
        public SecurityChecker SecurityChecker { get; set; }
        public bool IsMoving { get; private set; }

        public void Call(Floor destinationFloor)
        {
            lock (obj)
            {
                this.DestinationFloor = destinationFloor;
                Move();
            }
        }

        public void Enter()
        {
            semaphore.WaitOne();
        }

        public void Leave()
        {
            semaphore.Release();
        }

        public bool PressButton(string name, Floor destinationFloor, SecurityLevel securityLevel)
        {
            this.DestinationFloor = destinationFloor;

            if (DestinationFloor != CurrentFloor)
            {
                var transportAgentSucceeded = TransportAgent(name, securityLevel);

                return transportAgentSucceeded;
            }

            Console.WriteLine($"This is the same floor. Agent {name} has to choose another one.");
            return false;


        }

        private bool TransportAgent(string name, SecurityLevel securityLevel)
        {
            Move();

            bool agentEnteredFloor = SecurityChecker.CanDoorOpen(securityLevel, CurrentFloor);

            if (!agentEnteredFloor)
                Console.WriteLine($"Agent {name} does not have access to enter {CurrentFloor} floor and has to choose another floor.");

            return agentEnteredFloor;
        }
        private void Move()
        {
            //lock (moveLock)
            //{
            if (CurrentFloor > DestinationFloor)
                elevatorSpeedInFloors = -1;
            else
                elevatorSpeedInFloors = 1;

            IsMoving = true;

            while (CurrentFloor != DestinationFloor)
            {

                Thread.Sleep(elevatorDelay);

                CurrentFloor += elevatorSpeedInFloors;
                Console.WriteLine($"Elevator is on {CurrentFloor} floor.");
            }

            IsMoving = false;
            //}
        }
    }
}
