using System;
using System.ComponentModel.DataAnnotations;
using FluentAssertions;
using kata1;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void WhenGettingTheSumOfMultiplesOf3And5Below10()
        {
            var multiplesCalculator = new MultiplesCalculator();
            int result = multiplesCalculator.Calculate(3, 5, 10);

            result.Should().Be(23);
        }

        [Fact]
        public void WhenGettingTheSumOfMultiplesOf3And5Below1000()
        {
            var multiplesCalculator = new MultiplesCalculator();
            int result = multiplesCalculator.Calculate(3, 5, 1000);

            result.Should().Be(233168);
        }
    }
}
