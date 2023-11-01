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
            ControlPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ControlPanel
            // 
            ControlPanel.BackColor = Color.FromArgb(100, 151, 177);
            ControlPanel.Controls.Add(ViewCraftedButton);
            ControlPanel.Controls.Add(CraftButton);
            ControlPanel.Dock = DockStyle.Bottom;
            ControlPanel.Location = new Point(0, 238);
            ControlPanel.Margin = new Padding(2, 2, 2, 2);
            ControlPanel.Name = "ControlPanel";
            ControlPanel.Size = new Size(665, 79);
            ControlPanel.TabIndex = 0;
            // 
            // ViewCraftedButton
            // 
            ViewCraftedButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ViewCraftedButton.Location = new Point(329, 22);
            ViewCraftedButton.Margin = new Padding(2, 2, 2, 2);
            ViewCraftedButton.Name = "ViewCraftedButton";
            ViewCraftedButton.Size = new Size(222, 35);
            ViewCraftedButton.TabIndex = 1;
            ViewCraftedButton.Text = "VIEW CRAFTED";
            ViewCraftedButton.UseVisualStyleBackColor = true;
            ViewCraftedButton.Click += ViewCraftedButton_Click;
            // 
            // CraftButton
            // 
            CraftButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CraftButton.Location = new Point(96, 22);
            CraftButton.Margin = new Padding(2, 2, 2, 2);
            CraftButton.Name = "CraftButton";
            CraftButton.Size = new Size(220, 35);
            CraftButton.TabIndex = 0;
            CraftButton.Text = "CRAFT";
            CraftButton.UseVisualStyleBackColor = true;
            CraftButton.Click += CraftButton_Click;
            // 
            // MainFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(179, 205, 224);
            ClientSize = new Size(665, 317);
            Controls.Add(ControlPanel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            HelpButton = true;
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            Name = "MainFrame";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IcoCraft";
            Load += MainFrame_Load;
            ControlPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel ControlPanel;
        private Button CraftButton;
        private Button ViewCraftedButton;
    }
}