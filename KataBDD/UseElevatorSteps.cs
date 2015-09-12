using System;
using TechTalk.SpecFlow;
using NSubstitute;

namespace Elevator
{
    [Binding]
    public class UseElevatorSteps
    {
        IElevatorBox elevator;
        ElevatorUser user;

        [Given(@"the elevator is on the ground floor")]
        public void GivenTheElevatorIsOnTheGroundFloor()
        {
            elevator = Substitute.For<IElevatorBox>();
        }

        [Given(@"I am on the ground floor")]
        public void GivenIAmOnTheGroundFloor()
        {
            user = new ElevatorUser { CurrentFloor = 0 };
        }

        [When(@"I press GoUp")]
        public void WhenIPressGoUp()
        {
            user.CallElevator(elevator);
        }

        [Then(@"the elevator door opens")]
        public void ThenTheElevatorDoorOpens()
        {
            
        }
    }
}
