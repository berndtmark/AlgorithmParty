using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmParty.Enum;

namespace AlgorithmParty.Models
{
    public class NodeModel
    {
        public NodeModel(Color color)
        {
            this.Color = color;
        }

        public NodeModel()
        {

        }

        public NodeModel NorthNode { get; set; }

        public NodeModel SouthNode { get; set; }

        public NodeModel WestNode { get; set; }

        public NodeModel EastNode { get; set; }

        public Color Color { get; set; }

        // Used for alternative implementation
        public bool IsProcessesd { get; set; }
    }
}
