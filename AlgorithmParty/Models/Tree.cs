using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmParty.Models
{
    public class Tree
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public IList<Tree> Leaves { get; set; }
    }
}
