using System;
using NSubstitute;
using TechTalk.SpecFlow;

namespace Elevator
{
    [Binding]
    public class UseElevatorV5Steps
    {
        private IElevatorBox elevator;

        [Scope(Feature = "UseElevatorV5")]
        [Given(@"the elevator is on the (.*) floor")]
        public void GivenTheElevatorIsOnTheFloor(int currentFloor)
        {
            elevator = Substitute.ForPartsOf<ElevatorBox>();
            elevator.CurrentFloor = currentFloor;
        }

        [Scope(Feature = "UseElevatorV5")]
        [Given(@"(.*) wants to take elevator from (.*) floor to (.*) floor")]
        public void GivenUserWantsToTakeElevatorFromFloorToFloor(string userName, int currentFloor, int goingTo)
        {
            var user = new ElevatorUser
            {
                Name = userName,
                CurrentFloor = currentFloor,
                GoingTo = goingTo
            };
            user.CallElevator(elevator);
            user.RequestFloor(elevator);
        }

        [Scope(Feature = "UseElevatorV5")]
        [When(@"the elevator operates")]
        public void WhenTheElevatorOperates()
        {
            elevator.Operate();
        }

        [Scope(Feature = "UseElevatorV5")]
        [Then(@"the elevator opens doors on (.*) floor")]
        public void ThenTheElevatorOpensDoorsOnFloor(int expectedFloor)
        {
            elevator.Received().OpenDoors(expectedFloor);
        }
    }
}
