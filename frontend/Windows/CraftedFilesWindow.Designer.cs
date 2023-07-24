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
            CraftedControlPanel = new Panel();
            SuspendLayout();
            // 
            // CraftedControlPanel
            // 
            CraftedControlPanel.BackColor = Color.FromArgb(100, 151, 177);
            CraftedControlPanel.Dock = DockStyle.Bottom;
            CraftedControlPanel.Location = new Point(0, 619);
            CraftedControlPanel.Name = "CraftedControlPanel";
            CraftedControlPanel.Size = new Size(1120, 160);
            CraftedControlPanel.TabIndex = 0;
            // 
            // CraftedFilesWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(179, 205, 224);
            ClientSize = new Size(1120, 779);
            Controls.Add(CraftedControlPanel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "CraftedFilesWindow";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Crafted Files Window";
            Load += CraftedFilesWindow_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel CraftedControlPanel;
    }
}