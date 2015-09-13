using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Elevator
{
    public interface IElevatorBox
    {
        void OpenDoors(int floorLevel);
        void Operate(int floorLevel);
        int CurrentFloor { get; set; }
        List<int> CallingFloors { get; set; }
    }
}
