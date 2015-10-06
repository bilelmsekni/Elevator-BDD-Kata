using System;
using TechTalk.SpecFlow;
using System.Collections.Generic;
using NSubstitute;

namespace Elevator
{
    [Binding]
    public class UseElevatorV4Steps
    {
        IElevatorBox elevator;
        [Given(@"the elevator is on the (.*) floor")]
        public void GivenTheElevatorIsOnTheFloor(int currentFloor)
        {
            elevator = Substitute.ForPartsOf<ElevatorBox>();
            elevator.CurrentFloor = currentFloor;
        }

        [Given(@"the following elevator users:")]
        public void GivenTheFollowingElevatorUsers(Table table)
        {
            var users = new List<ElevatorUser>();
            for (int i = 0; i < table.RowCount; i++)
            {
                var userName = table.Rows[i]["User"];
                var userFloor = int.Parse(table.Rows[i]["CurrentFloor"]);
                var userGoingToFloor = int.Parse(table.Rows[i]["GoingTo"]);
                users.Add(new ElevatorUser
                {
                    Name = userName,
                    CurrentFloor = userFloor,
                    GoingToFloor = userGoingToFloor
                });
            }
            foreach (var user in users)
            {
                user.CallElevator(elevator);
            }
        }
        
        [Then(@"the elevator will open its door in this order:")]
        public void ThenTheElevatorWillOpenItsDoorInThisOrder(Table table)
        {
            elevator.Received(1).OpenDoors(1);
            elevator.Received(1).OpenDoors(0);
            elevator.Received(1).OpenDoors(3);
        }
    }
}
