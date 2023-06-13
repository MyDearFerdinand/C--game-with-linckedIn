OOPAdventure Game

OOPAdventure is a text-based adventure game implemented in C#. This project serves as an interactive console application demonstrating various principles of object-oriented programming (OOP), including encapsulation, inheritance, and polymorphism. This game also exhibits advanced C# features such as generics, exception handling, file I/O operations, and usage of delegates and events.

Features

Procedural House Generation: Each gameplay session creates a new house layout with rooms.
Player Movement: Players can move North, East, South, and West in the house.
Text-based Interaction: All gameplay happens in the console, with players typing commands to perform actions.
Localization: The game's language can be easily switched, currently supporting English.

How to Play

Upon starting the game, the player chooses a name. The player navigates through the house by entering commands such as go north, go south, etc. Each room in the house is numbered and can be visited any number of times.

Code Structure

The project is organized around several key classes:

Program: Entry point to the application.
House: Represents the house the player navigates, with methods to create and manage rooms.
Room: Represents a single room in the house.
Player: Represents the player character.
Actions: A singleton class that manages the actions a player can execute.
Go: A derived class from the Action base class, implementing the "go" command.

Future Enhancements

Future improvements might include more actions, different types of rooms, and more gameplay mechanics.
