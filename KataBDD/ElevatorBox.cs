using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Elevator
{
    class ElevatorBox : IElevatorBox
    {
        public int CurrentFloor { get; set; }

        public void OpenDoors(int userFloor)
        {          
        }
    }
}
