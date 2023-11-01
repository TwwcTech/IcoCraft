namespace IcoCraft.frontend.Windows
{
    partial class CraftedFilesWindow
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
            components = new System.ComponentModel.Container();
            CraftedControlPanel = new Panel();
            destDirManagerBindingSource = new BindingSource(components);
            CraftedIconsDataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)destDirManagerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CraftedIconsDataGrid).BeginInit();
            SuspendLayout();
            // 
            // CraftedControlPanel
            // 
            CraftedControlPanel.BackColor = SystemColors.Control;
            CraftedControlPanel.Dock = DockStyle.Bottom;
            CraftedControlPanel.Location = new Point(0, 437);
            CraftedControlPanel.Margin = new Padding(2, 2, 2, 2);
            CraftedControlPanel.Name = "CraftedControlPanel";
            CraftedControlPanel.Size = new Size(1043, 96);
            CraftedControlPanel.TabIndex = 0;
            // 
            // CraftedIconsDataGrid
            // 
            CraftedIconsDataGrid.AllowUserToAddRows = false;
            CraftedIconsDataGrid.AllowUserToDeleteRows = false;
            CraftedIconsDataGrid.BackgroundColor = SystemColors.Control;
            CraftedIconsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CraftedIconsDataGrid.Dock = DockStyle.Fill;
            CraftedIconsDataGrid.Location = new Point(0, 0);
            CraftedIconsDataGrid.Margin = new Padding(2, 2, 2, 2);
            CraftedIconsDataGrid.Name = "CraftedIconsDataGrid";
            CraftedIconsDataGrid.ReadOnly = true;
            CraftedIconsDataGrid.RowHeadersWidth = 62;
            CraftedIconsDataGrid.RowTemplate.Height = 33;
            CraftedIconsDataGrid.Size = new Size(1043, 437);
            CraftedIconsDataGrid.TabIndex = 1;
            // 
            // CraftedFilesWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(179, 205, 224);
            ClientSize = new Size(1043, 533);
            Controls.Add(CraftedIconsDataGrid);
            Controls.Add(CraftedControlPanel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            Name = "CraftedFilesWindow";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Crafted Files Window";
            Load += CraftedFilesWindow_Load;
            ((System.ComponentModel.ISupportInitialize)destDirManagerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)CraftedIconsDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel CraftedControlPanel;
        private BindingSource destDirManagerBindingSource;
        private DataGridView CraftedIconsDataGrid;
    }
}