using System.Collections.Generic;

namespace Elevator
{
    public interface IElevatorBox
    {
        void OpenDoors(int floorLevel);
        void Operate();
        int CurrentFloor { get; set; }
        List<int> CallingFloors { get; set; }

        void RegisterFloorRequest(int goingTo);
    }
}
