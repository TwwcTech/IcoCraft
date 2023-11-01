namespace IcoCraft.backend
{
    internal class IconConverterTool
    {
        private string? _pngFile;
        private Bitmap? _pngBitmap;
        private int _maxWidth = 128;
        private int _minWidth = 64;
        private readonly string? _defaultSaveName = $"CraftedICO_{DateTime.Today.Date:ddMMyyyy}";
        private string? _saveDestination;

        public string? PngFile
        {
            get => _pngFile;
            set => _pngFile = value;
        }

        public Bitmap? PngBitmap
        {
            get => _pngBitmap;
            private set => _pngBitmap = value;
        }

        public int MaxWidth
        {
            get => _maxWidth;
            set => _maxWidth = value;
        }

        public int MinWidth
        {
            get => _minWidth;
            set => _minWidth = value;
        }

        public string? DefaultSaveName
        {
            get => _defaultSaveName;
        }

        public string? SaveDestination
        {
            get => _saveDestination;
            set => _saveDestination = value;
        }

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
