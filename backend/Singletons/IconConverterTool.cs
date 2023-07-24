using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcoCraft.backend.Singletons
{
    public sealed class IconConverterTool
    {
        private static IconConverterTool? _instance;
        private static readonly object instanceLock = new();

        private IconConverterTool () { }

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

        public bool IsPngFile(string path)
        {
            lock (instanceLock)
            {
                if (!path.Contains(".png") || !path.Contains(".PNG"))
                {
                    return false;
                }
                return true;
            }
        }

        public void IsCorrectFileSize(string path) // Change return type to 'bool'
        {
            lock (instanceLock)
            {
                // Code goes here
            }
        }

        public void ConvertToIcon(string path)
        {
            lock (instanceLock)
            {
                // Code goes here
            }
        }
    }
}
