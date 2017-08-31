using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmParty.Enum;
using AlgorithmParty.Models;

namespace AlgorithmParty.Tests.Factories
{
    public static class NodeModelFactory
    {
        public static Node SimpleNode()
        {
            var baseNode = new Node(Color.Blue);

            baseNode.WestNode = new Node(Color.Blue);
            baseNode.EastNode = new Node(Color.Blue);
            baseNode.NorthNode = new Node(Color.Blue);
            baseNode.SouthNode = new Node(Color.Blue);

            baseNode.SouthNode.WestNode = new Node(Color.Blue);
            baseNode.SouthNode.EastNode = new Node(Color.Blue);
            baseNode.SouthNode.NorthNode = new Node(Color.Blue);

            return baseNode;
        }
    }
}
