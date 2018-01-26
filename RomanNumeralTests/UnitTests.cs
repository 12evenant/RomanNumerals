using System;
using Xunit;

namespace RomanNumeralTests
{

    public class UnitTests
    {
        [Theory]
        [InlineData(1,"I")]
        public void WhenIPassInAValueItReturnsARomanNumeral(int value, string expectedOutcome)
        {
            //arrange
            RomanNumeralGenerator romanNumeralGenerator = new RomanNumeralGenerator();

            //act 
            string actualOutcome = romanNumeralGenerator.GenerateRomanNumeral(value);

            //assert
            Assert.Equal(expectedOutcome, actualOutcome);
        }
    }
}
