using IcoCraft.backend;

namespace IcoCraft
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            MaxFileSizeComboBox.Enabled = false;
            foreach (int fileSize in IconConverterTool.OptionalFileSizes)
            {
                MaxFileSizeComboBox.Items.Add(fileSize);
            }
            MaxFileSizeComboBox.Text = 128.ToString();
        }

        private void OpenPngButton_Click(object sender, EventArgs e)
        {
            ConvertProgressBar.Maximum = 100;
            ConvertProgressBar.Value = 0;

            OpenPngDialogue.Title = "Select PNG File";
            OpenPngDialogue.Filter = ".png|*.png";
            OpenPngDialogue.InitialDirectory = @"C:\";
            OpenPngDialogue.FileName = IconConverterTool.DefaultSaveName;
            if (OpenPngDialogue.ShowDialog() == DialogResult.OK)
            {
                ConvertProgressBar.Value = 25;
                SaveIcoDialogue.Title = "Save Icon Dialoge";
                SaveIcoDialogue.Filter = ".ico|*.ico";
                SaveIcoDialogue.InitialDirectory = @"C:\";
                if (SaveIcoDialogue.ShowDialog() == DialogResult.OK)
                {
                    ConvertProgressBar.Value = 50;
                    IconConverterTool iconConverterTool = new()
                    {
                        PngFilePath = OpenPngDialogue.FileName,
                        MaxWidth = MaxFileSizeCheckbox.Checked ? int.Parse(MaxFileSizeComboBox.Text.Trim()) : 128,
                        SaveDestination = SaveIcoDialogue.FileName.Trim()
                    };
                    ConvertProgressBar.Value = 75;
                    iconConverterTool.ConvertToICO();
                    ConvertProgressBar.Value = 100;
                }
            }
        }

        private void MaxSizeCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            MaxFileSizeComboBox.Enabled = MaxFileSizeCheckbox.Checked;
            MaxFileSizeComboBox.Text = MaxFileSizeCheckbox.Checked ? string.Empty : 128.ToString();
        }
    }
}