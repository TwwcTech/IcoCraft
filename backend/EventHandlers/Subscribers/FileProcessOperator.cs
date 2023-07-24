using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            foreach (string file in files)
            {
                if (IconConverterTool.Instance.IsCorrectFileSize(file)) 
                {
                    pngFileTextBox.Text = file;
                }
                else
                {
                    pngFileTextBox.Text = string.Empty;
                    MessageBox.Show("PNG file size not correct", "File Size Error");
                }
            }
        }
    }
}
