using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPatternDemo2.AddOns;
using BuilderPatternDemo2.Applicants;
using BuilderPatternDemo2.Documents;

namespace BuilderPatternDemo2.Accounts
{
    public class SavingsAccount : Account
    {
        public override void SetAddOns(List<AddOn> addOns)
        {
            this.AddOns = addOns;
        }

        public override void SetApplicant(Applicant applicant)
        {
            this.Applicant = applicant;
        }

        public override void SetDocument(List<Document> documents)
        {
            this.Documents = documents;
        }
    }
}
