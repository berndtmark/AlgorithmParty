using System;
using System.Collections.Generic;
using AlgorithmParty.Models;
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
            var expectedResults = new string[] { "ABC", "ACB", "BAC", "BCA", "CAB", "CBA" };
            var results = RecursionService.GetStringPermutations("ABC");

            CollectionAssert.AreEquivalent(expectedResults, results);
        }

        [Test]
        public void GetTreeCount()
        {
            var tree = new List<Tree>() {
                new Tree()
                {
                    Id = 1,
                    Count = 2,
                    Leaves = new List<Tree>() {
                         new Tree() {
                             Id = 3, Count = 3,
                             Leaves = new List<Tree>() {
                                 new Tree() {
                                     Id = 4, Count = 1
                                 }
                             }
                         }
                    }
                }
            };

            var results = RecursionService.TreeCount(tree);

            Assert.AreEqual(6, results);
        }
    }
}
