using System;
using AlgorithmParty.Services;
using NUnit.Framework;

namespace AlgorithmParty.Tests.ServiceTests
{
    [TestFixture]
    public class FizzBuzzServiceTests
    {
        [Test]
        public void FizzBuzz_CorrectNumberOfOutputItems()
        {
            var fizzBuzz = new FizzBuzzService();
            fizzBuzz.FizzBuzz();

            var result = fizzBuzz.FizzBuzzAdvanced(3, 5, 100);

            Assert.AreEqual(99, result.Count);
        }

        [Test]
        public void FizzBuzz_CorrectFizzItems()
        {
            var fizzBuzz = new FizzBuzzService();
            fizzBuzz.FizzBuzz();

            var result = fizzBuzz.FizzBuzzAdvanced(3, 5, 100);

            Assert.AreEqual("Fizz", result[2]);
            Assert.AreEqual("Buzz", result[4]);
            Assert.AreEqual("FizzBuzz", result[14]);
        }
    }
}
