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
            elevator.RegisterFloorRequest(CurrentFloor);
        }

        public string Name { get; set; }

        public int GoingTo { get; set; }

        public void RequestFloor(IElevatorBox elevator)
        {
            elevator.RegisterFloorRequest(GoingTo);
        }
    }
}
