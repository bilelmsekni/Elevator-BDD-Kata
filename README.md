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

   Open Visual Studio and go to Tools > Extension Manager.
   Search for SpecFlow extension and add it.

* Because we will be using Nunit, it will be useful to add Nunit test adapter extension to visual studio in order to run tests from within the test explorer:

   Open Visual Studio and go to Tools > Extension Manager.
   
   Search for NUnit test adapter extension and add it.

* NuGet package manager is also essential to get the required references for our project:

   Open Visual Studio and go to Tools > Extension Manager.
   
   Search for NuGet extension and add it.

1.3. Creating the test project
---------------------------

* Finally, create a new library project and add reference to the following packages via Nuget Manager console:

   Open Visual Studio and go to Tools > NuGet package manager > NuGet package manager console and type these commands.

   Install-Package NUnit
   
   Install-Package NSubstitue
   
   2. Elevator Kata
===============

You company is looking to build a software for their high tech elevator. You have been assigned to write the program based on specifications written by your colleagues. The expected behaviour of the elevator is as following:

- The building has 5 floors and an underground level.
- Elevator must open doors on every calling floor if it's going up.
- Elevator must open doors on every calling floor if it's going down.
- Elevator can not change his direction until all calling floors on it's way have been served.
- Elevator can not work if its door is still open.
- Elevator can not work if its total weight exceeds 300 kg

   3. Understanding the solution
===============

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
