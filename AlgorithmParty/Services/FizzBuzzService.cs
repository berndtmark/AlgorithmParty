using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmParty.Services
{
    public class FizzBuzzService
    {
        public void FizzBuzz()
        {
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Buzz");
                }
                else 
                {
                    Console.Write(i);
                }

                Console.WriteLine();
            }
        }

        public List<string> FizzBuzzAdvanced(int fizzNum, int buzzNum, int length)
        {
            var fizzList = new List<string>();

            for (int i = 1; i < length; i++)
            {
                var result = string.Empty;

                if (i % fizzNum == 0)
                {
                    result += "Fizz";
                }
                if (i % buzzNum == 0)
                {
                    result += "Buzz";
                }

                if (string.IsNullOrEmpty(result))
                {
                    result = i.ToString();
                }

                fizzList.Add(result);
            }

            return fizzList;
        }
    }
}
