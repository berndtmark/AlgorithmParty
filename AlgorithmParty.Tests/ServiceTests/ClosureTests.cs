using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmParty.Services;
using NUnit.Framework;

namespace AlgorithmParty.Tests
{
    [TestFixture]
    public class ClosureTests
    {
        [Test]
        public void ClosureDelegate()
        {
            var result = ClosureService.ClosureDelegate();
         
            Assert.AreEqual(7, result(5));
            Assert.AreEqual(9, result(6));
        }

        [Test]
        public void ClosureLambda()
        {
            var result = ClosureService.ClosureLambda();

            Assert.AreEqual(7, result(5));
            Assert.AreEqual(9, result(6));
        }
    }
}
