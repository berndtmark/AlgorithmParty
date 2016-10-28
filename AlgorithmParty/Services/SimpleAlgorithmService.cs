using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmParty.Services
{
    public class SimpleAlgorithmService
    {
        public static bool IsPalindrome(int a)
        {
            var revNum = 0;
            var num = a;
            int depth = 1;

            while (num > 0)
            {
                var lastDig = num % 10;
                revNum += lastDig * depth;

                num = num / 10;
                depth *= 10;
            }

            return a == revNum;
        }

        public static int GetFactorial(int num)
        {
            if (num == 1)
            {
                return 1;
            }

            return num * GetFactorial(num - 1);
        }

        public static int GreatestCommonDivisor(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }

            int remainder = a % b;
            return GreatestCommonDivisor(b, remainder);
        }
    }
}
