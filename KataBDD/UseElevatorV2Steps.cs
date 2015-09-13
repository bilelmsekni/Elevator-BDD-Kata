using System;
using TechTalk.SpecFlow;
using NSubstitute;
using System.Collections.Generic;

namespace Elevator
{
    [Binding]
    public class UseElevatorV2Steps
    {
        IElevatorBox elevator;
        ElevatorUser user;

        [Scope(Feature = "UseElevatorV2")]
        [Given(@"the elevator is on the ground floor")]
        public void GivenTheElevatorIsOnTheGroundFloor()
        {
            elevator = Substitute.ForPartsOf<ElevatorBox>();
            elevator.CurrentFloor = 0;

        }

        [Scope(Feature = "UseElevatorV2")]
        [Given(@"I am on the ground floor")]
        public void GivenIAmOnTheGroundFloor()
        {
            user = new ElevatorUser { CurrentFloor = 0 };
        }

        [Scope(Feature = "UseElevatorV2")]
        [Given(@"no call for underground floor is registered")]
        public void GivenNoCallForUndergroundFloorIsRegistered()
        {
            elevator.CallingFloors = new List<int>();
        }

        [Scope(Feature = "UseElevatorV2")]
        [Given(@"a call for underground floor is registered")]
        public void GivenACallForUndergroundFloorIsRegistered()
        {
            elevator.CallingFloors = new List<int> { -1 };
        }

        [Scope(Feature = "UseElevatorV2")]
        [When(@"I call elevator")]
        public void WhenICallElevator()
        {
            user.CallElevator(elevator);
        }

        [Then(@"the elevator opens door on underground level")]
        public void ThenTheElevatorOpensDoorOnUndergroundLevel()
        {
            elevator.Received(1).OpenDoors(Arg.Is<int>(-1));
        }

        [Scope(Feature = "UseElevatorV2")]
        [Then(@"the elevator opens door on ground level")]
        public void ThenTheElevatorDoorOpensDoorOnGroundLevel()
        {
            elevator.Received(1).OpenDoors(Arg.Is<int>(0));
        }
    }
}
