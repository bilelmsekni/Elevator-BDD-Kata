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
        List<int> upperFloors = new List<int>(7);
        List<int> lowerFloors = new List<int>(7);

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
            if (CurrentFloor < goingTo)
            {
                upperFloors.Add(goingTo);
            }
            else if (CurrentFloor > goingTo)
            {
                lowerFloors.Add(goingTo);
            }
            else
            {
                OpenDoors(goingTo);
            }
            UpdateElevatorState();
        }

        public virtual void OpenDoors(int floorLevel)
        {
        }
    }
}
