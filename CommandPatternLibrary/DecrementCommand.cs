namespace CommandPatternDemo
{
    public class DecrementCommand : ICommand
    {
        private Calculator _calculator;

        public DecrementCommand(Calculator calculator)
        {
            _calculator = calculator;
        }

        public void Execute()
        {
            _calculator.Result -= 1;
        }

        public void Undo()
        {
            _calculator.Result += 1;
        }

        public string Name => "decrement";
    }
}