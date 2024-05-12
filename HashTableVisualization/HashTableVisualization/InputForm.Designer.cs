namespace HashTableVisualization
{
    partial class InputForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblKey = new Label();
            txtKey = new TextBox();
            lblValue = new Label();
            txtValue = new TextBox();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // lblKey
            // 
            lblKey.AutoSize = true;
            lblKey.Location = new Point(22, 49);
            lblKey.Margin = new Padding(6, 0, 6, 0);
            lblKey.Name = "lblKey";
            lblKey.Size = new Size(58, 32);
            lblKey.TabIndex = 0;
            lblKey.Text = "Key:";
            // 
            // txtKey
            // 
            txtKey.Location = new Point(130, 49);
            txtKey.Margin = new Padding(6, 7, 6, 7);
            txtKey.Name = "txtKey";
            txtKey.Size = new Size(385, 39);
            txtKey.TabIndex = 1;
            // 
            // lblValue
            // 
            lblValue.AutoSize = true;
            lblValue.Location = new Point(22, 123);
            lblValue.Margin = new Padding(6, 0, 6, 0);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(77, 32);
            lblValue.TabIndex = 2;
            lblValue.Text = "Value:";
            // 
            // txtValue
            // 
            txtValue.Location = new Point(130, 123);
            txtValue.Margin = new Padding(6, 7, 6, 7);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(385, 39);
            txtValue.TabIndex = 3;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(130, 197);
            btnSubmit.Margin = new Padding(6, 7, 6, 7);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(217, 74);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // InputForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 320);
            Controls.Add(lblKey);
            Controls.Add(txtKey);
            Controls.Add(lblValue);
            Controls.Add(txtValue);
            Controls.Add(btnSubmit);
            Margin = new Padding(6, 7, 6, 7);
            Name = "InputForm";
            Text = "Input Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKey;
        private TextBox txtKey;
        private Label lblValue;
        private TextBox txtValue;
        private Button btnSubmit;
    }
}