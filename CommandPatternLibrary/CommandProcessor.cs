using System.Collections.Generic;

namespace CommandPatternDemo
{
    public class CommandProcessor
    {
        private Stack<ICommand> _history = new Stack<ICommand>();

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _history.Push(command);
        }

        public void UndoLastCommand()
        {
            if (_history.Count > 0)
            {
                ICommand lastCommand = _history.Pop();
                lastCommand.Undo();
            }
            else
            {
                Console.WriteLine("Nothing to undo!");
            }
        }
    }
}