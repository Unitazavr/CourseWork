namespace HashTableVisualization
{
    partial class InfoForm
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
            txtInfo = new TextBox();
            SuspendLayout();
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(30, 29);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.ReadOnly = true;
            txtInfo.ScrollBars = ScrollBars.Vertical;
            txtInfo.Size = new Size(1152, 617);
            txtInfo.TabIndex = 0;
            // 
            // InfoForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1207, 686);
            Controls.Add(txtInfo);
            Name = "InfoForm";
            Text = "Information";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInfo;
    }
}