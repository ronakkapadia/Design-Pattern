using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternDemo2.Applicants
{
    public class Minor : Applicant
    {
        public string Guardian { get; set; }

        public string Relation { get; set; }

        public string GuardianContactNo { get; set; }
    }
}
