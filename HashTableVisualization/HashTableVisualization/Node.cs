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
    public bool IsHighlighted { get; set; }
    public Node(string Key, TValue Value, bool IsHighlighted = false)
    {
        this.Key = Key;
        this.Value = Value;
        Left = Right = null;
        this.IsHighlighted = IsHighlighted;
    }
}
