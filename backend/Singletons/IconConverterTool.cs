namespace IcoCraft.backend.Singletons
{
    internal class IconConverterTool
    {
        private readonly static IconConverterTool? _instance;
        private static readonly object instanceLock = new();

        public static IconConverterTool Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (_instance == null)
                    {
                        return new IconConverterTool();
                    }
                    return _instance;
                }
            }
        }

        private Bitmap? _pngFile;
        private int _maxWidth = 128;
        private int _minWidth = 64;
        private string? _saveDestination;

        public Bitmap? PngFile
        {
            get => _pngFile;
            set => _pngFile = value;
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

        public string? SaveDestination
        {
            get => _saveDestination;
            set => _saveDestination = value;
        }

        // DELETE
        public bool IsPngfile(string pngPath)
        {
            lock (instanceLock)
            {
                if (!pngPath.Contains(".png") || !pngPath.Contains(".PNG"))
                {
                    return false;
                }
                return true;
            }
        }

        // UPDATE
        public bool IsCorrectFileSize(string pngPath)
        {
            lock (instanceLock)
            {
                Bitmap bitmap;

                try
                {
                    bitmap = (Bitmap)Image.FromFile(pngPath);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.ToString());
                }

                if (bitmap.Width > 128 || bitmap.Width < 32)
                {
                    return false;
                }
                return true;
            }
        }

        //UPDATE
        public void ConvertToIcon(string pngPath, string saveDestination)
        {
            lock (instanceLock)
            {
                Bitmap bitmap;

                using (FileStream stream = File.OpenWrite(saveDestination))
                {
                    try
                    {
                        bitmap = (Bitmap)Image.FromFile(pngPath);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.ToString());
                    }

                    try
                    {
                        Icon.FromHandle(bitmap.GetHicon()).Save(stream);
                    }
                    catch (IOException ex)
                    {
                        throw new Exception(ex.ToString());
                    }
                }
            }
        }
    }
}
