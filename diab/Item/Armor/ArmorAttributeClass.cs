using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diab
{
    /// <summary>
    /// stats for armor
    /// </summary>
    public abstract class ArmorAttributeClass
    {
        public abstract int Str { get; }
        public abstract int Dex { get; }
        public abstract int Magic { get; }
    }
}
