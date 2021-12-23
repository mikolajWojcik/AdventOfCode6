using System;
using System.Collections.Generic;
using AdventOfCode6;
using Xunit;

namespace TestProject
{
    public class PackTest
    {
        [Fact]
        public void Test1()
        {
            //arrange
            var fishes = new List<Fish>
            {
                new Fish(2),
                new Fish(3),
                new Fish(2),
                new Fish(0),
                new Fish(1)
            };
            var pack = new Pack(fishes);
            
            //act
            var result = pack.PassDay();
            
            //assert
            Assert.Equal(6, result);
        }
        
        [Fact]
        public void Test2()
        {
            //arrange
            var fishes = new List<Fish>
            {
                new Fish(3),
                new Fish(4),
                new Fish(3),
                new Fish(1),
                new Fish(2)
            };
            var pack = new Pack(fishes);
            
            //act
            var result = pack.PassDay();
            
            //assert
            Assert.Equal(5, result);
        }

        [Theory]
        [InlineData(18, 26)]
        [InlineData(80, 5934)]
        public void PassDaysFast_5Fishes(int days, int expected)
        {
            //arrange
            var fishes = new List<Fish>
            {
                new Fish(3),
                new Fish(4),
                new Fish(3),
                new Fish(1),
                new Fish(2)
            };
            var pack = new Pack(fishes);
            
            //act
            var result = pack.PassDaysFast(days);
            
            //assert
            Assert.Equal(expected, result);
        }
        
        [Theory]
        [InlineData(18, 26)]
        [InlineData(80, 5934)]
        [InlineData(256, 26984457539)]
        public void PastDays_5Fishes(int days, long expected)
        {
            //arrange
            var fishes = new List<Fish>
            {
                new Fish(3),
                new Fish(4),
                new Fish(3),
                new Fish(1),
                new Fish(2)
            };
            var pack = new Pack(fishes);
            
            //act
            var result = pack.PassDays(days);
            
            //assert
            Assert.Equal(expected, result);
        }
    }
}