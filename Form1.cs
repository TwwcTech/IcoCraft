using IcoCraft.frontend.Windows;
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

        }

        private void OpenPngButton_Click(object sender, EventArgs e)
        {
            OpenPngDialogue.Title = "Select PNG File";
            OpenPngDialogue.Filter = ".png|*.png";
            OpenPngDialogue.InitialDirectory = @"C:\";
            if (OpenPngDialogue.ShowDialog() == DialogResult.OK)
            {
                SaveIcoDialogue.Title = "Save Icon Dialoge";
                SaveIcoDialogue.Filter = ".ico|*.ico";
                SaveIcoDialogue.InitialDirectory = @"C:\";
                if (SaveIcoDialogue.ShowDialog() == DialogResult.OK)
                {
                    IconConverterTool iconConverterTool = new()
                    {
                        PngFilePath = OpenPngDialogue.FileName,
                        MaxWidth = 256,
                        MinWidth = 64,
                        SaveDestination = SaveIcoDialogue.FileName
                    };
                    iconConverterTool.ConvertToICO();
                }
            }
        }

        private void ViewCraftedButton_Click(object sender, EventArgs e)
        {
            Hide();
            Form viewCraftedForm = new CraftedFilesWindow();
            viewCraftedForm.ShowDialog();
            if (!viewCraftedForm.Visible)
            {
                Show();
            }
        }
    }
}