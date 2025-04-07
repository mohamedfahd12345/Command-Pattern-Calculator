namespace CommandPatternDemo
{
    public interface ICommand
    {
        void Execute();
        void Undo();
        string Name { get; }
    }
}