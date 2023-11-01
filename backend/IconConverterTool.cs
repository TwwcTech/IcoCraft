namespace IcoCraft.backend
{
    internal class IconConverterTool
    {
        public string? PngFile { get; set; }

        public Bitmap? PngBitmap { get; private set; }

        public int MaxWidth { get; set; } = 128;

        public int MinWidth { get; set; } = 64;

        public string? DefaultSaveName { get; } = $"CraftedICO_{DateTime.Today.Date:ddMMyyyy}";

        public string? SaveDestination { get; set; }

        public FileInfo[]? ICOs { get; set; }

        public void ConvertToICO()
        {
            try
            {
                PngBitmap = (Bitmap)Image.FromFile(PngFile!);
                if (PngBitmap.Width > MaxWidth || PngBitmap.Width < MinWidth)
                {
                    MessageBox.Show($"The file must not be greater than {MaxWidth} or less than {MinWidth}", "PNG File Size Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using FileStream stream = File.OpenWrite(SaveDestination!);
                Icon.FromHandle(PngBitmap.GetHicon()).Save(stream);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public void GetICOs()
        {
            DirectoryInfo directoryInfo = new(SaveDestination!);
            ICOs = directoryInfo.GetFiles("*.ico");
        }
    }
}
