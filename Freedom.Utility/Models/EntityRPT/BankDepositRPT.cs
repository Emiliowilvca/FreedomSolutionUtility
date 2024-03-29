﻿using Freedom.Utility.Models.InterfaceRTO;
using Freedom.Utility.Models.EntityRTO;

namespace Freedom.Utility.Models.EntityRPT
{
    public class BankDepositRPT : BankDepositRTO, IBankDepositRTO
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

        public string MoneyName { get; set; }

        public int BankAccountTypeId { get; set; }

        public string BankAccountTypeName { get; set; }

        public List<BankDepositRTO> BankDepositRTOs { get; set; }
    }
}