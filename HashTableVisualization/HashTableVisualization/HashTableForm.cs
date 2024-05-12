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
    public HashTableForm()
    {
        InitializeComponent();
        HashTable = new HashTable<int>();
        manager = new StateManager<int>(HashTable, HashTable.capacity);
        visualizer = new HashTableVizualizer<int>();
        for (int i = 0; i < 29; i++)
        {
            manager.Insert(i.ToString(), 1);
        }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        btnPreviousStep.Enabled = true;
        using (var inputForm = new InputForm(true))
        {
            inputForm.DataSubmitted += (key, value) => {
                manager.Insert(key, value);
                UpdateVisualization();
            };
            inputForm.ShowDialog();
        }
    }

    private void btnFind_Click(object sender, EventArgs e)
    {
        using (var inputForm = new InputForm(false))
        {
            inputForm.DataSubmitted += (key, value) => {
                var result = manager.Find(key);
                MessageBox.Show(result != null ? $"Value found: {result}" : "Value not found", "Find Result");
                UpdateVisualization();
            };
            inputForm.ShowDialog();
        }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        btnPreviousStep.Enabled = true;
        using (var inputForm = new InputForm(false))
        {
            inputForm.DataSubmitted += (key, value) => {
                manager.Remove(key);
                UpdateVisualization();
            };
            inputForm.ShowDialog();
        }
    }

    private void btnNextStep_Click(object sender, EventArgs e)
    {
        //Если текущее состояние - крайнее
        if (manager.GetStateStorage().GetCurrentState().Equals(manager.GetStateStorage().Next()))
        {
            btnNextStep.Enabled = false;
            return;
        }
        btnPreviousStep.Enabled = true;
        UpdateVisualization();
    }

    private void btnPreviousStep_Click(object sender, EventArgs e)
    {
        //Если текущее состояние - первое
        if (manager.GetStateStorage().GetCurrentState().Equals(manager.GetStateStorage().GetFirst()))
        {
            btnPreviousStep.Enabled = false;
            return;
        }
        manager.GetStateStorage().Previous();
        btnNextStep.Enabled = true;
        UpdateVisualization();
    }

    private void UpdateVisualization()
    {
        HashTableState<int>? currentState = manager.GetStateStorage().GetCurrentState();
        if (currentState == null)
            return;
        Bitmap bitmap = new(pictureBox.Width, pictureBox.Height);
        pictureBox.Image = visualizer.DrawHashTable(currentState, bitmap);
    }
}
