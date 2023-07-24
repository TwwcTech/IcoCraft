using IcoCraft.backend.Singletons;

namespace IcoCraft.backend.EventHandlers.Subscribers
{
    internal class FileProcessOperator
    {
        public void OnDrageEnter(object sender, DragEventArgs e)
        {
            if (e.Data!.GetDataPresent(DataFormats.FileDrop)) // Remove the '!' if issues arise
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        public void OnDragDrop(object sender, DragEventArgs e, TextBox pngFileTextBox) // Add TextBox Param
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach(string file in files)
            {
                if (IconConverterTool.Instance.IsPngFile(file) && IconConverterTool.Instance.IsCorrectFileSize(file))
                {
                    pngFileTextBox.Text = file;
                }
                else
                {
                    pngFileTextBox.Text = string.Empty;
                    MessageBox.Show("File type must be PNG and file size must be between 32x32 and 64x64", "File Size Entry Error");
                }
            }
        }
    }
}
