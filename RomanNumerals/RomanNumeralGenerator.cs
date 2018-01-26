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

        public string GenerateRomanNumeral(int value)
        {
            string romanNumeral = string.Empty;
            for (int i = 1; i <= value; i++)
            {
                romanNumeral += ONE_VALUE;
            }
            return romanNumeral;
        }
    }
}
