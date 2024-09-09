/*
 * World of Zuul is a simple text adventure game that applies the principles of Object-Oriented Programming (OOP) and the SOLID principles:

### OOP Principles

1. **Encapsulation**: 
This principle is about bundling the data (attributes) and the methods (functions) that operate on the data into a single unit, 
and restricting the direct access to some of the object's components.

    - In the program, each class encapsulates its own data and behaviors. For instance, the Room class encapsulates the room description and neighboring rooms. 
External entities can't access these directly but have to use methods like GetExit().
    - By using private fields and public methods, the code is encapsulating the inner workings and state of its classes. 
For instance, the fields `currentRoom` and `previousRoom` in the `Game` class are `private`, and they can only be manipulated through methods provided in the class.

2. **Abstraction**: 
Abstraction means exposing only the necessary features of an object while keeping the inner complexities hidden from the user.

    - The class structure abstracts away the complexities of individual functionalities. 
For instance, the `Room` class abstracts the idea of a room and its properties, and the `Game` class abstracts the logic and flow of the game.

3. **Inheritance**: 
Inheritance is about creating a new class that is based on an existing class.
    - While the provided code doesn't have any explicit inheritance, in a more extended version or in refactoring, 
inheritance could be used to create specific types of rooms or commands that inherit from the base `Room` or `Command` class.

4. **Polymorphism**: 
This allows objects of different classes to be treated as objects of a common super class.

    - The current version does not use polymorphism explicitly. However, it could be introduced, for example, 
if we had different types of commands that all implement a common `Execute` method.


### SOLID Principles

1. **Single Responsibility Principle (SRP)**:
A class should have only one reason to change.

The classes in this example game have distinct responsibilities.
    - The `Room` class is responsible for managing room information, and the `Game` class is responsible for game logic. 
The `Parser`, `Command`, and `CommandWords` classes, as suggested, would handle command parsing and command definitions, 
ensuring each class has a single responsibility.

2. **Open/Closed Principle (OCP)**:
Software entities should be open for extension but closed for modification.

    - The current design doesn't fully leverage this principle. However, if you were to introduce interfaces or base classes for the rooms or commands, 
and then extend those for specific implementations, it would adhere more to this principle.
    - The design allows for adding new commands or rooms without having to modify existing code, thanks to the modular structure.

3. **Liskov Substitution Principle (LSP)**:
Objects of a superclass should be replaceable with objects of a subclass without affecting the correctness of the program.

    - Since there is no inheritance at play in the current code, this principle isn't directly applicable. 
It becomes relevant when you have derived classes, where derived classes should be substitutable for their base class.
    - if we had specialized room or command types, they could be substituted in without breaking the game's functionality.

4. **Interface Segregation Principle (ISP)**:
Clients shouldn't be forced to depend on interfaces they don't use.

    - The current design doesn't involve multiple interfaces. However, if you were to use interfaces, 
it's good to keep them specific to their purposes rather than having one interface with many methods that a class might not need.
For instance, when interacting with a room, there's no need to know about all commands; you just need to know about the exits.

5. **Dependency Inversion Principle (DIP)**:
High-level modules shouldn't depend on low-level modules. Both should depend on abstractions.

    - Currently, the game does not specifically depend on any high-level modules. But as the game grows, introducing interfaces and ensuring that 
high-level modules depend on abstractions rather than low-level modules would be key to following this principle.
    - However, it can be said that our high-level game logic in Game doesn't directly depend on the low-level details of command parsing. 
It interacts with the Parser and Command classes via their public methods, ensuring a level of abstraction.

In its current state, the game employs the basic concepts of OOP, especially encapsulation and abstraction. 
As the game grows and evolves, care should be taken to ensure that it continues to adhere to OOP and SOLID principles 
to maintain modularity, extensibility, and maintainability.

*/


namespace WorldOfZuul
{
    public class Program
    {
        public static void Main()
        {
            Game game = new();
            game.Play();
        }
    }
}

