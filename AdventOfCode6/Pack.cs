using System;
using System.Collections.Generic;

namespace AdventOfCode6
{
    public class Pack
    {
        private readonly List<Fish> _fishes;

        public Pack(List<Fish> fishes)
        {
            _fishes = fishes;
        }

        public long PassDays(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                PassDay();
                
                Console.WriteLine($"After {i} day: {_fishes.Count}");
            }

            return _fishes.Count;
        }
        
        public int PassDay()
        {
            var newFishes = new List<Fish>();
            
            foreach (var fish in _fishes)
            {
                var result = fish.PassDay();
                if (result != null)
                {
                    newFishes.Add(result);
                }
            }
            
            _fishes.AddRange(newFishes);

            return _fishes.Count;
        }
        
        public long PassDaysFast(int number)
        {
            long result = 0;

            for (int i = 0; i < _fishes.Count; i++)
            {
                var fishResult = _fishes[i].GetTotalNumberOfFishes(number);
                Console.WriteLine($"For fish number {i} result is {fishResult}");
                result += fishResult;
            }

            return result;
        }
    }
}