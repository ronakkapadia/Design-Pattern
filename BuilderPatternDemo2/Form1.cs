using BuilderPatternDemo2.AddOns;
using BuilderPatternDemo2.Applicants;
using BuilderPatternDemo2.Documents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuilderPatternDemo2
{
    public partial class Form1 : Form
    {
        AccountManager manager = new AccountManager();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSavings_Click(object sender, EventArgs e)
        {
            Applicant applicant = new Major
            {
                Name = "Vikas",
                Age = 28,
                IsSalaried = true,
                Address = "Mumbai"
            };
            List<Document> docs = new List<Document>()
            {
                new Passport() { IsCitizen=true },
                new Aadhar() {AdhaarNo = "123456", Name="Vikas" }
            };

            List<AddOn> addons = new List<AddOn>()
            {
                new Cheque() { NoOfLeaf=25 },
                new NetBanking() { UserID="Vikas", Password="123456" },
                new Passbook() { IFSCCode = "123456", MICRCode = "987987"}
            };

            var savingsObj = manager.BuildSavingsAccount(applicant, docs, addons);
        }

        private void btnCurrent_Click(object sender, EventArgs e)
        {
            Applicant applicant = new Major
            {
                Name = "Vikas",
                IsSalaried = true,
                Address = "Mumbai"
            };
            List<Document> docs = new List<Document>()
            {
                new Passport() { IsCitizen=true },
                new Aadhar() {AdhaarNo = "123456", Name="Vikas" }
            };

            List<AddOn> addons = new List<AddOn>()
            {
                new Cheque() { NoOfLeaf=25 },
                new NetBanking() { UserID="Vikas", Password="123456" },
                new Passbook() { IFSCCode = "123456", MICRCode = "987987"}
            };

            var currentObj = manager.BuildCurrentAccount(applicant, docs, addons);
        }
    }
}
