using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashTableVisualization;

public partial class HashTableForm : Form
{
    private HashTable<int> HashTable;
    private StateManager<int> manager;
    private HashTableVizualizer<int> visualizer;
    Panel[] hashTablePanels;
    public HashTableForm()
    {
        InitializeComponent();
        HashTable = new HashTable<int>();
        manager = new StateManager<int>(HashTable, HashTable.capacity);
        visualizer = new HashTableVizualizer<int>();
        InitializeHashTableVisual();
    }
    private void InitializeHashTableVisual()
    {
        Panel[] hashTablePanels = new System.Windows.Forms.Panel[16];
        for (int i = 0; i < hashTablePanels.Length; i++)
        {
            hashTablePanels[i] = new System.Windows.Forms.Panel();
            hashTablePanels[i].Location = new System.Drawing.Point(10, 10 + i * 80);
            hashTablePanels[i].Size = new System.Drawing.Size(200, 70);
            Controls.Add(hashTablePanels[i]);
        }
        foreach (var panel in hashTablePanels)
        {
            panel.Paint += (sender, e) => DrawInitialState(e.Graphics);
        }
    }

    private void DrawInitialState(Graphics graphics)
    {
        // Initial drawing for empty buckets
        for (int i = 0; i < HashTable.capacity; i++)
        {
            graphics.DrawString($"Bucket {i}", SystemFonts.DefaultFont, Brushes.Black, 10, i * 60 + 20);
            graphics.DrawRectangle(Pens.Black, 10, i * 60 + 40, 40, 30);
        }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        using (var inputForm = new InputForm())
        {
            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                manager.Insert(inputForm.Key, inputForm.Value);
                UpdateVisualization();
            }
        }
    }

    private void btnFind_Click(object sender, EventArgs e)
    {
        using (var inputForm = new InputForm("Enter Key"))
        {
            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                Node<int> node = manager.Find(inputForm.Key);
                if (node.Equals(null))
                {
                    MessageBox.Show($"Value didn't found", "Find Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Value found: {node.Value}", "Find Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateVisualization();
                }
            }
        }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        using (var inputForm = new InputForm("Enter Key"))
        {
            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                manager.Remove(inputForm.Key);
                UpdateVisualization();
            }
        }
    }

    private void btnNextStep_Click(object sender, EventArgs e)
    {
        manager.GetStateStorage().Next();
        UpdateVisualization();
    }

    private void btnPreviousStep_Click(object sender, EventArgs e)
    {
        manager.GetStateStorage().Previous();
        UpdateVisualization();
    }

    private void UpdateVisualization()
    {
        var currentState = manager.GetStateStorage().GetCurrentState();
        if (currentState == null)
            return;
        foreach (var panel in hashTablePanels)
        {
            panel.Invalidate(); // Trigger a repaint
            panel.Paint += (sender, e) => visualizer.DrawHashTable(currentState, e.Graphics);
        }
    }
}
