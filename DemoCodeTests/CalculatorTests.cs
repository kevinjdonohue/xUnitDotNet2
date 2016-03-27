using DemoCode;
using FluentAssertions;
using Xunit;

namespace DemoCodeTests
{
    public class CalculatorTests
    {
        [Fact]
        public void ShouldAddTwoNumbersCorrectly()
        {
            //arrange
            Calculator calculator = new Calculator();

            //act
            int result = calculator.Add(1, 1);

            //assert
            result.Should().Be(2);
        }
    }
}
