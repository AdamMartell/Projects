using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Node
    {
        public string value;
        public Node parent;
        public List<Node> children;
        public bool isRoot;

        public Node(string value)
        {
            this.value = value;
            this.parent = null;
            this.children = new List<Node>() { };
            this.isRoot = true;
        }

    }
}
