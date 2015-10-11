Feature: UseElevatorV5
	In order to go to my appartment
	As a lazy person
	I want to use the elevator

@version5
Scenario Outline: Multiple users
	Given the elevator is on the 0 floor
	 And <User1> wants to take elevator from <currentFloor1> floor to <goingTo1> floor
	 And <User2> wants to take elevator from <currentFloor2> floor to <goingTo2> floor	 	
	When the elevator operates
	Then the elevator opens doors on <openDoors1> floor 
	And the elevator opens doors on <openDoors2> floor
	And the elevator opens doors on <openDoors3> floor
	And the elevator opens doors on <openDoors4> floor

	Examples: 
	| User1 | currentFloor1 | goingTo1 | User2 | currentFloor2 | goingTo2 | openDoors1 | openDoors2 | openDoors3 | openDoors4 |
	| I     | 0             | 3        | Matt  | 2             | 0        | 0          | 2          | 3          | 0          |
	| I     | 3             | -1       | Matt  | 2             | 0       | 2          | 3          | 0          | -1          |