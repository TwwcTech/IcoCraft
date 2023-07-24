using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcoCraft.backend.Singletons
{
    internal class IconConverterTool
    {
        private readonly IconConverterTool? _instance;
        object instanceLock = new();

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
