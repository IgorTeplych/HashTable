using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class Node : IComparable<Node>
    {
        public Node(int key)
        {
            Key = key;
        }
        public Node(Node node)
        {
            Key = node.Key;
            Child = node.Child;
        }
        public int Key { get; set; }
        public Node Child { get; set; }

        public int CompareTo(Node? other)
        {
            return this.Key - other.Key;
        }
    }
}
