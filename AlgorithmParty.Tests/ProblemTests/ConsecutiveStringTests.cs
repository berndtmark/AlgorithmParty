using System;
using AlgorithmParty.Problems.Consecutive;
using NUnit.Framework;

namespace AlgorithmParty.Tests
{
    [TestFixture]
    public class ConsecutiveStringTests
    {
        [Test]
        [TestCase("12345", true)]
        [TestCase("54321", true)]
        [TestCase("1345", false)]
        [TestCase("76531", false)]
        [TestCase("12321", false)]
        public void ConsecutiveString_RawString(string s, bool isConsecutive)
        {
            var result = ConsecutiveString.IsConsecutive(s);

            Assert.AreEqual(result, isConsecutive);
        }

        [Test]
        [TestCase("1-2-3-4-5", true)]
        [TestCase("5-4-3-2-1", true)]
        [TestCase("1-3-4-5", false)]
        [TestCase("7-6-5-3-1", false)]
        [TestCase("1-2-3-2-1", false)]
        [TestCase("10-9-8", true)]
        public void ConsecutiveString_WithDeliminator_RawString(string s, bool isConsecutive)
        {
            var result = ConsecutiveString.IsConsecutive(s, '-');

            Assert.AreEqual(result, isConsecutive);
        }

        [Test]
        [TestCase("12345", true)]
        [TestCase("8910", true)]
        //[TestCase("1098", true)]
        [TestCase("1087", false)]
        public void ConsecutiveString_WithSpacing_RawString(string s, bool isConsecutive)
        {
            var result = ConsecutiveString.IsConsecutiveWithSpacing(s);

            Assert.AreEqual(result, isConsecutive);
        }
    }
}
