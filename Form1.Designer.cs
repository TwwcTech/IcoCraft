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
            SaveIcoDialogue = new SaveFileDialog();
            OpenPngButton = new Button();
            FileNameOutputLabel = new Label();
            OutPutGbox = new GroupBox();
            FileNameLabel = new Label();
            FileFullPathLabel = new Label();
            FileFullPathOutputLabel = new Label();
            ControlPanel.SuspendLayout();
            OutPutGbox.SuspendLayout();
            SuspendLayout();
            // 
            // ControlPanel
            // 
            ControlPanel.BackColor = SystemColors.Control;
            ControlPanel.Controls.Add(ViewCraftedButton);
            ControlPanel.Controls.Add(CraftButton);
            ControlPanel.Dock = DockStyle.Bottom;
            ControlPanel.Location = new Point(0, 255);
            ControlPanel.Margin = new Padding(2);
            ControlPanel.Name = "ControlPanel";
            ControlPanel.Size = new Size(673, 58);
            ControlPanel.TabIndex = 0;
            // 
            // ViewCraftedButton
            // 
            ViewCraftedButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ViewCraftedButton.Location = new Point(338, 12);
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
            CraftButton.Location = new Point(138, 12);
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
            OpenPngButton.Location = new Point(298, 196);
            OpenPngButton.Name = "OpenPngButton";
            OpenPngButton.Size = new Size(75, 35);
            OpenPngButton.TabIndex = 1;
            OpenPngButton.Text = "Open";
            OpenPngButton.UseVisualStyleBackColor = true;
            OpenPngButton.Click += OpenPngButton_Click;
            // 
            // FileNameOutputLabel
            // 
            FileNameOutputLabel.AutoSize = true;
            FileNameOutputLabel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FileNameOutputLabel.Location = new Point(127, 39);
            FileNameOutputLabel.Name = "FileNameOutputLabel";
            FileNameOutputLabel.Size = new Size(57, 21);
            FileNameOutputLabel.TabIndex = 3;
            FileNameOutputLabel.Text = "label1";
            // 
            // OutPutGbox
            // 
            OutPutGbox.Controls.Add(FileFullPathOutputLabel);
            OutPutGbox.Controls.Add(FileFullPathLabel);
            OutPutGbox.Controls.Add(FileNameLabel);
            OutPutGbox.Controls.Add(FileNameOutputLabel);
            OutPutGbox.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            OutPutGbox.Location = new Point(12, 12);
            OutPutGbox.Name = "OutPutGbox";
            OutPutGbox.Size = new Size(649, 164);
            OutPutGbox.TabIndex = 4;
            OutPutGbox.TabStop = false;
            OutPutGbox.Text = "File To Convert";
            // 
            // FileNameLabel
            // 
            FileNameLabel.AutoSize = true;
            FileNameLabel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FileNameLabel.Location = new Point(27, 39);
            FileNameLabel.Name = "FileNameLabel";
            FileNameLabel.Size = new Size(94, 21);
            FileNameLabel.TabIndex = 4;
            FileNameLabel.Text = "File Name :";
            // 
            // FileFullPathLabel
            // 
            FileFullPathLabel.AutoSize = true;
            FileFullPathLabel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FileFullPathLabel.Location = new Point(27, 108);
            FileFullPathLabel.Name = "FileFullPathLabel";
            FileFullPathLabel.Size = new Size(95, 21);
            FileFullPathLabel.TabIndex = 5;
            FileFullPathLabel.Text = "Full Path    :";
            // 
            // FileFullPathOutputLabel
            // 
            FileFullPathOutputLabel.AutoSize = true;
            FileFullPathOutputLabel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FileFullPathOutputLabel.Location = new Point(127, 108);
            FileFullPathOutputLabel.Name = "FileFullPathOutputLabel";
            FileFullPathOutputLabel.Size = new Size(57, 21);
            FileFullPathOutputLabel.TabIndex = 6;
            FileFullPathOutputLabel.Text = "label1";
            // 
            // MainFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(673, 313);
            Controls.Add(OutPutGbox);
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
            OutPutGbox.ResumeLayout(false);
            OutPutGbox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel ControlPanel;
        private Button CraftButton;
        private Button ViewCraftedButton;
        private OpenFileDialog OpenPngDialogue;
        private SaveFileDialog SaveIcoDialogue;
        private Button OpenPngButton;
        private Label FileNameOutputLabel;
        private GroupBox OutPutGbox;
        private Label FileFullPathLabel;
        private Label FileNameLabel;
        private Label FileFullPathOutputLabel;
    }
}