using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableVisualization;

internal class Node<TValue>
{
    public string Key { get; set; }
    public TValue Value { get; set; }
    public Node<TValue>? Left { get; set; }
    public Node<TValue>? Right { get; set; }
    //public bool IsHighlighted { get; set; } этот параметр будет открыт в случае модификации работы

    public Node(string key, TValue value)
    {
        Key = key;
        Value = value;
        Left = Right = null;
    }
}
