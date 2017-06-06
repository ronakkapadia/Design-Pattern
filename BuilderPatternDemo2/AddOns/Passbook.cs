using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternDemo2.AddOns
{
    public class Passbook : AddOn
    {
        public string IFSCCode { get; set; }

        public string MICRCode { get; set; }
    }
}
