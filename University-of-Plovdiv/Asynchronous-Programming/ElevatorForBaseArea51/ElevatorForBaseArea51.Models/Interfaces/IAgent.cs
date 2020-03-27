using System;
using System.Collections.Generic;
using System.Text;
using ElevatorForBaseArea51.Data.Models;

namespace ElevatorForBaseArea51.Data.Interfaces
{
    public interface IAgent
    {
        string Name { get; }
        SecurityLevel SecurityLevel { get; }
        Floor CurrentFloor { get; }
        void UseElevator();
    }
}
