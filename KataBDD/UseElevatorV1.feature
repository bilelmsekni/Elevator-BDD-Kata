Feature: UseElevatorV1
	In order to go to my appartement
	As a lazy Person
	I want to take the elevator

@version1
Scenario: luckyDay
	Given the elevator is on the ground floor	
	And I am on the ground floor
	When I call elevator
	Then the elevator opens door on ground level
