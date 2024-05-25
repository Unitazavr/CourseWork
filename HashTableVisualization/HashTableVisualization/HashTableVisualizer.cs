using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableVisualization;

internal class HashTableVizualizer<TValue>
{
    private const int NodeWidth = 75;
    private const int NodeHeight = 75;
    private const int VerticalSpacing = 100;
    private const int HorizontalSpacing = 200;
    private const int StartX = 50;
    private const int StartY = 30;

    public Bitmap? DrawHashTable(HashTableState<TValue> state, Bitmap bitmap)
    {
        Graphics graphics = Graphics.FromImage(bitmap);
        if (state == null) return null;
        int x = StartX;
        int y = StartY;

        for (int i = 0; i < state.Capacity; i++)
        {
            if (x + NodeWidth * 2 > bitmap.Width)
            {
                y += 400;
                x = StartX;
            }
            graphics.DrawString($"Bucket {i}", SystemFonts.DefaultFont, Brushes.Black, x - 5, y - 30);
            graphics.DrawRectangle(Pens.Black, x, y, NodeWidth, NodeHeight);
            if (state.Buckets[i] != null)
                graphics = DrawTree(state.Buckets[i], x, y, graphics, 0, state.Capacity);
            x += HorizontalSpacing;
        }
        return bitmap;
    }

    private Graphics DrawTree(Node<TValue> node, int x, int y, Graphics graphics, int depth, int totalBuckets)
    {
        if (node == null) return null;

        int childOffset = (int)(Math.Pow(2, depth) * (NodeWidth / 2));

        // Draw left child
        if (node.Left != null)
        {
            graphics.DrawLine(Pens.Black, x + NodeWidth / 2, y + NodeHeight / 2, x - childOffset + NodeWidth / 2, y + VerticalSpacing + NodeHeight / 2);
            DrawTree(node.Left, x - childOffset, y + VerticalSpacing, graphics, depth + 1, totalBuckets);
        }
        // Draw right child
        if (node.Right != null)
        {
            graphics.DrawLine(Pens.Black, x + NodeWidth / 2, y + NodeHeight / 2, x + childOffset + NodeWidth / 2, y + VerticalSpacing + NodeHeight / 2);
            DrawTree(node.Right, x + childOffset, y + VerticalSpacing, graphics, depth + 1, totalBuckets);
        }
        // Draw node
        Brush brush = node.IsHighlighted ? Brushes.LightSalmon : Brushes.LightBlue;
        graphics.FillEllipse(brush, x, y, NodeWidth, NodeHeight);
        graphics.DrawEllipse(Pens.Black, x, y, NodeWidth, NodeHeight);
        string valueString = node.Value.ToString();
        //Если строки с данными помещаются - печаетем всю, иначе - первые 3 символа 
        string nodeText = $"K:{(node.Key.Length > 3 ? node.Key.Substring(0, 3)+".." : node.Key)}\nV:{(valueString.Length > 3 ? valueString.Substring(0, 3)+"." : valueString)}";
        graphics.DrawString(nodeText, SystemFonts.DefaultFont, Brushes.Black, x + 5, y + 13);
        return graphics;
    }
}
