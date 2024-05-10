﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableVisualization;

internal class HashTable<TValue>
{
    public int capacity { get; private set; }
    private int size;
    private BinaryTree<TValue>[] buckets;

    public HashTable(int capacity = 16)
    {
        this.capacity = capacity;
        buckets = new BinaryTree<TValue>[capacity];
        for (int i = 0; i < capacity; i++)
        {
            buckets[i] = new BinaryTree<TValue>();
        }
    }

    private int GetHash(string key) => Math.Abs(key.GetHashCode()) % capacity;

    public void Insert(string key, TValue value)
    {
        int hash = GetHash(key);
        if (buckets[hash].Root == null || buckets[hash].Find(key) == null)
        {
            size++;
        }
        buckets[hash].Insert(key, value);
        if (size > capacity * 0.75)
        {
            Resize();
        }
    }

    public bool Remove(string key)
    {
        int hash = GetHash(key);
        bool wasDeleted = buckets[hash].Remove(key);
        if (wasDeleted) 
            size--;
        return wasDeleted;
    }

    public Node<TValue>? Find(string key)
    {
        int hash = GetHash(key);
        return buckets[hash].Find(key);
    }

    private void Resize()
    {
        int newCapacity = capacity * 2;
        BinaryTree<TValue>[] oldBuckets = buckets;
        buckets = new BinaryTree<TValue>[newCapacity];
        for (int i = 0; i < newCapacity; i++)
        {
            buckets[i] = new BinaryTree<TValue>();
        }
        size = 0;
        for (int i = 0; i < capacity; i++)
        {
            BinaryTree<TValue> tree = oldBuckets[i];
            rehashTree(tree, tree.Root);
        }
        capacity = newCapacity;
    }
    private void rehashTree(BinaryTree<TValue> bst, Node<TValue>? node)
    {
        if (node == null) return;
        Insert(node.Key, node.Value);
        rehashTree(bst, node.Left);
        rehashTree(bst, node.Right);
    }

    internal Node<TValue>? GetRootNode(int i)
    {
        if (i < 0 || i >= buckets.Length)
            return null;
        return buckets[i].Root;
    }
}
