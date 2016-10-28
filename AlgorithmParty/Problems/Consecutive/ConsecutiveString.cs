using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmParty.Problems.Consecutive
{
    public class ConsecutiveString
    {
        [Obsolete]
        public static bool IsConsecutive(string s)
        {
            int? lastNumber = null;
            bool? isUp = null;

            for (int i = 0; i < s.Length; i++)
            {
                var chararter = s[i];
                int value;

                if (int.TryParse(chararter.ToString(), out value))
                {
                    if (lastNumber.HasValue)
                    {
                        var lastValue = lastNumber.Value;

                        if (value == (lastValue + 1) && (!isUp.HasValue || (isUp.HasValue && isUp.Value)))
                        {
                            isUp = true;
                        }
                        else if (value == (lastValue - 1) && (!isUp.HasValue || (isUp.HasValue && !isUp.Value)))
                        {
                            isUp = false;
                        }
                        else
                        {
                            return false;
                        }
                    }

                    lastNumber = value;
                }
                else
                {
                    throw new ArgumentException("Not a valid number");
                }
            }

            return true;
        }

        public static bool IsConsecutive(string s, char deliminator)
        {
            int? lastNumber = null;
            bool? isUp = null;

            foreach (string num in s.Split(deliminator))
            {
                int value;

                if (int.TryParse(num, out value))
                {
                    if (lastNumber.HasValue)
                    {
                        var lastValue = lastNumber.Value;

                        if (value == (lastValue + 1) && (!isUp.HasValue || (isUp.HasValue && isUp.Value)))
                        {
                            isUp = true;
                        }
                        else if (value == (lastValue - 1) && (!isUp.HasValue || (isUp.HasValue && !isUp.Value)))
                        {
                            isUp = false;
                        }
                        else
                        {
                            return false;
                        }
                    }

                    lastNumber = value;
                }
                else
                {
                    throw new ArgumentException("Not a valid number");
                }
            }

            return true;
        }

        // needs work
        public static bool IsConsecutiveWithSpacing(string s)
        {
            int? lastNumber = null;
            bool? isUp = null;
            int spacing = 1;
            bool resetLastNum = false;
            int remainingLetters = s.Length;
            int index = 0;

            while (remainingLetters > 0)
            {  
                var chararter = s.Substring(index, spacing);
                remainingLetters = (s.Length - index - spacing);

                int value;

                if (int.TryParse(chararter.ToString(), out value))
                {
                    if (lastNumber.HasValue)
                    {
                        var lastValue = lastNumber.Value;

                        if (value == (lastValue + 1) && (!isUp.HasValue || (isUp.HasValue && isUp.Value)))
                        {
                            if ((value + 1).ToString().Length > lastNumber.ToString().Length)
                            {
                                spacing++;
                            }

                            isUp = true;
                        }
                        else if (value == (lastValue - 1) && (!isUp.HasValue || (isUp.HasValue && !isUp.Value)))
                        {
                            if ((value - 1).ToString().Length < lastNumber.ToString().Length)
                            {
                                spacing--;
                            }

                            isUp = false;
                        }
                        else
                        {
                            // increase the spacing lookup
                            if (remainingLetters > 0)
                            {
                                spacing++;
                                index = 0;
                                resetLastNum = true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }

                    if (resetLastNum)
                    {
                        lastNumber = null;
                        resetLastNum = false;
                    }
                    else
                    {
                        index++;
                        lastNumber = value;
                    }                    
                }
                else
                {
                    throw new ArgumentException("Not a valid number");
                }
            }

            return true;
        }
    }
}
