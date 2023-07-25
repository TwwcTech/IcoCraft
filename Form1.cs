using IcoCraft.backend.EventHandlers.Publishers;
using IcoCraft.backend.EventHandlers.Subscribers;
using IcoCraft.backend.Singletons;
using IcoCraft.resources;

namespace IcoCraft
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();

            PngPathEntryBox.AllowDrop = true;
            PngPathEntryBox.DragEnter += PngPathEntryBox_DragEnter;
            PngPathEntryBox.DragDrop += PngPathEntryBox_DragDrop;
        }

        private void PngPathEntryBox_DragDrop(object? sender, DragEventArgs e)
        {
            try
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string file in files)
                {
                    if (IconConverterTool.Instance.IsCorrectFileSize(file))
                    {
                        PngPathEntryBox.Text = file;
                    }
                    else
                    {
                        PngPathEntryBox.Text = "";
                        MessageBox.Show("Not correct size");
                    }
                }
            }
            catch (NotImplementedException)
            {
                throw new NotImplementedException();
            }
        }

        private void PngPathEntryBox_DragEnter(object? sender, DragEventArgs e)
        {
            try
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    e.Effect = DragDropEffects.Copy;
                }
            }
            catch (NotImplementedException)
            {
                throw new NotImplementedException();
            }
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            try
            {
                string savePath = DestDirManager.Instance.GetCorrectDir();
                if (!Directory.Exists(savePath + "CraftedIcons"))
                {
                    DestDirManager.Instance.CreateIconsFolder(savePath);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        private void CraftButton_Click(object sender, EventArgs e)
        {
            CraftController craftController = new();
            CraftOperator craftOperator = new();
            craftController.Crafter += craftOperator.OnCraft;

            string pngPath = craftController.GetPngPath(PngPathEntryBox.Text.Trim());
            string craftedIconName = craftController.GetCraftedFileName(IconNameEntryBox.Text.Trim());

            craftController.Craft(pngPath, $"{"" /* Add Save Path Here */}{craftedIconName}.ico");

            PngPathEntryBox.Text = string.Empty;
            IconNameEntryBox.Text = string.Empty;
        }

        private void ViewCraftedButton_Click(object sender, EventArgs e)
        {

        }

        /*
         * TODO:
         *     + Complete the GUI for Crafted Files Window
         */
    }
}