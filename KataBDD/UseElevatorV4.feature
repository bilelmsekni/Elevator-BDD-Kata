Feature: UseElevatorV4
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@version4
Scenario: MultipleUsers
	Given the elevator is on the 0 floor
	
	And the following elevator users:
	| User   | CurrentFloor | GoingTo |
	| Matt   | 1             | 0       |
	| Bilel  | 0             | 3       |
	| Emily  | 3             | 0       |

	Then the elevator will open its door in this order:
	| Floor |
	| 1     |
	| 0     |
	| 3     |
