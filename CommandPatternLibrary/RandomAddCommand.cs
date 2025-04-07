namespace CommandPatternDemo
{
    public class RandomAddCommand : ICommand
    {
        private Calculator _calculator;
        private int _randomValue;
        private Random _random;

        public RandomAddCommand(Calculator calculator)
        {
            _calculator = calculator;
            _random = new Random();
        }

        public void Execute()
        {
            _randomValue = _random.Next(1, 11);
            _calculator.Result += _randomValue;
        }

        public void Undo()
        {
            _calculator.Result -= _randomValue;
        }

        public string Name => "randadd";
    }
}