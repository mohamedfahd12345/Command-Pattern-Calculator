# Command Pattern Calculator

A C# console application demonstrating the Command Design Pattern with undo functionality.

## Overview

This application implements a simple calculator that maintains a result value and modifies it based on user commands. The program showcases how the Command Pattern can be used to encapsulate operations as objects, allowing for features like command history and undo capability.

## Features

- **Command-based operations**: Each operation is implemented as a separate command class
- **Undo functionality**: Revert the most recent command
- **Extensible architecture**: Easily add new commands by implementing the `ICommand` interface

## Supported Commands

- `increment`: Increases the result value by 1
- `decrement`: Decreases the result value by 1
- `double`: Doubles the result value
- `randadd`: Changes the result by a random number between -10 and 10
- `undo`: Reverts the most recent command that is not an undo and was not yet undone
- `exit`: Terminates the program

## Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (6.0 or newer)
- A terminal or command prompt

## Project Structure

```
CommandPatternSolution/
├── CommandPatternSolution.sln
├── CommandPatternConsoleApp/
│   ├── CommandPatternConsoleApp.csproj
│   └── Program.cs
└── CommandPatternLibrary/
    ├── CommandPatternLibrary.csproj
    ├── ICommand.cs
    ├── Calculator.cs
    ├── CommandProcessor.cs
    ├── IncrementCommand.cs
    ├── DecrementCommand.cs
    ├── DoubleCommand.cs
    └── RandomAddCommand.cs
```

The solution follows a clean architecture with:
- **CommandPatternLibrary**: Contains the core command pattern implementation
- **CommandPatternConsoleApp**: The console interface that uses the library

## How to Run

### From Command Line

1. Navigate to the solution directory
2. Change to the console app directory:
   ```
   cd CommandPatternConsoleApp
   ```
3. Run the application with an initial value:
   ```
   dotnet run 5
   ```

### From Visual Studio

1. Open `CommandPatternSolution.sln` in Visual Studio
2. Right-click on `CommandPatternConsoleApp` project in Solution Explorer
3. Select "Properties"
4. Go to "Debug" tab
5. In the "Command line arguments" field, enter your initial value (e.g., "5")
6. Press F5 or click the "Start" button to run

## Example Usage

```
Initial value: 5
Enter command (increment, decrement, double, randadd, undo, exit): increment
Result: 6
Enter command (increment, decrement, double, randadd, undo, exit): double
Result: 12
Enter command (increment, decrement, double, randadd, undo, exit): undo
Result: 6
Enter command (increment, decrement, double, randadd, undo, exit): exit
```

## Design Patterns Used

- **Command Pattern**: Encapsulates operations as objects
- **Factory Pattern**: Creates command instances based on user input
