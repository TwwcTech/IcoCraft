using IcoCraft.backend.Singletons;
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

        private void CraftButton_Click(object sender, EventArgs e)
        {

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