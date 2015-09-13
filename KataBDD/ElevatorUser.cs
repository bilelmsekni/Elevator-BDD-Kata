using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Elevator
{
    class ElevatorUser
    {
        public int CurrentFloor { get; set; }

        public void CallElevator(IElevatorBox elevator)
        {
            elevator.Operate(CurrentFloor);
        }
    }
}
