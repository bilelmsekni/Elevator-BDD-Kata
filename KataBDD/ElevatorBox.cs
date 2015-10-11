using System.Collections.Generic;

namespace Elevator
{
    public enum ElevatorState
    {
        Stopped,
        GoingUp,
        GoingDown
    }

    public class ElevatorBox : IElevatorBox
    {
        public int CurrentFloor { get; set; }
        SortedSet<int> upperFloors = new SortedSet<int>();
        SortedSet<int> lowerFloors = new SortedSet<int>(new DescendingSort());        

        public ElevatorState ElevatorState { get; set; }

        public void Operate()
        {
            if (ElevatorState != ElevatorState.Stopped)
            {
                if (ElevatorState == ElevatorState.GoingUp)
                {
                    foreach (var upperFloor in upperFloors)
                    {
                        OpenDoors(upperFloor);
                    }
                    upperFloors.Clear();
                }
                else if (ElevatorState == ElevatorState.GoingDown)
                {
                    foreach (var lowerFloor in lowerFloors)
                    {
                        OpenDoors(lowerFloor);
                    }
                    lowerFloors.Clear();
                }
                UpdateElevatorState();
            }
        }

        private void UpdateElevatorState()
        {
            if (lowerFloors.Count > 0)
            {
                ElevatorState = ElevatorState.GoingDown;
            }
            else if (upperFloors.Count > 0)
            {
                ElevatorState = ElevatorState.GoingUp;
            }
            else
            {
                ElevatorState = ElevatorState.Stopped;
            }
            Operate();
        }

        public void RegisterFloorRequest(int goingTo)
        {            
            if (CurrentFloor <= goingTo)
            {
                upperFloors.Add(goingTo);
                if (ElevatorState == ElevatorState.Stopped)
                    ElevatorState = ElevatorState.GoingUp;
            }
            else if (CurrentFloor > goingTo)
            {
                lowerFloors.Add(goingTo);
                if (ElevatorState == ElevatorState.Stopped)
                    ElevatorState = ElevatorState.GoingDown;
            }  
        }

        public virtual void OpenDoors(int floorLevel)
        {
        }
    }
}
