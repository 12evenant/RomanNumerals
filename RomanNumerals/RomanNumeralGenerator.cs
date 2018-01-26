using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    public class RomanNumeralGenerator
    {
        private readonly List<RomanNumeralValue> _romanNumeralValues;
        private int _maxPossibleLetterNumberOfLetter = 3;

        public RomanNumeralGenerator()
        {
            _romanNumeralValues = new List<RomanNumeralValue>
            {
                new RomanNumeralValue
                {
                    Symbol = "I",
                    Value = 1
                },
                new RomanNumeralValue
                {
                    Symbol = "V",
                    Value = 5
                },
                new RomanNumeralValue
                {
                    Symbol = "X",
                    Value = 10
                }
            };
        }

        public string GenerateRomanNumeral(int value)
        {
            string romanNumeral = string.Empty;
            int currentValue = value;

            foreach (var romanNumeralValue in _romanNumeralValues.OrderByDescending(r => r.Value))
            {
                while (currentValue >= romanNumeralValue.Value)
                {
                    romanNumeral += addValueToString(romanNumeralValue, ref currentValue);
                }
                string symbolLimit =
                    string.Concat(Enumerable.Repeat(romanNumeralValue.Symbol, _maxPossibleLetterNumberOfLetter));


                var lowestPossibleRomanNumeral = _romanNumeralValues.OrderBy(r => r.Value).First();

                if ((romanNumeral.Contains(symbolLimit) && romanNumeral != symbolLimit) ||
                    value == romanNumeralValue.Value - lowestPossibleRomanNumeral.Value)
                {
                    romanNumeral = addValueToString(lowestPossibleRomanNumeral, ref currentValue) +
                                   addValueToString(romanNumeralValue, ref currentValue);

                }

            }

            return romanNumeral;
        }

        private string addValueToString(RomanNumeralValue romanNumeralValue, ref int currentValue)
        {
            currentValue -= romanNumeralValue.Value;
            return romanNumeralValue.Symbol;
        }

    }
}
