namespace HashTableVisualization
{
    partial class HashTableForm
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
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            pictureBox = new PictureBox();
            Tools = new GroupBox();
            btnPreviousStep = new Button();
            btnNextStep = new Button();
            btnDelete = new Button();
            btnFind = new Button();
            btnAdd = new Button();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            Tools.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(32, 32);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(2674, 40);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, loadToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(71, 36);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(359, 44);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.L;
            loadToolStripMenuItem.Size = new Size(359, 44);
            loadToolStripMenuItem.Text = "Load";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // pictureBox
            // 
            pictureBox.Dock = DockStyle.Left;
            pictureBox.Location = new Point(0, 40);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(2190, 1789);
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            // 
            // Tools
            // 
            Tools.Controls.Add(btnPreviousStep);
            Tools.Controls.Add(btnNextStep);
            Tools.Controls.Add(btnDelete);
            Tools.Controls.Add(btnFind);
            Tools.Controls.Add(btnAdd);
            Tools.Dock = DockStyle.Right;
            Tools.Location = new Point(2187, 40);
            Tools.Name = "Tools";
            Tools.Size = new Size(487, 1789);
            Tools.TabIndex = 0;
            Tools.TabStop = false;
            Tools.Text = "Tools";
            // 
            // btnPreviousStep
            // 
            btnPreviousStep.Enabled = false;
            btnPreviousStep.Location = new Point(9, 507);
            btnPreviousStep.Name = "btnPreviousStep";
            btnPreviousStep.Size = new Size(472, 87);
            btnPreviousStep.TabIndex = 2;
            btnPreviousStep.Text = "Previous Step";
            btnPreviousStep.UseVisualStyleBackColor = true;
            btnPreviousStep.Click += btnPreviousStep_Click;
            // 
            // btnNextStep
            // 
            btnNextStep.Enabled = false;
            btnNextStep.Location = new Point(9, 414);
            btnNextStep.Name = "btnNextStep";
            btnNextStep.Size = new Size(472, 87);
            btnNextStep.TabIndex = 1;
            btnNextStep.Text = "Next Step";
            btnNextStep.UseVisualStyleBackColor = true;
            btnNextStep.Click += btnNextStep_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(9, 252);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(472, 87);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(9, 159);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(472, 87);
            btnFind.TabIndex = 1;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(9, 66);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(472, 87);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            openFileDialog.Filter = "txt file | *.txt";
            // 
            // saveFileDialog
            // 
            saveFileDialog.Filter = "txt file | *.txt";
            // 
            // HashTableForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2674, 1829);
            Controls.Add(Tools);
            Controls.Add(pictureBox);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "HashTableForm";
            Text = "HashTableForm";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            Tools.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private PictureBox pictureBox;
        private GroupBox Tools;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnFind;
        private Button btnPreviousStep;
        private Button btnNextStep;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
    }
}