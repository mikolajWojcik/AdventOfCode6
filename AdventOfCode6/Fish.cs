namespace AdventOfCode6
{
    public class Fish
    {
        private static int[,] _calculatedResults = new int[256, 9];
        
        private int _time;

        public Fish(int time)
        {
            _time = time;
        }

        public Fish PassDay()
        {
            if (_time == 0)
            {
                _time = 6;
                return new Fish(8);
            }

            _time--;
            return null;
        }

        public int GetTotalNumberOfFishes(int number)
        {
            var result = 1;

            if (_calculatedResults[number, _time] != 0)
            {
                return _calculatedResults[number, _time];
            }

            for (int i = _time + 1; i <= number;  i += 7)
            {
                result += new Fish(8).GetTotalNumberOfFishes(number - i);
            }

            _calculatedResults[number, _time] = result;

            return result;
        }
    }
}