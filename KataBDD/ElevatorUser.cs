using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Elevator
{
    class ElevatorUser
    {
        public int CurrentFloor { get; set; }

        internal void CallElevator(IElevatorBox elevator)
        {
            elevator.OpenDoors(CurrentFloor);
        }
    }
}
