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
            OpenPngDialogue = new OpenFileDialog();
            SaveIcoDialogue = new SaveFileDialog();
            OpenPngButton = new Button();
            ConvertProgressBar = new ProgressBar();
            SuspendLayout();
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
            // ConvertProgressBar
            // 
            ConvertProgressBar.Location = new Point(12, 265);
            ConvertProgressBar.Name = "ConvertProgressBar";
            ConvertProgressBar.Size = new Size(481, 23);
            ConvertProgressBar.TabIndex = 2;
            // 
            // MainFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(505, 338);
            Controls.Add(ConvertProgressBar);
            Controls.Add(OpenPngButton);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainFrame";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IcoCraft";
            Load += MainFrame_Load;
            ResumeLayout(false);
        }

        #endregion
        private OpenFileDialog OpenPngDialogue;
        private SaveFileDialog SaveIcoDialogue;
        private Button OpenPngButton;
        private ProgressBar ConvertProgressBar;
    }
}