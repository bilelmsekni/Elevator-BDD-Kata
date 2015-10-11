Feature: UseElevatorV2
	In order to go to my appartment
	As a lazy person
	I want to use the elevator

@version2
Scenario: luckyDayEnhanced
	Given I am on the ground floor
	And the elevator is on the ground floor
	And no call for elevator is registered 
	When I call elevator
	And the elevator operates
	Then the elevator opens door on ground level

@version2
Scenario: badNeighbour
	Given I am on the ground floor
	And the elevator is on the ground floor
	And a call for underground floor is registered
	When I call elevator
	And the elevator operates
	Then the elevator opens door on underground level
	And the elevator opens door on ground level

@version2
Scenario: PoorNeighbour
	Given I am on the ground floor
	And the elevator is on the ground floor
	And a call for third floor is registered
	When I call elevator
	And the elevator operates
	Then the elevator opens door on ground level

@version2
	Scenario: PoorAndBadNeighbour
	Given I am on the ground floor
	And the elevator is on the ground floor
	And a call for third floor is registered
	And a call for underground floor is registered
	When I call elevator
	And the elevator operates
	Then the elevator opens door on underground level
	Then the elevator opens door on ground level
	Then the elevator opens door on third level