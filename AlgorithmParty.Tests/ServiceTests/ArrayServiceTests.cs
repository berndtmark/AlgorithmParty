using AlgorithmParty.Services;
using NUnit.Framework;

namespace AlgorithmParty.Tests
{
    [TestFixture]
    public class ArrayServiceTests
    {
        [Test]
        public void InnerJoin_CorrectOutput()
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] arr2 = { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            var result = ArrayJoinService.InnerJoin(arr1, arr2);
            
            CollectionAssert.AreEqual(new int[] { 5, 6, 7, 8, 9, 10 }, result);
        }

        [Test]
        public void InnerJoinWithoutLinq_CorrectOutput()
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] arr2 = { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            var result = ArrayJoinService.InnerJoinWithoutLinq(arr1, arr2);

            CollectionAssert.AreEqual(new int[] { 5, 6, 7, 8, 9, 10 }, result);
        }

        [Test]
        public void LeftJoin_CorrectOutput()
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] arr2 = { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            var result = ArrayJoinService.LeftJoin(arr1, arr2);

            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, result);
        }
    }
}
