Feature: UseElevatorV4
	In order to test my elevator
	As a manufacturer
	I want to have multiple users with different needs
	
	
	Background: 
	Given the elevator is on the 0 floor

@version4
Scenario: MultipleUsers		
	When the following elevator users:
	| Name   | CurrentFloor | GoingTo |
	| Matt   | 1             | 0       |
	| Scott  | 0             | 3       |
	| Emily  | 3             | 0       |
	And the elevator operates
	Then the elevator will open its door in this order:
	| Floor |
	| 1     |
	| 0     |
	| 3     |

	@version4
Scenario: MultipleUsersWithDifferentNeeds 	
	
	When the following elevator users:
	| Name   | CurrentFloor | GoingTo |
	| Matt   | 1             | 2       |
	| Scott  | 0             | 3       |
	| Emily  | -1            | 2       |
	And the elevator operates
	Then the elevator will open its door in this order:
	| Floor |
	| 1     |
	| 2     |
	| 0     |
	| -1    |
	| 2     |
	| 3     |

