using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HashTableVisualization;

internal class HashTableState<TValue>
{
    public int Capacity { get; }
    public Node<TValue>[] Buckets { get; }
    /// <summary>
    /// Конструктор для Сериализатора 
    /// </summary>
    [JsonConstructor]
    public HashTableState(int Capacity, Node<TValue>[] Buckets)
    {
        this.Capacity = Capacity;
        this.Buckets = Buckets;
    }
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

        Node<TValue> newNode = new Node<TValue>(node.Key, node.Value, node.IsHighlighted)
        {
            Left = CopyTree(node.Left),
            Right = CopyTree(node.Right)
        };
        return newNode;
    }
}
