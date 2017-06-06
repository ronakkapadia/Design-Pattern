using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternDemo2.Documents
{
    class DrivingLicense : Document
    {
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public string LicenseNo { get; set; }
    }
}
