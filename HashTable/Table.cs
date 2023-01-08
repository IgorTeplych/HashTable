using BasicStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    internal class Table
    {
        FactorArray<Node> hashes;
        public Table()
        {
            hashes = new FactorArray<Node>();

        }

        public void Delete()
        {

        }
        public Node Search(int key)
        {
            int hash = GetHash(key);
            int count = 0; 
            Node H;
            while (count < hashes.Size && hashes.Get(count).Key != hash)
            {
                count++;
            }

            if(count >= hashes.Size)
                return null;

            H = hashes.Get(count);

            Node c = H.Child;
            while (c.Key != key)
            {
                c = c.Child;
            }
            return c;
        }
        public void Add(int key)
        {
            Add(new Node(key));
        }
        void Add(Node node)
        {
            Node hash = new Node(GetHash(node.Key));
            AddInTable(hash, node);
        }
        void AddInTable(Node hash, Node node)
        {
            Node searh = hashes.Search(hash, out bool result);
            if (result)
            {
                Node temp = searh;
                while(temp.Child != null)
                    temp = temp.Child;
                temp.Child = node;
            }
            else
            {
                searh.Child = node;
                hashes.Add(searh);
            }
        }

        int GetHash(int key)
        {
            return key % ((int)Math.Log10(key) + 1);
        }
    }
}
