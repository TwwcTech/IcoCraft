using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcoCraft.backend.EventHandlers.Publishers
{
    internal class CraftController
    {
        // Add events

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
            // Invoke delegate here
        }
    }
}
