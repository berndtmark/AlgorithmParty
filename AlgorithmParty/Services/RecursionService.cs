using AlgorithmParty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmParty.Services
{
    public class RecursionService
    {
        public static string Depends(string x)
        {
            if (x.Length > 1)
            {
                return x.First() + " depends on " + Depends(x.Substring(1, x.Length - 1));
            }

            return x;
        }

        #region String Permutations
        public static string[] GetStringPermutations(string str)
        {
            return GetStringPermutations(str.ToArray(), 0, str.Length - 1, new List<string>());
        }

        private static string[] GetStringPermutations(char[] str, int startIndex, int endIndex, List<string> results)
        {
            if (startIndex == endIndex)
            {
                string s = new string(str);
                results.Add(s.ToString());
            }
            else
            {
                for (int i = startIndex; i <= endIndex; i++)
                {
                    Swap(ref str[startIndex], ref str[i]);
                    GetStringPermutations(str, startIndex + 1, endIndex, results);
                    Swap(ref str[startIndex], ref str[i]);
                }
            }

            return results.ToArray();
        }

        private static void Swap(ref char a, ref char b)
        {
            var temp = a;
            a = b;
            b = temp;
        } 
        #endregion

        public static int TreeCount(IList<Tree> tree)
        {
            foreach (var item in tree)
            {
                if (item.Leaves == null)
                {
                    return item.Count;
                }

                return item.Count + TreeCount(item.Leaves);
            }

            return 0;
        }
    }
}
