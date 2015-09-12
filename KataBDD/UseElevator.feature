Feature: UseElevator
	In order to go to my appartement
	As a lazy Person
	I want to take the elevator

@mytag
Scenario: happyElevator
	Given the elevator is on the ground floor	
	And I am on the ground floor
	When I press GoUp
	Then the elevator door opens
