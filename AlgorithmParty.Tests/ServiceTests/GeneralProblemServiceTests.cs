using AlgorithmParty.Services;
using NUnit.Framework;

namespace AlgorithmParty.Tests.ServiceTests
{
    [TestFixture]
    public class GeneralProblemServiceTests
    {
        [Test]
        public void GetTimeWithMostUsers_CorrectTimeReturned()
        {            
            var result = GeneralProblemService.GetTimeWithMostUsers();

            Assert.AreEqual(4, result);
        }

        [Test]
        [TestCase("(()", 1)]
        [TestCase("(())", 2)]
        [TestCase("(((", 0)]
        [TestCase("((", 0)]
        [TestCase(")((()", 1)]
        [TestCase("12sd)(1112((ad)", 1)]
        public void MatchingParentheses_CorrectValueReturned(string str, int expectedResult)
        {
            var result = GeneralProblemService.MatchingParentheses(str);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
