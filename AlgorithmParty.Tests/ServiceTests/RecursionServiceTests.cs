using System;
using AlgorithmParty.Services;
using NUnit.Framework;

namespace AlgorithmParty.Tests
{
    [TestFixture]
    public class RecursionServiceTests
    {
        [Test]
        public void Depends()
        {
            var result = RecursionService.Depends("XYZ");

            Assert.AreEqual("X depends on Y depends on Z", result);
        }

        [Test]
        public void GetStringPermutations()
        {
            var expectedResults = new string [] { "ABC", "ACB", "BAC", "BCA", "CAB", "CBA" };
            var results = RecursionService.GetStringPermutations("ABC");

            CollectionAssert.AreEquivalent(expectedResults, results);
        }
    }
}
