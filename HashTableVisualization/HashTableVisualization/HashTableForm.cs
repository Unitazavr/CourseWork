using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashTableVisualization
{
    public partial class HashTableForm : Form
    {
        //private Manager<TValue> manager;
        //private HashTableVisualizer<TValue> visualizer;
        private int currentIndex = -1;
        public HashTableForm()
        {
            InitializeComponent();
        //    manager = new Manager<TValue>();
        //    visualizer = new HashTableVisualizer<TValue>();
        //    InitializeHashTableVisual();
        }
        //private void InitializeHashTableVisual()
        //{
        //    foreach (var panel in hashTablePanels)
        //    {
        //        panel.Paint += (sender, e) => DrawInitialState(e.Graphics);
        //    }
        //}

        //private void DrawInitialState(Graphics graphics)
        //{
        //    // Initial drawing for empty buckets
        //    for (int i = 0; i < manager.GetStateManager().Capacity; i++)
        //    {
        //        graphics.DrawString($"Bucket {i}", SystemFonts.DefaultFont, Brushes.Black, 10, i * 60 + 20);
        //        graphics.DrawRectangle(Pens.Black, 10, i * 60 + 40, 40, 30);
        //    }
        //}

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //using (var inputForm = new InputForm())
            //{
            //    if (inputForm.ShowDialog() == DialogResult.OK)
            //    {
            //        manager.Insert(inputForm.Key, inputForm.Value);
            //        UpdateVisualization();
            //    }
            //}
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            //using (var inputForm = new InputForm("Enter Key"))
            //{
            //    if (inputForm.ShowDialog() == DialogResult.OK)
            //    {
            //        var value = manager.Find(inputForm.Key);
            //        MessageBox.Show($"Value found: {value}", "Find Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        UpdateVisualization();
            //    }
            //}
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //using (var inputForm = new InputForm("Enter Key"))
            //{
            //    if (inputForm.ShowDialog() == DialogResult.OK)
            //    {
            //        manager.Delete(inputForm.Key);
            //        UpdateVisualization();
            //    }
            //}
        }

        private void btnNextStep_Click(object sender, EventArgs e)
        {
            //if (currentIndex < manager.GetStateManager().GetCount() - 1)
            //{
            //    currentIndex++;
            //    UpdateVisualization();
            //}
        }

        private void btnPreviousStep_Click(object sender, EventArgs e)
        {
            //if (currentIndex > 0)
            //{
            //    currentIndex--;
            //    UpdateVisualization();
            //}
        }

        private void UpdateVisualization()
        {
            //var currentState = manager.GetStateManager().GetCurrentState();
            //foreach (var panel in hashTablePanels)
            //{
            //    panel.Invalidate(); // Trigger a repaint
            //    panel.Paint += (sender, e) => visualizer.Visualize(currentState, e.Graphics);
            //}
        }
    }
}
