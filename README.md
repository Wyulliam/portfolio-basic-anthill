# WORK IN PROGRESS
Before going thru this project, keep in mind that it is in progress. 
This are the main things that are **waiting to be developed**:
- **Use of Entity framework**: the repositories are fake right now
- **Integration Tests**: test the application after Entity Framework
- **Life and death of ants**: after being born, ants are supposed to die after a while

# What is this project?
This is a simple project that is part of my online portfolio. The objective of the portfolio is to pratice and keep track of my designing skills.

This project is an Anthill. Here, you are the Queen of the Anthill and you have the power to lay new eggs of any type of ants. These ants are born, live for a while and die. 
It is a simple console application used to test the code.

# What you are not going to find in this project
These topics are not present in this project. They will have their own project in the near future:
- REST/Web API
- MEP

# What you are going to find in this project

## .NET Core
.NET Core because you, the reader, may not be using Windows OS.

## TDD
Using Test Driven Development on your project will not only make it less susceptible to bugs, it will increase your productivity and make your code way more clean. In this project, my approach was to create the Queen's implementation, and start unit testing its functions, using interfaces that were not even implemented. This way, I can guarantee that the Queen's implementation is working the way it is supposed to work. After that, I implemented the next interface, and started unit testing it the same way, and so it goes.

To achive this simplicity into testing implementation using only interfaces, I used **NSubstitute** where you can mock your interfaces and guarantee they received calls with the expected parameters.
I also used **Fluent Assertions** to facilitate the assertions of the tests.

## SOLID principles
### Single Responsability
Classes and Interfaces should have only one reason to change. All the classes and interfaces have only one responsability, low or high level.
Take for example, the AntTypeRepository: its responsability is to get/save ant types, while the Queen, even if it needs to do multiple tasks, its only responsability is to manage the Anthill.

### Open Closed
Code should be open to extensions, but closed to modifications. In this project, we have a Nursery, where it care for the ant eggs. The Queen will always have access to the Nursery methods, even if we decided to create a SpecialNursery. We could give the Queen a whole new Nursery without needing to change any Queen's behaviour.

### Dependency Injection
With Dependency Injection, class are not bounded directly to another classes implementation. Rather than creating a new instance of a class inside your code, you "inject" it in its constructor, decoupling them and making it easier for changes. 

## Abstract Factories
All the high level interfaces in this project (Nursery, Colony and Cemtery) use an abstract factory to create all the services necessary. This way, we know that the Nursery, for example, will always have an EggGenerator. The nursery don't need to know if the EggGenerator is a DefaultEggGenerator, a SpecialEggGenerator or a MagicalEggGenerator. The factory has the responsability to provide the right EggGenerator.

## Repository Pattern
Using the Repository Pattern, we can make our code persistence ignorant. It does not need to know if the eggs are being saved at an SQL Server database, a JSON file or even being sent to the cloud. The code knows that there is an Interface that save the eggs. This interface is at the Core project while its implementation is at the Data project

# References
- [Why .NET Core](https://stackify.com/net-core-vs-net-framework/)
- [Why TDD](https://jrebel.com/rebellabs/if-and-when-you-should-use-test-driven-development/)
- [Single Responsability Principle](https://hackernoon.com/you-dont-understand-the-single-responsibility-principle-abfdd005b137)
- [Open Closed Principle](https://deviq.com/open-closed-principle/)
- [Dependency Injection](https://www.infoworld.com/article/2974298/exploring-the-dependency-injection-principle.html)
- [Using Abstract Factories](https://sourcemaking.com/design_patterns/abstract_factory)
- [Using Repository Pattern](https://deviq.com/repository-pattern/)
