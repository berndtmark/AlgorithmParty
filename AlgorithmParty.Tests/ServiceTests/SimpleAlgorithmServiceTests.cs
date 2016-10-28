using System;
using AlgorithmParty.Services;
using NUnit.Framework;

namespace AlgorithmParty.Tests.ServiceTests
{
    [TestFixture]
    public class SimpleAlgorithmServiceTests
    {
        [Test]
        public void FactorialService_GetFactorial()
        {
            // Arrange
            var expectedValue = 120;

            // Act
            var num = SimpleAlgorithmService.GetFactorial(5);

            // Assert
            Assert.AreEqual(expectedValue, num);
        }

        [Test]
        [TestCase(10, 5, 5)]
        [TestCase(5, 10, 5)]
        public void GreatestCommonDivisor(int a, int b, int result)
        {
            var r = SimpleAlgorithmService.GreatestCommonDivisor(a, b);

            Assert.AreEqual(result, r);
        }

        public void IsPalindrome_IsPalindrome()
        {
            var result = SimpleAlgorithmService.IsPalindrome(12521);

            Assert.IsTrue(result);
        }
    }
}
