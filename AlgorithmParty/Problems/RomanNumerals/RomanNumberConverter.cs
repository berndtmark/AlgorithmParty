using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmParty.Problems.RomanNumerals
{
    public class RomanNumberConverter
    {
        [Obsolete]
        public static int ToNumber(string num)
        {
            var total = 0;

            for (var i = 0; i < num.Length; i++)
            {
                var letter = num[i];

                if (!RomanLetters.RomanNumerals.ContainsKey(letter))
                {
                    throw new ArgumentException("An unsupported character was received");
                }

                var value = RomanLetters.RomanNumerals[letter];
                var prevValue = i > 0 ? RomanLetters.RomanNumerals[num[i - 1]] : 0;

                if (prevValue > 0 && prevValue < value)
                {
                    total -= prevValue;
                    total += (value - prevValue);
                }
                else
                {
                    total += value;
                }
            }

            return total;
        }

        public static int ToNumberWithValidation(string num)
        {
            var total = 0;
            var lastSubtraction = 0;

            for (var i = 0; i < num.Length; i++)
            {
                if (!IsRomanValid(num, i, lastSubtraction))
                {
                    throw new ArgumentException("The roman number is not valid");
                }

                var letter = num[i];
                var value = RomanLetters.RomanNumbers.Where(r => r.Character == letter).First().NumericValue;
                var prevValue = i > 0 ? RomanLetters.RomanNumbers.Where(r => r.Character == num[i - 1]).First().NumericValue : 0;

                if (prevValue > 0 && prevValue < value)
                {
                    total -= prevValue;
                    total += (value - prevValue);

                    lastSubtraction = prevValue;
                }
                else
                {
                    total += value;
                }
            }

            return total;
        }

        public static bool IsRomanValid(string num, int currentIndex, int lastSubtraction)
        {
            var letter = num[currentIndex];

            // Check Char is valid
            if (!RomanLetters.RomanNumbers.Select(r => r.Character).Contains(letter))
            {
                return false;
            }

            var current = RomanLetters.RomanNumbers.Where(r => r.Character == num[currentIndex]).First();

            // Check for consecutives
            int count = 1;    
            if (currentIndex >= current.ConsecutiveRepeats)
            {
                for (int i = 1; i <= current.ConsecutiveRepeats; i++)
                {
                    var priorNum = RomanLetters.RomanNumbers.Where(r => r.Character == num[currentIndex - i]).First();

                    if (priorNum.Character == current.Character)
                    {
                        count++;
                    }
                }

                if (count > current.ConsecutiveRepeats)
                {
                    return false;
                } 
            }

            if (currentIndex > 0)
            {
                // Can prior be subtracted
                var prior = RomanLetters.RomanNumbers.Where(r => r.Character == num[currentIndex - 1]).First();
                if (prior.NumericValue < current.NumericValue && !prior.CanSubtract)
                {
                    if (!prior.CanSubtract)
                    {
                        return false;
                    }

                    if (prior.NumericValue / current.NumericValue >= 0.1)
                    {
                        return false;
                    }
                }

                if (lastSubtraction > 0 && current.NumericValue > lastSubtraction)
                {
                    return false;
                }

                if (currentIndex > 1)
                {
                    var priorPrior = RomanLetters.RomanNumbers.Where(r => r.Character == num[currentIndex - 2]).First();

                    if ((current.NumericValue - prior.NumericValue) > priorPrior.NumericValue)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static string ToRoman(int num)
        {
            var total = string.Empty;

            foreach (var item in RomanLetters.NumberRomans)
            {
                while (num >= item.Key)
                {
                    total += item.Value;
                    num -= item.Key;
                }
            }

            return total;
        }
    }
}
