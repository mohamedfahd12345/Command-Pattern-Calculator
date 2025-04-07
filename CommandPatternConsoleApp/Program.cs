using System;
using System.Collections.Generic;
using CommandPatternDemo;

namespace CommandPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0 || !int.TryParse(args[0], out int initialValue))
            {
                Console.WriteLine("Please provide a valid number as the initial value.");
                return;
            }

            Calculator calculator = new Calculator(initialValue);
            CommandProcessor processor = new CommandProcessor();

            Dictionary<string, Func<ICommand>> commandFactory = new Dictionary<string, Func<ICommand>>(StringComparer.OrdinalIgnoreCase)
            {
                { "increment", () => new IncrementCommand(calculator) },
                { "decrement", () => new DecrementCommand(calculator) },
                { "double", () => new DoubleCommand(calculator) },
                { "randadd", () => new RandomAddCommand(calculator) }
            };

            Console.WriteLine($"Initial value: {calculator.Result}");

            while (true)
            {
                Console.Write("Enter command (increment, decrement, double, randadd, undo, exit): ");
                string input = Console.ReadLine().Trim().ToLower();

                if (input == "exit")
                {
                    break;
                }
                else if (input == "undo")
                {
                    processor.UndoLastCommand();
                }
                else if (commandFactory.ContainsKey(input))
                {
                    ICommand command = commandFactory[input]();
                    processor.ExecuteCommand(command);
                }
                else
                {
                    Console.WriteLine("Unknown command. Available commands: increment, decrement, double, randadd, undo, exit");
                    continue;
                }

                Console.WriteLine($"Result: {calculator.Result}");
            }
        }
    }
}