Tree Parsing Task

Building the app
The app consists of three projects:
• ConsoleProject
• TreeParsing
• TreeParsing.Tests
All are written using .NET Core 3, and won’t require any external dependencies except TreeParsing.Tests, which is using Moq to execute some tests.

How to run the app
It works fine in Visual Studio 2022, although it should be fine in other versions as it is not requiring anything extraordinary.
A command prompt will come up asking for the user input. The User only needs to type a set of integers separated by commas, such as 15,1,20,33,5. The app will analyse such input and return the values in the console after running through it using a post-order traversal.
To close the application just type close.
