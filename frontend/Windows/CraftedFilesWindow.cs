using IcoCraft.backend.Singletons;

namespace IcoCraft.frontend.Windows
{
    public partial class CraftedFilesWindow : Form
    {
        public CraftedFilesWindow()
        {
            InitializeComponent();
        }

        private void CraftedFilesWindow_Load(object sender, EventArgs e)
        {
            string savePath = DestDirManager.Instance.GetCorrectPath();
            FileInfo[] craftedIcons = DestDirManager.Instance.GetIcons($@"{savePath}CraftedIcons");
            CraftedIconsDataGrid.DataSource = craftedIcons;
            CraftedIconsDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            CraftedIconsDataGrid.Refresh();
        }
    }
}
