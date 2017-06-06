using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternDemo2.Applicants
{
    public abstract class Applicant
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public int Age { get; set; }
    }
}
