using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmParty.Enum;

namespace AlgorithmParty.Models
{
    public class Node
    {
        public Node(Color color)
        {
            this.Color = color;
        }

        public Node()
        {

        }

        public Node NorthNode { get; set; }

        public Node SouthNode { get; set; }

        public Node WestNode { get; set; }

        public Node EastNode { get; set; }

        public Color Color { get; set; }

        // Used for alternative implementation
        public bool IsProcessesd { get; set; }
    }
}
