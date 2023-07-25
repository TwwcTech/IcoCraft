using IcoCraft.resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcoCraft.backend.Singletons
{
    public sealed class DestDirManager
    {
        private readonly static DestDirManager? _instance;
        private readonly static object _instanceLock = new();

        private DestDirManager() { }

        public static DestDirManager Instance
        {
            get
            {
                lock (_instanceLock)
                {
                    if (_instance == null)
                    {
                        return new DestDirManager();
                    }
                    return _instance;
                }
            }
        }

        public string GetCorrectDir()
        {
            lock (_instanceLock)
            {
                if (Directory.Exists(Statics.PrimaryDestDirPath))
                {
                    return Statics.PrimaryDestDirPath;
                }
                return Statics.AltDestDirPath;
            }
        }

        public void CreateIconsFolder(string correctSubPath)
        {
            lock (_instanceLock)
            {
                try
                {
                    Directory.CreateDirectory(correctSubPath + "CraftedIcons");
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.ToString());
                }
            }
        }

        public IEnumerable<FileInfo> GetIcons(string craftedIconsPath)
        {
            lock (_instanceLock)
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(craftedIconsPath);
                return directoryInfo.EnumerateFiles(craftedIconsPath, SearchOption.TopDirectoryOnly);
            }
        }
    }
}
