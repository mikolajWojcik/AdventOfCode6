using System.Collections.Generic;
using AdventOfCode6;
using Xunit;

namespace TestProject
{
    public class FishTest
    {
        [Theory]
        [InlineData(3,3,1)]
        [InlineData(8,8,1)]
        [InlineData(3,6,2)]
        [InlineData(3,18,5)]
        [InlineData(4,18,4)]
        [InlineData(2,18,5)]
        public void GetTotalNumber_Time_Days(int time, int days, int expected)
        {
            //arrange
            var fish = new Fish(time);
            
            //act
            var result = fish.GetTotalNumberOfFishes(days);
            
            //assert
            Assert.Equal(expected, result);
        }
    }
}