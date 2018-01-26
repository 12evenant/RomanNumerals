using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    public class RomanNumeralGenerator
    {
        private const string ONE_VALUE = "I";
        private const string FIVE_VALUE = "V";

        private string _romanNumeral;

        public RomanNumeralGenerator()
        {
            _romanNumeral = string.Empty;
        }

        public string GenerateRomanNumeral(int value)
        {
            while (value >= 5)
            {
                AddValueOfFiveToRomanNumeral();
                value -= 5;
            }
            while (value > 0)
            {
                AddValueOfOneToRomanNumeral();
                value--;
            }

            return _romanNumeral;
        }

        private void AddValueOfOneToRomanNumeral()
        {
            _romanNumeral += ONE_VALUE;
        }

        private void AddValueOfFiveToRomanNumeral()
        {
            _romanNumeral += FIVE_VALUE;
        }
    }
}
