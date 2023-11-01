using IcoCraft.frontend.Windows;

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

            }
        }

        private void CraftButton_Click(object sender, EventArgs e)
        {
            SaveIcoDialogue.Title = "Save Icon Dialoge";
            SaveIcoDialogue.Filter = ".ico|*.ico";
            SaveIcoDialogue.InitialDirectory = @"C:\";
            if (SaveIcoDialogue.ShowDialog() == DialogResult.OK)
            {

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