using System;
using System.Collections.Generic;
using System.Text;
using ElevatorForBaseArea51.Data.Models;

namespace ElevatorForBaseArea51.Data.Interfaces
{
    public interface IElevator
    {
        Floor CurrentFloor { get; }
        Floor DestinationFloor { get; }
        void Call(Floor destinationFloor);
        bool PressButton(string name, Floor destinationFloor, SecurityLevel securityLevel);
        bool IsMoving { get; }
    }
}
