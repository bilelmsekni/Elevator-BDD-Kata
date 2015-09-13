Feature: UseElevatorV2
	In order to go to my appartment
	As a lazy person
	I want to use the elevator

@version2
Scenario: luckyDayEnhanced
	Given I am on the ground floor
	And the elevator is on the ground floor
	And no call for underground floor is registered 
	When I call elevator
	Then the elevator opens door on ground level

Scenario: badNeighbour
	Given I am on the ground floor
	And the elevator is on the ground floor
	And a call for underground floor is registered
	When I call elevator
	Then the elevator opens door on underground level
	And the elevator opens door on ground level