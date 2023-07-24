using IcoCraft.backend.EventHandlers.Publishers;
using IcoCraft.backend.EventHandlers.Subscribers;

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
            CraftController craftController = new();
            CraftOperator craftOperator = new();
            craftController.Crafter += craftOperator.OnCraft;

            string pngPath = craftController.GetPngPath(PngPathEntryBox.Text.Trim());
            string craftedIconName = craftController.GetCraftedFileName(IconNameEntryBox.Text.Trim());

            craftController.Craft(pngPath, craftedIconName);

            PngPathEntryBox.Text = string.Empty;
            IconNameEntryBox.Text = string.Empty;
        }

        private void ViewCraftedButton_Click(object sender, EventArgs e)
        {

        }
    }
}