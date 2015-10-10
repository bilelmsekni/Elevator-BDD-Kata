using System;
using TechTalk.SpecFlow;
using NSubstitute;
using System.Collections.Generic;

namespace Elevator
{
    [Binding]
    public class UseElevatorV3Steps
    {
        IElevatorBox elevator;
        ElevatorUser user;

        [Scope(Feature = "UseElevatorV3")]
        [Given(@"I am on the (.*) floor")]
        public void GivenIAmOnTheXFloor(int userLevel)
        {
            user = new ElevatorUser { CurrentFloor = userLevel };
        }

        [Scope(Feature = "UseElevatorV3")]
        [Given(@"the elevator is on the (.*) floor")]
        public void GivenTheElevatorIsOnTheXFloor(int elevatorLevel)
        {
            elevator = Substitute.ForPartsOf<ElevatorBox>();
            elevator.CurrentFloor = elevatorLevel;
        }

        [Scope(Feature = "UseElevatorV3")]
        [Given(@"no call for underground floor is registered")]
        public void GivenNoCallForUndergroundFloorIsRegistered()
        {
            elevator.ElevatorState = ElevatorState.Stopped;
        }

        [Scope(Feature = "UseElevatorV3")]
        [Given(@"a call for (.*) floor is registered")]
        public void GivenACallForXFloorIsRegistered(int callingLevel)
        {
            elevator.RegisterFloorRequest(callingLevel);
        }

        [Scope(Feature = "UseElevatorV3")]
        [When(@"I call elevator")]
        public void WhenICallElevator()
        {
            user.CallElevator(elevator);
        }

        [Scope(Feature = "UseElevatorV3")]
        [Then(@"the elevator opens door on (.*) level")]
        public void ThenTheElevatorOpensDoorOnXLevel(int openDoorLevel)
        {
            elevator.Received(1).OpenDoors(Arg.Is<int>(openDoorLevel));
        }
    }
}
