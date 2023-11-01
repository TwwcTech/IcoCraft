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
            OpenPngDialogue = new OpenFileDialog();
            SavePngDialogue = new SaveFileDialog();
            OpenPngButton = new Button();
            FileToConvertLabel = new Label();
            FileLabel = new Label();
            ControlPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ControlPanel
            // 
            ControlPanel.BackColor = SystemColors.Control;
            ControlPanel.Controls.Add(ViewCraftedButton);
            ControlPanel.Controls.Add(CraftButton);
            ControlPanel.Dock = DockStyle.Bottom;
            ControlPanel.Location = new Point(0, 259);
            ControlPanel.Margin = new Padding(2);
            ControlPanel.Name = "ControlPanel";
            ControlPanel.Size = new Size(518, 58);
            ControlPanel.TabIndex = 0;
            // 
            // ViewCraftedButton
            // 
            ViewCraftedButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ViewCraftedButton.Location = new Point(263, 12);
            ViewCraftedButton.Margin = new Padding(2);
            ViewCraftedButton.Name = "ViewCraftedButton";
            ViewCraftedButton.Size = new Size(196, 35);
            ViewCraftedButton.TabIndex = 1;
            ViewCraftedButton.Text = "VIEW CRAFTED";
            ViewCraftedButton.UseVisualStyleBackColor = true;
            ViewCraftedButton.Click += ViewCraftedButton_Click;
            // 
            // CraftButton
            // 
            CraftButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CraftButton.Location = new Point(63, 12);
            CraftButton.Margin = new Padding(2);
            CraftButton.Name = "CraftButton";
            CraftButton.Size = new Size(196, 35);
            CraftButton.TabIndex = 0;
            CraftButton.Text = "CRAFT";
            CraftButton.UseVisualStyleBackColor = true;
            CraftButton.Click += CraftButton_Click;
            // 
            // OpenPngDialogue
            // 
            OpenPngDialogue.FileName = "openFileDialog1";
            // 
            // OpenPngButton
            // 
            OpenPngButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OpenPngButton.Location = new Point(111, 114);
            OpenPngButton.Name = "OpenPngButton";
            OpenPngButton.Size = new Size(75, 35);
            OpenPngButton.TabIndex = 1;
            OpenPngButton.Text = "Open";
            OpenPngButton.UseVisualStyleBackColor = true;
            // 
            // FileToConvertLabel
            // 
            FileToConvertLabel.AutoSize = true;
            FileToConvertLabel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FileToConvertLabel.Location = new Point(192, 121);
            FileToConvertLabel.Name = "FileToConvertLabel";
            FileToConvertLabel.Size = new Size(133, 21);
            FileToConvertLabel.TabIndex = 2;
            FileToConvertLabel.Text = "File To Convert :";
            // 
            // FileLabel
            // 
            FileLabel.AutoSize = true;
            FileLabel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FileLabel.Location = new Point(331, 121);
            FileLabel.Name = "FileLabel";
            FileLabel.Size = new Size(57, 21);
            FileLabel.TabIndex = 3;
            FileLabel.Text = "label1";
            // 
            // MainFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(518, 317);
            Controls.Add(FileLabel);
            Controls.Add(FileToConvertLabel);
            Controls.Add(OpenPngButton);
            Controls.Add(ControlPanel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainFrame";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IcoCraft";
            Load += MainFrame_Load;
            ControlPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel ControlPanel;
        private Button CraftButton;
        private Button ViewCraftedButton;
        private OpenFileDialog OpenPngDialogue;
        private SaveFileDialog SavePngDialogue;
        private Button OpenPngButton;
        private Label FileToConvertLabel;
        private Label FileLabel;
    }
}