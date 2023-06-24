using Freedom.Utility.Models.EntityRTO;
using System;
using System.Collections.Generic;

namespace Freedom.Utility.Models.EntityRPT
{
    public class BankStatementRPT
    {
        public string CompanyName { get; set; }

        public string CompanyAddress { get; set; }

        public string CompanyPhone { get; set; }

        public string CompanyEmail { get; set; }

        public string BankName { get; set; }

        public string BankAccountNumber { get; set; }

        public string AccountHolder { get; set; }

        public string Agency { get; set; }

        public string Phone { get; set; }

        public DateTime DateSince { get; set; }

        public DateTime DateUntil { get; set; }

        public long ChecNumberSince { get; set; }

        public long ChecNumberUntil { get; set; }

        public int MoneyId { get; set; }

        public string MoneyName { get; set; }

        public int BankAccountTypeId { get; set; }

        public string BankAccountTypeName { get; set; }

        public List<BankStatementRTO> BankStatementRTOs { get; set; }
    }
}