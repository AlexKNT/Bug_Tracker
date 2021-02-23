using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bug_Tracker
{
    public static class Globals
    {
        public enum ProductType { Dev, Vplay, Placeholder }

        public static ProductType Product { get; set; }

        private static readonly List<string> versionsDev = new List<string>
        {
            "0.01"
        };

        private static readonly List<string> versionsVplay = new List<string>
        {
            "232", "237"
        };

        public static readonly Dictionary<ProductType, List<string>> productVersions = new Dictionary<ProductType, List<string>>
        {
            { ProductType.Dev,      versionsDev },
            { ProductType.Vplay,    versionsVplay }
        };
    }
}