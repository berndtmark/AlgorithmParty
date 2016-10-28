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
        public static NodeModel SimpleNode()
        {
            var baseNode = new NodeModel(Color.Blue);

            baseNode.WestNode = new NodeModel(Color.Blue);
            baseNode.EastNode = new NodeModel(Color.Blue);
            baseNode.NorthNode = new NodeModel(Color.Blue);
            baseNode.SouthNode = new NodeModel(Color.Blue);

            baseNode.SouthNode.WestNode = new NodeModel(Color.Blue);
            baseNode.SouthNode.EastNode = new NodeModel(Color.Blue);
            baseNode.SouthNode.NorthNode = new NodeModel(Color.Blue);

            return baseNode;
        }
    }
}
