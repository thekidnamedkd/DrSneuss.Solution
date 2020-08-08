# _DR. SNEUSS' FACTORY_

#### _C# Week 4 Independent Project_

#### By _**KEVIN DAVIS**_

## Description

_An MVC application in C# for Dr. Sneuss' wild, wonderful factory using ASP/.NET and an SQL Database constructed and managed by Entity. It will keep track of the factory's many buzzing machines and the many engineers who are able to work on those machines demonstrating a many-to-many relationship between these objects.

### Specs
| Spec | Input | Output | Done? |
| :-------------     | :------------- | :------------- | :------------- | 
| Program will create a MVC for Engineer. | input: | output:  | [X] |
| Program will create a MVC for Machine. | input: | output:  | [X] |
| Program will link to a SQL database. | input: | output:  | [X] |
| Program will let the owner create a list of engineers who work at the factory. | input: | output:  | [X] |
| Program will let the owner create engineer card for for each engineer that contains properties including what machines they are licensed to work on. | input: | output:  | [X] |
| Program will let the owner update this engineer card with new licenses for the engineer. | input: | output:  | [X] |
| Program will let the owner view a list of salon's engineers and add to it. | input: | output:  | [X] |
| Program will let the owner create a list of machines available at the factory. | input: | output:  | [X] |
| Program will let the owner create machine card for for each machine that contains properties including what engineers are are licensed to work on that machine. | input: | output:  | [X] |
| Program will update this machine card as new engineers become licensed. | input: | output:  | [X] |
| Program will let the owner remove engineers and reflect this in the machine details of licensed engineers. | input: | output:  | [X] |
| Program will let the owner remove machines and reflect this in engineerd details for machines they were licensed for. | input: | output:  | [X] |
| Program will let the owner remove licences from engineers. | input: | output:  | [ ] |

## Program Setup/Installation Requirements
* _First make sure you have the .NET Core installed for your operating system. If you are unsure go here https://dotnet.microsoft.com/download/dotnet-core/2.2. Find the right version for you and install._
* _Visit the following link: https://github.com/thekidnamedkd/DrSneuss.Solution_
* _Clone the repository to your desired directory._
* _Use the terminal to navigate into to DrSneuss.Solution_
* _Once inside the folder, navigate further to the Factory folder via the terminal._
* _There you can use the command ```$dotnet restore``` to add the necessary system files to the application._
* _Then you can use the command ```$dotnet ef database update``` to create a MySQL database for the pplication._
* _Once that is complete you can run ```$dotnet run``` to launch the application._
* _If the program successfully launches you should be able to go to http://localhost:5000/ to view the project._

## Known Bugs

*_Errors will occur if field is left blank in either Edit view and submitted._
*_Duplicate Machines and Engineers can be added to their respective Index view._

## Support and contact details

_For questions, comments, or collaboration contact me at thekidnamedkd@gmail.com_

## Technologies Used

* _C#_
* _.NET Core 2.2_
* _Entity_
* _VS Code_
* _MySQL_
* _Git_
* _HTML_
* _CSS_

### License

*GPL license distribution*

Copyright (c) 2020 **_Kevin Davis_**