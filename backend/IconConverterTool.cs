namespace IcoCraft.backend
{
    internal sealed class IconConverterTool
    {
        public string? PngFilePath { get; set; }

        public int MaxWidth { get; set; }

        public int MinWidth { get; set; } = 64;

        public static string? DefaultSaveName { get; } = $"ICO_{DateTime.Today.Date:ddMMyyyy}";

        public string? SaveDestination { get; set; }

        public static List<int> OptionalFileSizes { get; set; } = new List<int>() { 256, 512 };

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