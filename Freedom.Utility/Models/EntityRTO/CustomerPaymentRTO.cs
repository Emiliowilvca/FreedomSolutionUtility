﻿using Freedom.Utility.Models.EntityBase;
using Freedom.Utility.Models.InterfaceRTO;

namespace Freedom.Utility.Models.EntityRTO
{
    public class CustomerPaymentRTO : CustomerPaymentBase, ICustomerPaymentRTO
    {
        public string CustomerName { get; set; }

        public string CustomerRuc { get; set; }

        public string MoneyName { get; set; }

        public string MoneySymbol { get; set; }

        public string DecimalPlaces { get; set; }

        public string ShopName { get; set; }

        public string BoxName { get; set; }

        public string AccountName { get; set; }
    }
}