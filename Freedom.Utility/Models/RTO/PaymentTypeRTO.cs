﻿using Freedom.Utility.Models.BaseRTO;

namespace Freedom.Utility.Models.RTO
{
    public class PaymentTypeRTO : IPaymentTypeRTO
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}