using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmParty.Enum;
using AlgorithmParty.Models;

namespace AlgorithmParty.Service
{
    public static class FloodFillService
    {
        public static void FloodFill(NodeModel node, Color targetColor, Color replacementColor)
        {
            // Catch those empty node ends
            if (node == null)
            {
                return;
            }

            // Already been replaced
            if (targetColor == replacementColor)
            {
                return;
            }

            // Don't change anything else
            if (node.Color != targetColor)
            {
                return;
            }

            node.Color = replacementColor;

            FloodFill(node.SouthNode, targetColor, replacementColor);
            FloodFill(node.NorthNode, targetColor, replacementColor);
            FloodFill(node.WestNode, targetColor, replacementColor);
            FloodFill(node.EastNode, targetColor, replacementColor);

            return;
        }

        public static void FloodFillQueueImplementation(NodeModel node, Color targerColor, Color replacementColor)
        {
            if (targerColor == replacementColor)
            {
                return;
            }

            var q = new Queue<NodeModel>();

            q.Enqueue(node);

            while (q.Any())
            {
                var n = q.Dequeue();

                if (n.Color == targerColor)
                {
                    n.Color = replacementColor;
                    n.IsProcessesd = true;

                    if (n.WestNode != null && !n.WestNode.IsProcessesd)
                    {
                        q.Enqueue(n.WestNode);
                    }

                    if (n.EastNode != null && !n.EastNode.IsProcessesd)
                    {
                        q.Enqueue(n.EastNode);
                    }

                    if (n.NorthNode != null && !n.NorthNode.IsProcessesd)
                    {
                        q.Enqueue(n.NorthNode);
                    }

                    if (n.SouthNode != null && !n.SouthNode.IsProcessesd)
                    {
                        q.Enqueue(n.SouthNode);
                    }
                }
            }

            return;
        }
    }
}
