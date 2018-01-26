using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    public class RomanNumeralGenerator
    {
        private List<RomanNumeralValue> _romanNumeralValues;

        public RomanNumeralGenerator()
        {
            _romanNumeralValues = new List<RomanNumeralValue>()
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
            }


            return romanNumeral;
        }

        private string addValueToString(RomanNumeralValue romanNumeralValue, ref int currentValue)
        {
            currentValue -= romanNumeralValue.Value;
            return romanNumeralValue.Symbol;
        }
        //private void AddValueOfOneToRomanNumeral()
        //{
        //    string threeOnes = ONE_VALUE + ONE_VALUE + ONE_VALUE;
            
        //    if(!_romanNumeral.Contains(threeOnes))
        //        _romanNumeral += ONE_VALUE;
        //    else
        //    {
        //        _romanNumeral = string.Empty;
        //        _romanNumeral += ONE_VALUE;
        //        _romanNumeral += FIVE_VALUE;
        //    }
        //}

    }
}
