using BuilderPatternDemo2.AddOns;
using BuilderPatternDemo2.Applicants;
using BuilderPatternDemo2.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternDemo2.Accounts
{
    public abstract class Account
    {
        public Applicant Applicant { get; protected set; }

        public List<Document> Documents { get; protected set; }

        public List<AddOn> AddOns { get; protected set; }

        public abstract void SetApplicant(Applicant applicant);

        public abstract void SetDocument(List<Document> documents);

        public abstract void SetAddOns(List<AddOn> addOns);
    }
}
