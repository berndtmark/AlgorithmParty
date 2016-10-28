using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmParty.Services
{
    public class ClosureService
    {
        public static Func<int, int> ClosureDelegate()
        {
            var myVar = 1;

            Func<int, int> inc = delegate(int var1)
            {
                myVar = myVar + 1;
                return var1 + myVar;
            };

            return inc;
        }

        public static Func<int, int> ClosureLambda()
        {
            var myVar = 1;

            Func<int, int> inc = var1 => (var1 + (++myVar));

            return inc;
        }
    }
}
