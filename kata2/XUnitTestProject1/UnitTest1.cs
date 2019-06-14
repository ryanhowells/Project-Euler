using System;
using FluentAssertions;
using kata2;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var calculateFibonacciSequence = new CalculateFibonacciSequence();
            int sum = calculateFibonacciSequence.Calculate(10);

            sum.Should().Be(10);
        }

        [Fact]
        public void Test2()
        {
            var calculateFibonacciSequence = new CalculateFibonacciSequence();
            int sum = calculateFibonacciSequence.Calculate(4000000);

            sum.Should().Be(4613732);
        }
    }
}
