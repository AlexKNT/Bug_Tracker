using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bug_Tracker.ClassLib
{
    public class ModelBug
    {
        public string BugProductName { get; set; }
        public string BugDescription { get; set; }
        public string BugText { get; set; }
        public string BugReportedVersion { get; set; }
        public string BugFixedVersion { get; set; }
        public DateTime BugWhenReported { get; set; }
        public DateTime BugWhenFixed { get; set; }
        public bool BugFixed { get; set; }
        public int BugID { get; set; }
    }
}