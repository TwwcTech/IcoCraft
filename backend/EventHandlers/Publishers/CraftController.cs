namespace IcoCraft.backend.EventHandlers.Publishers
{
    internal class CraftController
    {
        public event CraftHandler? Crafter;

        public string GetPngPath(string pngPath)
        {
            if (pngPath == string.Empty)
            {
                return string.Empty;
            }
            return pngPath;
        }

        public string GetCraftedFileName(string fileName)
        {
            if (fileName == string.Empty)
            {
                return string.Empty;
            }
            return fileName;
        }

        public void Craft(string pngPath, string fileName)
        {
            Crafter?.Invoke(pngPath, fileName);
        }
    }
}
