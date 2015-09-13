using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Elevator
{
    public class ElevatorBox : IElevatorBox
    {
        public int CurrentFloor { get; set; }
        public List<int> CallingFloors { get; set; }

        public void Operate(int userFloor)
        {
            var filteredCallingFloors = new List<int> { userFloor };
            if (CallingFloors != null && CallingFloors.Count > 0)
            {
                foreach (var floorLevel in CallingFloors)
                {
                    if (floorLevel < userFloor)
                    {
                        filteredCallingFloors.Add(floorLevel);
                    }
                }
            }

            foreach (var callingFloor in filteredCallingFloors)
            {
                OpenDoors(callingFloor);
            }
        }

        public virtual void OpenDoors(int floorLevel)
        {            
        }
    }
}
