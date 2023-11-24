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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            OpenPngDialogue = new OpenFileDialog();
            SaveIcoDialogue = new SaveFileDialog();
            OpenPngButton = new Button();
            ConvertProgressBar = new ProgressBar();
            MaxFileSizeCheckbox = new CheckBox();
            OptionsGBox = new GroupBox();
            MaxFileSizeComboBox = new ComboBox();
            OptionsGBox.SuspendLayout();
            SuspendLayout();
            // 
            // OpenPngDialogue
            // 
            OpenPngDialogue.FileName = "openFileDialog1";
            // 
            // OpenPngButton
            // 
            OpenPngButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OpenPngButton.Location = new Point(143, 55);
            OpenPngButton.Name = "OpenPngButton";
            OpenPngButton.Size = new Size(196, 35);
            OpenPngButton.TabIndex = 1;
            OpenPngButton.Text = "Select PNG File";
            OpenPngButton.UseVisualStyleBackColor = true;
            OpenPngButton.Click += OpenPngButton_Click;
            // 
            // ConvertProgressBar
            // 
            ConvertProgressBar.Location = new Point(12, 303);
            ConvertProgressBar.Name = "ConvertProgressBar";
            ConvertProgressBar.Size = new Size(481, 23);
            ConvertProgressBar.Style = ProgressBarStyle.Continuous;
            ConvertProgressBar.TabIndex = 2;
            // 
            // MaxFileSizeCheckbox
            // 
            MaxFileSizeCheckbox.AutoSize = true;
            MaxFileSizeCheckbox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MaxFileSizeCheckbox.Location = new Point(72, 58);
            MaxFileSizeCheckbox.Name = "MaxFileSizeCheckbox";
            MaxFileSizeCheckbox.Size = new Size(85, 25);
            MaxFileSizeCheckbox.TabIndex = 3;
            MaxFileSizeCheckbox.Text = "File Size";
            MaxFileSizeCheckbox.UseVisualStyleBackColor = true;
            MaxFileSizeCheckbox.CheckedChanged += MaxSizeCheckbox_CheckedChanged;
            // 
            // OptionsGBox
            // 
            OptionsGBox.Controls.Add(MaxFileSizeComboBox);
            OptionsGBox.Controls.Add(MaxFileSizeCheckbox);
            OptionsGBox.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            OptionsGBox.Location = new Point(12, 125);
            OptionsGBox.Name = "OptionsGBox";
            OptionsGBox.Size = new Size(481, 129);
            OptionsGBox.TabIndex = 4;
            OptionsGBox.TabStop = false;
            OptionsGBox.Text = "OPTIONS";
            // 
            // MaxFileSizeComboBox
            // 
            MaxFileSizeComboBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MaxFileSizeComboBox.FormattingEnabled = true;
            MaxFileSizeComboBox.Location = new Point(193, 56);
            MaxFileSizeComboBox.Name = "MaxFileSizeComboBox";
            MaxFileSizeComboBox.Size = new Size(212, 29);
            MaxFileSizeComboBox.TabIndex = 5;
            // 
            // MainFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(505, 338);
            Controls.Add(OptionsGBox);
            Controls.Add(ConvertProgressBar);
            Controls.Add(OpenPngButton);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainFrame";
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IcoCraft";
            Load += MainFrame_Load;
            OptionsGBox.ResumeLayout(false);
            OptionsGBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private OpenFileDialog OpenPngDialogue;
        private SaveFileDialog SaveIcoDialogue;
        private Button OpenPngButton;
        private ProgressBar ConvertProgressBar;
        private CheckBox MaxFileSizeCheckbox;
        private GroupBox OptionsGBox;
        private ComboBox MaxFileSizeComboBox;
    }
}