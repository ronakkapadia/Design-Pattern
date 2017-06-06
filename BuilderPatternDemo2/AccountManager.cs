using BuilderPatternDemo2.Accounts;
using BuilderPatternDemo2.AddOns;
using BuilderPatternDemo2.Applicants;
using BuilderPatternDemo2.Builders;
using BuilderPatternDemo2.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternDemo2
{
    public class AccountManager
    {
        public Account BuildSavingsAccount(Applicant applicant, List<Document> documents, List<AddOn> addOns)
        {
            var accountBuilder = new SavingsBuilder();
            accountBuilder.AddApplicant(applicant);
            accountBuilder.AddAddons(addOns);
            accountBuilder.AddDocuments(documents);
            return accountBuilder.GetAccount();
        }

        public Account BuildCurrentAccount(Applicant applicant, List<Document> documents, List<AddOn> addOns)
        {
            var accountBuilder = new CurrentAccountBuilder();
            accountBuilder.AddApplicant(applicant);
            accountBuilder.AddAddons(addOns);
            accountBuilder.AddDocuments(documents);
            return accountBuilder.GetAccount();
        }
    }
}
