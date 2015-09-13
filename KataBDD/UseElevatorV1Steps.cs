using System;
using TechTalk.SpecFlow;
using NSubstitute;

namespace Elevator
{
    [Binding]
    public class UseElevatorV1Steps
    {
        IElevatorBox elevator;
        ElevatorUser user;

        [Given(@"the elevator is on the ground floor")]
        public void GivenTheElevatorIsOnTheGroundFloor()
        {
            elevator = Substitute.ForPartsOf<ElevatorBox>();
            elevator.CurrentFloor = 0;
        }

        [Given(@"I am on the ground floor")]
        public void GivenIAmOnTheGroundFloor()
        {
            user = new ElevatorUser { CurrentFloor = 0 };
        }

        [When(@"I call elevator")]
        public void WhenICallElevator()
        {
            user.CallElevator(elevator);
        }

        [Then(@"the elevator opens door on ground level")]
        public void ThenTheElevatorDoorOpensDoorOnGroundLevel()
        {
            elevator.Received(1).OpenDoors(Arg.Is<int>(0));
        }
    }
}
