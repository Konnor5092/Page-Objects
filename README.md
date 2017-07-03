# Page-Objects

This repository contains some classes extracted from a test automation project to give a rough idea of how it's designed.

Generally speaking, each page represent is called a 'Page Object' and represents a particular webpage. In this project they are...
* HomePage.cs
* LoginPage.cs
* ApprenticePage.cs
* ApprenticeEpaPage.cs

They are similar in design, and each will have a different amount and type of 'Controls'.

All the page objects inherit from BasePage<T>. This is an abstract class with some common methods that will be performed on every page object. T is purely used so these methods can be chained together, e.g. from ApprenticeImportTests

`apprenticePage.EnterText(apprenticePage.ForenameField, "Harry").EnterText(apprenticePage.ForenameField, "Smith");`

**ApprenticeImportTests.cs** and **LoginTests.cs** are used to actually perform actions on the page objects. 

**Program.cs** displays the code that I would like to refactor

## List of perceived code smells and requirements ##

* The dictionary is my attempt at refactoring the switch statement. In my real application this dictionary will grow over time. Is it possible it could be improved on?
* How might I go about actually retrieving the object from the dictionary that is initialised as part of the function? Once retrieved would I need to cast it to the object type I want? This issue/requirement was noticed as it takes circa 5 seconds to initialise some of my page object due to loading data from the screen. With this dictionary load and check the page title, I'm initialising here, then to use the object elsewhere I would need to initalise again.
* There isn't any code for this in this project, but there is in my real world application - How might I store the page objects and the test classes in a common collection? In my application they are stored as a collection of objects (of type `object`) and downcasted to the different types when needed. I'm sure this is poor design.
* Any design improvements you can think of

Cheer!
