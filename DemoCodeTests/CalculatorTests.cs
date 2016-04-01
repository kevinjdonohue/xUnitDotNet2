using DemoCode;
using FluentAssertions;
using Xunit;

namespace DemoCodeTests
{
    public class CalculatorTests
    {
        [Fact]
        public void ShouldAddTwoIntegersCorrectly()
        {
            //arrange
            Calculator sut = new Calculator();

            //act
            int result = sut.AddInts(1, 2);

            //assert
            result.Should().Be(3, "because 1 plus 2 should equal 3");
        }

        [Fact]
        public void ShouldAddTwoDoublesCorrectly()
        {
            //arrange
            Calculator sut = new Calculator();

            //act
            double result = sut.AddDoubles(1.1, 2.2);

            //assert            
            result.Should().BeApproximately(3.3, .001, "because 1.1 plus 2.2 is approximately 3.3");
        }
    }
}
