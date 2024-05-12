﻿using System;
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
    public event Action<string, int> DataSubmitted;
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
            btnSubmit.Location = new System.Drawing.Point(60, 50);  // Move the button up
        }
    }
    private void btnSubmit_Click(object sender, EventArgs e)
    {
        if (isForInsert && !string.IsNullOrEmpty(txtValue.Text))
        {
            DataSubmitted?.Invoke(txtKey.Text, int.Parse(txtValue.Text));
        }
        else if (!isForInsert)
        {
            DataSubmitted?.Invoke(txtKey.Text, 0);  // Value is not used for find or delete
        }

        this.Close();
    }
}