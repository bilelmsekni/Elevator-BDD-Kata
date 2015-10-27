Elevator Kata BDD
===============================

This Kata will help candidates learn more about BDD development. It is based on .Net tools such as SpecFlow, NUnit, NSubstitute.

Table of Contents
=================

  1. Preparing your machine
  2. Elevator Kata
  3. Understanding solution
  4. Licensing
  5. Contacts
  6. To do

1. Preparing your machine
===============

1.1. Installing Visual Studio
-----------------

* Download visual studio installation from the link below and install it on your machine:

   https://www.visualstudio.com/en-us/products/visual-studio-community-vs.aspx

1.2. Adding Visual Studio extensions
--------------------------------

* SpecFlow extension adds to visual studio the necessary BDD project templates:

   Open Visual Studio and go to Tools > Extensions and Updates.
   Search for SpecFlow on the online visual studio gallery and add it.

* Because we will be using Nunit, it will be useful to add Nunit test adapter extension to visual studio in order to run tests from within the test explorer:

   Open Visual Studio and go to Tools > Extensions and Updates.
   Search for NUnit test adapter on the online gallery and add it.

1.3. Creating the test project
---------------------------

* Finally, create a new library project and add reference to the following packages via Nuget Manager console:

   Open Visual Studio and go to Tools > NuGet package manager > NuGet package manager console and type these commands.

   Install-Package NUnit
   
   Install-Package NSubstitute
   
   Install-Package SpecFlow
   
   2. Elevator Kata
===============

You company is looking to build a software for their high tech elevator. You have been assigned to write the program based on specifications written by your colleagues. The expected behaviour of the elevator is as following:

- The building has 6 floors and an underground level.
- Elevator must open doors on every calling floor above it's current level if it's going up.
- Elevator must open doors on every calling floor below it's current level if it's going down.
- Elevator can not change his direction until all calling floors on it's way have been served.
- Elevator can not work if its door is still open.
- Elevator can not work if its total weight exceeds 300 kg

Examples:

	Given the elevator is on the 0 floor
	 And Matt wants to take elevator from 0 floor to 3 floor
	 And Emily wants to take elevator from 2 floor to -1 floor	 	
	When the elevator operates
	Then the elevator opens doors respectively on 0, 2, 3, -1 floors

	Given the elevator is on the 3 floor
	 And Matt wants to take elevator from 2 floor to 0 floor
	 And Emily wants to take elevator from 0 floor to 1 floor	 	
	When the elevator operates
	Then the elevator opens doors respectively on 2, 0, 1 floors
	
	Given the elevator is on the 0 floor
	 And Matt wants to take elevator from -1 floor to 2 floor
	 And Emily wants to take elevator from 3 floor to 6 floor	 	
	When the elevator operates
	Then the elevator opens doors respectively on -1, 2, 3, 6 floors
	
   3. Understanding the solution
===============

- UseElevatorV1: Create your first feature, generate the steps and check if the test runs ok.
- UseElevatorV2: Write multiple scenarios and notice how the same steps can share their implementation. Change step scope if necessary.
- UseElevatorV3: Use parameters to reduce the quantity of written code and avoid unecessary duplication
- UseElevatorV4: Demonstrate how tables and its helpers can be used. Notice the background setup for the feature.
- UseElevatorV5: Use the scenario outline to make a more clear concept and reduce code amount.
- TBD: SpecFlow has hooks (methods can be executed before/after a scenario/feature)
- TBD: DataSharing in specFlow can be done through 3 ways: Instance fields, scenario context and dependency injection

   4. Licensing
===============

Elevator KataBDD is licensed under a Creative Commons Attribution 3.0 Unported License.

![ScreenShot](http://i.imgur.com/4XWrp.png)

To view a copy of this license, visit [ http://creativecommons.org/licenses/by/3.0/deed.en_US ].

   5. Contacts
===============

Bilel Msekni (msekni.bilel@gmail.com)

   6. To do
===============

Do the BDD in other languages such as Java ...
