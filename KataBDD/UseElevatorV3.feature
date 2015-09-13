Feature: UseElevatorV3
	In order to go to my appartment
	As a lazy person
	I want to use the elevator

@version3
Scenario: ParametrizedDays
	Given I am on the 0 floor
	And the elevator is on the 0 floor
	And no call for underground floor is registered 
	When I call elevator
	Then the elevator opens door on 0 level

@version3
Scenario: PoorAndBadNeighbour
	Given I am on the 0 floor
	And the elevator is on the 0 floor
	And a call for 3 floor is registered
	And a call for -1 floor is registered
	When I call elevator
	Then the elevator opens door on -1 level
	Then the elevator opens door on 0 level
