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
            OpenPngDialogue = new OpenFileDialog();
            SaveIcoDialogue = new SaveFileDialog();
            OpenPngButton = new Button();
            ControlPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ControlPanel
            // 
            ControlPanel.BackColor = SystemColors.Control;
            ControlPanel.Controls.Add(ViewCraftedButton);
            ControlPanel.Dock = DockStyle.Bottom;
            ControlPanel.Location = new Point(0, 324);
            ControlPanel.Margin = new Padding(2);
            ControlPanel.Name = "ControlPanel";
            ControlPanel.Size = new Size(505, 58);
            ControlPanel.TabIndex = 0;
            // 
            // ViewCraftedButton
            // 
            ViewCraftedButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ViewCraftedButton.Location = new Point(151, 12);
            ViewCraftedButton.Margin = new Padding(2);
            ViewCraftedButton.Name = "ViewCraftedButton";
            ViewCraftedButton.Size = new Size(196, 35);
            ViewCraftedButton.TabIndex = 1;
            ViewCraftedButton.Text = "VIEW CRAFTED";
            ViewCraftedButton.UseVisualStyleBackColor = true;
            ViewCraftedButton.Click += ViewCraftedButton_Click;
            // 
            // OpenPngDialogue
            // 
            OpenPngDialogue.FileName = "openFileDialog1";
            // 
            // OpenPngButton
            // 
            OpenPngButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OpenPngButton.Location = new Point(151, 159);
            OpenPngButton.Name = "OpenPngButton";
            OpenPngButton.Size = new Size(196, 35);
            OpenPngButton.TabIndex = 1;
            OpenPngButton.Text = "Select PNG File";
            OpenPngButton.UseVisualStyleBackColor = true;
            OpenPngButton.Click += OpenPngButton_Click;
            // 
            // MainFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(505, 382);
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
        }

        #endregion

        private Panel ControlPanel;
        private Button ViewCraftedButton;
        private OpenFileDialog OpenPngDialogue;
        private SaveFileDialog SaveIcoDialogue;
        private Button OpenPngButton;
    }
}