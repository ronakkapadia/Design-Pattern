using BuilderPatternDemo2.Accounts;
using BuilderPatternDemo2.AddOns;
using BuilderPatternDemo2.Applicants;
using BuilderPatternDemo2.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternDemo2.Builders
{
    public abstract class AccountBuilder
    {
        public abstract void AddApplicant(Applicant applicant);

        public abstract void AddDocuments(List<Document> documents);

        public abstract void AddAddons(List<AddOn> addOns);

        public abstract Account GetAccount();

    }
}
