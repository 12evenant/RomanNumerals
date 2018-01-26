using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RomanNumeralTests
{
    public class RomanNumeralTest
    {
        [Theory]
        [InlineData(1, "I")]
        public void WhenAValueIsPassedItOutputsTheRomanNumeralVersionOfThatNumber(int value, string expectedValue)
        {
            RomanNumeralGenerator romanNumeralGenerator = new RomanNumeralGenerator();

            string actualValue = romanNumeralGenerator.GenerateRomanNumeral(value);

            Assert.Equal(expectedValue, actualValue);
        }
    }
}
