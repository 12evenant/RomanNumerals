using RomanNumerals;
using Xunit;

namespace RomanNumeralTests
{
    public class RomanNumeralTest
    {
        [Theory]
        [InlineData(1, "I")]
        [InlineData(3,"III")]
        [InlineData(4,"IV")]
        [InlineData(5,"V")]
        public void WhenAValueIsPassedItOutputsTheRomanNumeralVersionOfThatNumber(int value, string expectedValue)
        {
            RomanNumeralGenerator romanNumeralGenerator = new RomanNumeralGenerator();

            string actualValue = romanNumeralGenerator.GenerateRomanNumeral(value);

            Assert.Equal(expectedValue, actualValue);
        }
    }
}
