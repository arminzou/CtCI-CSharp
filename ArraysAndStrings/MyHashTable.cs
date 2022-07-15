using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice
{
    // Hash table implementation
    public class Node
    {
        public string Key { get; set; }
        public object Value { get; set; }
        public Node Next { get; set; }
    }

    public class MyHashTable
    {
        private readonly Node[] map;
        private readonly int tableSize;

        public MyHashTable(int size)
        {
            tableSize = size;
            map = new Node[size];
        }

        private int HashFunction(string key)
        {
            int index = 7;
            int asciiVal = 0;
            for (int i = 0; i < key.Length; i++)
            {
                asciiVal = (int)key[i] * i;
                index = index * 31 + asciiVal;
            }
            return index % tableSize;
        }
        public void Insert(string key, object value)
        {
            int index = HashFunction(key);
            Node node = map[index];

            if (node == null)
            {
                map[index] = new Node() { Key = key, Value = value };
                return;
            }

            if (node.Key == key)
                throw new Exception("Can't use same key!");

            while (node.Next != null)
            {
                node = node.Next;
                if (node.Key == key)
                    throw new Exception("Can't use same key!");
            }
            Node newNode = new Node() { Key = key, Value = value, Next = null };
            node.Next = newNode;
        }
        public object GetValue(string key)
        {
            int index = HashFunction(key);
            Node node = map[index];
            while (node != null)
            {
                if (node.Key == key)
                {
                    return node.Value;
                }
                node = node.Next;
            }
            throw new Exception("Don't have the key in hash!");
        }
    }
}
