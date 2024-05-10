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
            panelStepControls = new Panel();
            btnPreviousStep = new Button();
            btnNextStep = new Button();
            btnDelete = new Button();
            btnFind = new Button();
            btnAdd = new Button();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            Tools.SuspendLayout();
            panelStepControls.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(32, 32);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(2514, 40);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, loadToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(90, 38);
            fileToolStripMenuItem.Text = "Файл";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(343, 44);
            saveToolStripMenuItem.Text = "Сохранить";
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.L;
            loadToolStripMenuItem.Size = new Size(343, 44);
            loadToolStripMenuItem.Text = "Загрузить";
            // 
            // pictureBox
            // 
            pictureBox.Dock = DockStyle.Left;
            pictureBox.Location = new Point(0, 40);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(2030, 1239);
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            // 
            // Tools
            // 
            Tools.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Tools.Controls.Add(panelStepControls);
            Tools.Controls.Add(btnDelete);
            Tools.Controls.Add(btnFind);
            Tools.Controls.Add(btnAdd);
            Tools.Location = new Point(2027, 40);
            Tools.Name = "Tools";
            Tools.Size = new Size(487, 1239);
            Tools.TabIndex = 0;
            Tools.TabStop = false;
            Tools.Text = "Tools";
            // 
            // panelStepControls
            // 
            panelStepControls.Controls.Add(btnPreviousStep);
            panelStepControls.Controls.Add(btnNextStep);
            panelStepControls.Enabled = false;
            panelStepControls.Location = new Point(9, 393);
            panelStepControls.Name = "panelStepControls";
            panelStepControls.Size = new Size(472, 241);
            panelStepControls.TabIndex = 3;
            // 
            // btnPreviousStep
            // 
            btnPreviousStep.Location = new Point(0, 125);
            btnPreviousStep.Name = "btnPreviousStep";
            btnPreviousStep.Size = new Size(472, 87);
            btnPreviousStep.TabIndex = 2;
            btnPreviousStep.Text = "Previous Step";
            btnPreviousStep.UseVisualStyleBackColor = true;
            btnPreviousStep.Click += btnPreviousStep_Click;
            // 
            // btnNextStep
            // 
            btnNextStep.Location = new Point(0, 32);
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
            // HashTableForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2514, 1279);
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
            panelStepControls.ResumeLayout(false);
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
        private Panel panelStepControls;
        private Button btnPreviousStep;
        private Button btnNextStep;
    }
}