using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternDemo2.Documents
{
    public class Passport : Document
    {
        public DateTime ValidFrom { get; set; }

        public DateTime ValidTo { get; set; }

        public bool IsCitizen { get; set; }

        public string PassportNumber { get; set; }
    }
}
