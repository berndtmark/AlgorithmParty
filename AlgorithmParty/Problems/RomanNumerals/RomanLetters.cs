using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmParty.Problems.RomanNumerals
{
    public static class RomanLetters
    {
        public static Dictionary<char, int> RomanNumerals = new Dictionary<char, int>() {
             { 'I', 1 },
             { 'V', 5 },
             { 'X', 10 },
             { 'L', 50 },
             { 'C', 100 },
             { 'D', 500 },
             { 'M', 1000 },
            };

        public static List<RomanNumber> RomanNumbers = new List<RomanNumber>()
        {
            new RomanNumber('I', 1, 3, true),
            new RomanNumber('V', 5, 1, false),
            new RomanNumber('X', 10, 3, true),
            new RomanNumber('L', 50, 1, false),
            new RomanNumber('C', 100, 3, true),
            new RomanNumber('D', 500, 1, false),
            new RomanNumber('M', 1000, 3, false)
        };

        public static Dictionary<int, string> NumberRomans = new Dictionary<int, string>()
        {
            { 1000, "M" },
            { 900, "CM" },
            { 500, "D" },
            { 400, "CD" },
            { 100, "C" },
            { 90, "XC" },
            { 50, "L" },
            { 40, "XL" },
            { 10, "X" },
            { 9, "IX" },
            { 5, "V" },
            { 4, "IV" },
            { 1, "I" },
        };
    }
}
