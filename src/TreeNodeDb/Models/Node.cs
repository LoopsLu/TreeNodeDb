using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TreeNodeDb.Models
{
    public class Node
    {
        public string NodeId { get; set; }
        public string Name { get; set; }

        public string ParentId { get; set; }
        public Node Parent { get; set; }

        public ICollection<Node> Children { get; set; }
    }
}
