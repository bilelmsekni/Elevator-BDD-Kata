using System.Collections.Generic;

namespace Elevator
{
    public enum MovingDirection
    {
        GoingUp,
        GoingDown,
        NotMoving
    }

    public class ElevatorBox : IElevatorBox
    {
        public int CurrentFloor { get; set; }
        public List<int> CallingFloors { get; set; }
        List<int> upperFloors = new List<int>(7);
        List<int> lowerFloors = new List<int>(7);

        MovingDirection elevatorDirection;

        public void Operate()
        {
            if (elevatorDirection != MovingDirection.NotMoving)
            {
                if (elevatorDirection == MovingDirection.GoingUp)
                {
                    foreach (var upperFloor in upperFloors)
                    {
                        OpenDoors(upperFloor);
                    }
                    upperFloors.Clear();
                }
                else if (elevatorDirection == MovingDirection.GoingDown)
                {
                    foreach (var lowerFloor in lowerFloors)
                    {
                        OpenDoors(lowerFloor);
                    }
                    lowerFloors.Clear();
                }
                UpdateMovingDirection();
            }
        }

        private void UpdateMovingDirection()
        {
            if (lowerFloors.Count > 0)
            {
                elevatorDirection = MovingDirection.GoingDown;
            }
            else if (upperFloors.Count > 0)
            {
                elevatorDirection = MovingDirection.GoingUp;
            }
            else
            {
                elevatorDirection = MovingDirection.NotMoving;
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
            Operate();
        }

        public virtual void OpenDoors(int floorLevel)
        {
        }
    }
}
