using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableVisualization;

internal class BinaryTree<TValue>
{
    public Node<TValue>? Root { get; set; }
    public void Insert(string key, TValue value)
    {
        Root = InsertRecursive(Root, key, value);
    }
    private Node<TValue> InsertRecursive(Node<TValue>? node, string key, TValue value)
    {
        if (node == null)
        {
            return new Node<TValue>(key, value);
        }
        int comparison = string.Compare(key, node.Key, StringComparison.Ordinal);
        if (comparison < 0)
        {
            node.Left = InsertRecursive(node.Left, key, value);
        }
        else if (comparison > 0)
        {
            node.Right = InsertRecursive(node.Right, key, value);
        }
        else
        {
            node.Value = value;  
        }
        return node;
    }

    public bool Remove(string key)
    {
        bool wasDeleted;
        (Root, wasDeleted) = Remove(Root, key);
        return wasDeleted;
    }

    private (Node<TValue>?, bool) Remove(Node<TValue>? node, string key)
    {
        if (node == null) return (null, false);

        int comparison = string.Compare(key, node.Key, StringComparison.Ordinal);
        if (comparison < 0)
        {
            Node<TValue>? newLeft;
            bool wasDeleted;
            (newLeft, wasDeleted) = Remove(node.Left, key);
            node.Left = newLeft;
            return (node, wasDeleted);
        }
        else if (comparison > 0)
        {
            Node<TValue>? newRight;
            bool wasDeleted;
            (newRight, wasDeleted) = Remove(node.Right, key);
            node.Right = newRight;
            return (node, wasDeleted);
        }
        else
        {
            if (node.Left == null) return (node.Right, true);
            if (node.Right == null) return (node.Left, true);

            Node<TValue> successor = MinValueNode(node.Right);
            node.Key = successor.Key;
            node.Value = successor.Value;
            node.Right = RemoveSuccessor(node.Right);
            return (node, true);
        }
    }

    private Node<TValue>? RemoveSuccessor(Node<TValue> node)
    {
        if (node.Left == null) return node.Right;
        node.Left = RemoveSuccessor(node.Left);
        return node;
    }

    private Node<TValue> MinValueNode(Node<TValue> node)
    {
        Node<TValue> current = node;
        while (current.Left != null)
        {
            current = current.Left;
        }
        return current;
    }

    public Node<TValue> Find(string key)
    {
        Node<TValue> node = Find(Root, key);
        return node;
    }

    private Node<TValue>? Find(Node<TValue>? node, string key)
    {
        if (node == null) return null;

        int comparison = string.Compare(key, node.Key, StringComparison.Ordinal);
        if (comparison == 0) return node;
        return comparison < 0 ? Find(node.Left, key) : Find(node.Right, key);
    }
}
