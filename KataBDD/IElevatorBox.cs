namespace Elevator
{
    public interface IElevatorBox
    {
        void OpenDoors(int floorLevel);
        void Operate();
        int CurrentFloor { get; set; }
        void RegisterFloorRequest(int goingTo);
        ElevatorState ElevatorState { get; set; }
    }
}
