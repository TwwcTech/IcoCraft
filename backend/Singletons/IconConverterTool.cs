namespace IcoCraft.backend.Singletons
{
    public sealed class IconConverterTool
    {
        private readonly static IconConverterTool? _instance;
        private static readonly object instanceLock = new();

        private IconConverterTool() { }

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

        public bool IsPngFile(string pngPath)
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
                    // Testing
                    throw new Exception(ex.ToString());
                }

                if (bitmap.Width > 64 || bitmap.Width < 32)
                {
                    return false;
                }
                return true;
            }
        }

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
