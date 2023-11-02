namespace IcoCraft.backend
{
    internal class IconConverterTool
    {
        public string? PngFilePath { get; set; }

        public int MaxWidth { get; set; } = 128;

        public int MinWidth { get; set; } = 64;

        public string? DefaultSaveName { get; } = $"CraftedICO_{DateTime.Today.Date:ddMMyyyy}";

        public string? SaveDestination { get; set; }

        public void ConvertToICO()
        {
            try
            {
                var pngBitmap = (Bitmap)Image.FromFile(PngFilePath!);
                if (pngBitmap.Width > MaxWidth || pngBitmap.Width < MinWidth)
                {
                    MessageBox.Show($"The file must not be greater than {MaxWidth} or less than {MinWidth}", "PNG File Size Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using FileStream stream = File.OpenWrite(SaveDestination!);
                Icon.FromHandle(pngBitmap.GetHicon()).Save(stream);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}