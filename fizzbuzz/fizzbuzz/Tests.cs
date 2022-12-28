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
    }
}