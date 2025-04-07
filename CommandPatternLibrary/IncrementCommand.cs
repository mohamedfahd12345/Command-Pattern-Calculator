namespace CommandPatternDemo
{
    public class IncrementCommand : ICommand
    {
        private Calculator _calculator;

        public IncrementCommand(Calculator calculator)
        {
            _calculator = calculator;
        }

        public void Execute()
        {
            _calculator.Result += 1;
        }

        public void Undo()
        {
            _calculator.Result -= 1;
        }

        public string Name => "increment";
    }
}