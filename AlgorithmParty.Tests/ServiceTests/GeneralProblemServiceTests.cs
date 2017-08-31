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
    }
}
