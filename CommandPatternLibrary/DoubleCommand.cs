namespace CommandPatternDemo
{
    public class DoubleCommand : ICommand
    {
        private Calculator _calculator;
        private int _previousValue;

        public DoubleCommand(Calculator calculator)
        {
            _calculator = calculator;
        }

        public void Execute()
        {
            _previousValue = _calculator.Result;
            _calculator.Result *= 2;
        }

        public void Undo()
        {
            _calculator.Result = _previousValue;
        }

        public string Name => "double";
    }
}