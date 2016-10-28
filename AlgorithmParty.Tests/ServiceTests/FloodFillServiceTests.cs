using System;
using AlgorithmParty.Enum;
using AlgorithmParty.Service;
using AlgorithmParty.Tests.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmParty.Tests
{
    [TestClass]
    public class FloodFillServiceTest
    {
        [TestMethod]
        public void FloodFillService_WithValidData()
        {
            // Arrange
            var node = NodeModelFactory.SimpleNode();

            // Act
            FloodFillService.FloodFill(node, Color.Blue, Color.Red);
            
            // Assert
            Assert.IsTrue(node.SouthNode.NorthNode.Color == Color.Red);
        }

        [TestMethod]
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
