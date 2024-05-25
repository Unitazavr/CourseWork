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

public partial class InputForm : Form
{
    public event Action<string, int>? DataSubmitted;
    private bool isForInsert;
    public InputForm(bool isForInsert = true)
    {
        this.isForInsert = isForInsert;
        InitializeComponent();
        ArrangeForm(isForInsert);
    }
    private void ArrangeForm(bool isForInsert)
    {
        if (!isForInsert)
        {
            Controls.Remove(txtValue);
            Controls.Remove(lblValue);
            btnSubmit.Location = new System.Drawing.Point(130, 100);  // Move the button up
            ClientSize = new Size(585, 250);
        }
    }
    private void btnSubmit_Click(object sender, EventArgs e)
    {
        if ((isForInsert && string.IsNullOrEmpty(txtValue.Text)) || string.IsNullOrEmpty(txtKey.Text))
        {
            MessageBox.Show("The data is incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        if (isForInsert)
            DataSubmitted?.Invoke(txtKey.Text, int.Parse(txtValue.Text));
        else
            DataSubmitted?.Invoke(txtKey.Text, 0);

        this.Close();
    }
}
