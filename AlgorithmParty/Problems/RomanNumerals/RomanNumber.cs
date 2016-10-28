using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmParty.Problems.RomanNumerals
{
    public class RomanNumber
    {
        public RomanNumber(char character, int numericValue, int consecutiveRepeats, bool canSubtract)
        {
            Character = character;
            NumericValue = numericValue;
            ConsecutiveRepeats = consecutiveRepeats;
            CanSubtract = canSubtract;
        }

        public char Character { get; set; }

        public int NumericValue { get; set; }

        public int ConsecutiveRepeats { get; set; }

        public bool CanSubtract { get; set; }
    }
}
