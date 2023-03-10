using System;
using Xunit;

namespace fizzbuzz
{
    public class Tests
    {
        [Fact]
        public void ShouldReturn1Given1()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.GetFizzBuzz(1);
            Assert.Equal("1", result);
        }
        
        [Fact]
        public void ShouldReturnFizzWhenNumberIsDivisibleBy3()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.GetFizzBuzz(3);
            Assert.Equal("Fizz", result);
        }
        
        [Fact]
        public void ShouldReturnBuzzWhenNumberIsDivisibleBy5()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.GetFizzBuzz(5);
            Assert.Equal("Buzz", result);
        }
        
        [Fact]
        public void ShouldReturnFizzBuzzWhenNumberIsDivisibleBy3And5()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.GetFizzBuzz(15);
            Assert.Equal("FizzBuzz", result);
        }
        
        [Fact]
        public void ShouldReturnNumberWhenNumberIsNotDivisibleBy3Or5()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.GetFizzBuzz(7);
            Assert.Equal("7", result);
        }
    }
}