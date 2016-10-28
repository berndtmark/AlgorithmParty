using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmParty.Services
{
    public class ArrayJoinService
    {
        public static int[] InnerJoin(int[] arr1, int[] arr2)
        {
            var result = from l1 in arr1
                         join l2 in arr2 on
                         l1 equals l2
                         select l2;

            return result.ToArray();
        }

        public static int[] LeftJoin(int[] arr1, int[] arr2)
        {
            var result = from l1 in arr1
                         join l2 in arr2 on
                         l1 equals l2 into r
                         from r2 in r.DefaultIfEmpty()
                         select l1;

            return result.ToArray();
        }

        public static int[] InnerJoinWithoutLinq(int[] arr1, int[] arr2)
        {
            var results = new List<int>();

            for (int i = 0; i <= arr1.Length; i++)
            {
                if (arr2.Contains(i))
                {
                    results.Add(i);
                }
            }

            return results.ToArray();
        }
    }
}
