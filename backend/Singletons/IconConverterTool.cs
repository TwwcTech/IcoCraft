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

        public IconConverterTool Instance
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
    }
}
