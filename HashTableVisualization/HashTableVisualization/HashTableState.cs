using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableVisualization;

internal class HashTableState<TValue>
{
    public int Capacity { get; }
    public Node<TValue>[] Buckets { get; }

    public HashTableState(HashTable<TValue> hashTable)
    {
        Capacity = hashTable.capacity;
        Buckets = new Node<TValue>[Capacity];

        for (int i = 0; i < Capacity; i++)
        {
            Buckets[i] = CopyTree(hashTable.GetRootNode(i));
        }
    }

    private Node<TValue> CopyTree(Node<TValue> node)
    {
        if (node == null) return null;

        var newNode = new Node<TValue>(node.Key, node.Value)
        {
            Left = CopyTree(node.Left),
            Right = CopyTree(node.Right)
        };
        return newNode;
    }

    //public void Restore(HashTable<TValue> hashTable)
    //{
    //    hashTable.Clear();
    //    for (int i = 0; i < Capacity; i++)
    //    {
    //        hashTable.SetRootNode(i, CopyTree(Buckets[i]));
    //    }
    //}
}
