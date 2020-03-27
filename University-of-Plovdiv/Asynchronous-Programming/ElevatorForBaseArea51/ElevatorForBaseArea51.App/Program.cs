using System;
using System.Collections.Generic;
using System.Threading;
using ElevatorForBaseArea51.Data.Models;

namespace ElevatorForBaseArea51.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var floorValues = typeof(Floor).GetEnumValues();
            
            var elevator = new Elevator(Floor.S, new SecurityChecker());
            var firstAccessAgent = new Agent("Penio", SecurityLevel.Confidential, Floor.G, elevator);
            var secondAccessAgent = new Agent("Wiz Khalifa", SecurityLevel.Secret, Floor.S, elevator);
            var thirdAccessAgent = new Agent("Trump", SecurityLevel.TopSecret, Floor.T2, elevator);

            var agentsList = new List<Agent>();
            agentsList.Add(firstAccessAgent);
            agentsList.Add(secondAccessAgent);
            agentsList.Add(thirdAccessAgent);

            var elevatorThread = new Thread(() => elevator.Call(Floor.T1));
            elevatorThread.Start();
            List<Thread> agentsThreads = new List<Thread>();
            foreach (var agent in agentsList)
            {
                Thread t = new Thread(agent.UseElevator);

                t.Start();
                agentsThreads.Add(t);
            }

            foreach (var agentsThread in agentsThreads)
            {
                agentsThread.Join();
            }

            Console.WriteLine("---------");
            Console.WriteLine("Completed.");
        }
    }
}
