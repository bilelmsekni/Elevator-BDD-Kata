Feature: UseElevatorV4
	In order to test my elevator
	As a manufacturer
	I want to have multiple users with different needs

Background: Given the elevator is on the 0 floor

@version4
Scenario: MultipleUsers		
	And the following elevator users:
	| Name   | CurrentFloor | GoingTo |
	| Matt   | 1             | 0       |
	| Bilel  | 0             | 3       |
	| Emily  | 3             | 0       |

	Then the elevator will open its door in this order:
	| Floor |
	| 1     |
	| 0     |
	| 3     |

	@version4
	Scenario: MultipleUsersWithDifferentNeeds 
	Given the elevator is on the 0 floor
	
	And the following elevator users:
	| Name   | CurrentFloor | GoingTo |
	| Matt   | 1             | 2       |
	| Bilel  | 0             | 3       |
	| Emily  | -1            | 2       |

	Then the elevator will open its door in this order:
	| Floor |
	| 1     |
	| 2     |
	| 0     |
	| -1    |
	| 2     |
	| 3     |

