using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPatternDemo2.Accounts;
using BuilderPatternDemo2.AddOns;
using BuilderPatternDemo2.Documents;
using BuilderPatternDemo2.Applicants;

namespace BuilderPatternDemo2.Builders
{
    public class SavingsBuilder : AccountBuilder
    {
        private SavingsAccount account;

        public SavingsBuilder()
        {
            this.account = new SavingsAccount();
        }

        public override void AddAddons(List<AddOn> addOns)
        {
            account.SetAddOns(addOns);
        }

        public override void AddApplicant(Applicant applicant)
        {
            account.SetApplicant(applicant);
        }

        public override void AddDocuments(List<Document> documents)
        {
            account.SetDocument(documents);
        }

        public override Account GetAccount()
        {
            return account;
        }
    }
}
