using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableVisualization;

internal class HashTableVizualizer<TValue>
{
    private const int NodeWidth = 40;
    private const int NodeHeight = 30;
    private const int VerticalSpacing = 60;
    private const int HorizontalSpacing = 80;
    private const int StartX = 10;
    private const int StartY = 40;

    public void DrawHashTable(HashTableState<TValue> state, Graphics graphics)
    {
        if (state == null || graphics == null) return;

        int x = StartX;
        int y = StartY;

        for (int i = 0; i < state.Capacity; i++)
        {
            graphics.DrawString($"Bucket {i}", SystemFonts.DefaultFont, Brushes.Black, x - 5, y - 30);
            graphics.DrawRectangle(Pens.Black, x, y - 20, NodeWidth, NodeHeight + 10);

            if (state.Buckets[i] != null)
                DrawTree(state.Buckets[i], x, y, graphics, 0, state.Capacity);
            x += HorizontalSpacing;
        }
    }

    private void DrawTree(Node<TValue> node, int x, int y, Graphics graphics, int depth, int totalBuckets)
    {
        if (node == null) return;

        int childOffset = (int)(Math.Pow(2, depth) * (NodeWidth / 2));

        // Draw left child
        if (node.Left != null)
            graphics.DrawLine(Pens.Black, x + NodeWidth / 2, y + NodeHeight / 2, x - childOffset + NodeWidth / 2, y + VerticalSpacing + NodeHeight / 2);
        DrawTree(node.Left, x - childOffset, y + VerticalSpacing, graphics, depth + 1, totalBuckets);

        // Draw right child
        if (node.Right != null)
            graphics.DrawLine(Pens.Black, x + NodeWidth / 2, y + NodeHeight / 2, x + childOffset + NodeWidth / 2, y + VerticalSpacing + NodeHeight / 2);
        DrawTree(node.Right, x + childOffset, y + VerticalSpacing, graphics, depth + 1, totalBuckets);

        // Draw node
        Brush brush = Brushes.LightBlue;
        graphics.FillEllipse(brush, x, y, NodeWidth, NodeHeight);
        graphics.DrawEllipse(Pens.Black, x, y, NodeWidth, NodeHeight);
        string nodeText = $"{node.Key}\n{node.Value}";
        graphics.DrawString(nodeText, SystemFonts.DefaultFont, Brushes.Black, x + 5, y + 5);
    }
}
