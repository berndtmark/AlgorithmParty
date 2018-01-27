using System;
using AlgorithmParty.Enum;
using AlgorithmParty.Service;
using AlgorithmParty.Tests.Factories;
using NUnit.Framework;

namespace AlgorithmParty.Tests
{
    [TestFixture]
    public class FloodFillServiceTest
    {
        [Test]
        public void FloodFillService_WithValidData()
        {
            // Arrange
            var node = NodeModelFactory.SimpleNode();

            // Act
            FloodFillService.FloodFill(node, Color.Blue, Color.Red);
            
            // Assert
            Assert.IsTrue(node.SouthNode.NorthNode.Color == Color.Red);
        }

        [Test]
        public void FloodFillQueueImplementation_WithValidData()
        {
            // Arrange
            var node = NodeModelFactory.SimpleNode();

            // Act
            FloodFillService.FloodFillQueueImplementation(node, Color.Blue, Color.Red);

            // Assert
            Assert.IsTrue(node.SouthNode.NorthNode.Color == Color.Red);
        }
    }
}
