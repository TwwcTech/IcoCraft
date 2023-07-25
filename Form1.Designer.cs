namespace IcoCraft
{
    partial class MainFrame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ControlPanel = new Panel();
            ViewCraftedButton = new Button();
            CraftButton = new Button();
            PngPathEntryBox = new TextBox();
            IconNameEntryBox = new TextBox();
            ControlPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ControlPanel
            // 
            ControlPanel.BackColor = Color.FromArgb(100, 151, 177);
            ControlPanel.Controls.Add(ViewCraftedButton);
            ControlPanel.Controls.Add(CraftButton);
            ControlPanel.Dock = DockStyle.Bottom;
            ControlPanel.Location = new Point(0, 397);
            ControlPanel.Name = "ControlPanel";
            ControlPanel.Size = new Size(950, 131);
            ControlPanel.TabIndex = 0;
            // 
            // ViewCraftedButton
            // 
            ViewCraftedButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ViewCraftedButton.Location = new Point(470, 36);
            ViewCraftedButton.Name = "ViewCraftedButton";
            ViewCraftedButton.Size = new Size(317, 59);
            ViewCraftedButton.TabIndex = 1;
            ViewCraftedButton.Text = "VIEW CRAFTED";
            ViewCraftedButton.UseVisualStyleBackColor = true;
            ViewCraftedButton.Click += ViewCraftedButton_Click;
            // 
            // CraftButton
            // 
            CraftButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CraftButton.Location = new Point(137, 36);
            CraftButton.Name = "CraftButton";
            CraftButton.Size = new Size(315, 59);
            CraftButton.TabIndex = 0;
            CraftButton.Text = "CRAFT";
            CraftButton.UseVisualStyleBackColor = true;
            CraftButton.Click += CraftButton_Click;
            // 
            // PngPathEntryBox
            // 
            PngPathEntryBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PngPathEntryBox.Location = new Point(137, 120);
            PngPathEntryBox.Name = "PngPathEntryBox";
            PngPathEntryBox.PlaceholderText = "Drag and Drop your PNG file here";
            PngPathEntryBox.Size = new Size(650, 37);
            PngPathEntryBox.TabIndex = 1;
            // 
            // IconNameEntryBox
            // 
            IconNameEntryBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IconNameEntryBox.Location = new Point(137, 220);
            IconNameEntryBox.Name = "IconNameEntryBox";
            IconNameEntryBox.PlaceholderText = "Enter name for crafted Icon file";
            IconNameEntryBox.Size = new Size(650, 37);
            IconNameEntryBox.TabIndex = 2;
            // 
            // MainFrame
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(179, 205, 224);
            ClientSize = new Size(950, 528);
            Controls.Add(IconNameEntryBox);
            Controls.Add(PngPathEntryBox);
            Controls.Add(ControlPanel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            HelpButton = true;
            MaximizeBox = false;
            Name = "MainFrame";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IcoCraft";
            Load += MainFrame_Load;
            ControlPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel ControlPanel;
        private TextBox PngPathEntryBox;
        private TextBox IconNameEntryBox;
        private Button CraftButton;
        private Button ViewCraftedButton;
    }
}