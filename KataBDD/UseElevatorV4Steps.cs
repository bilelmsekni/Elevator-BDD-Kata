using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
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

        [When(@"the following elevator users:")]
        public void GivenTheFollowingElevatorUsers(Table table)
        {
            var users  = table.CreateSet<ElevatorUser>();

            //for (int i = 0; i < table.RowCount; i++)
            //{
            //    var userName = table.Rows[i]["User"];
            //    var userFloor = int.Parse(table.Rows[i]["CurrentFloor"]);
            //    var userGoingToFloor = int.Parse(table.Rows[i]["GoingTo"]);
            //    users.Add(new ElevatorUser
            //    {
            //        Name = userName,
            //        CurrentFloor = userFloor,
            //        GoingTo = userGoingToFloor
            //    });
            //}
            foreach (var user in users)
            {
                user.CallElevator(elevator);
                user.RequestFloor(elevator);
            }
        }

        [Then(@"the elevator will open its door in this order:")]
        public void ThenTheElevatorWillOpenItsDoorInThisOrder(Table table)
        {
            for (int i = 0; i < table.RowCount; i++)
            {
                elevator.Received(1).OpenDoors(int.Parse(table.Rows[i]["Floor"]));
            }
        }
    }
}
