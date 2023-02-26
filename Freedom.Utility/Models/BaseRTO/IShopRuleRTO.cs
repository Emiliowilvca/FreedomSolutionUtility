﻿using Freedom.Utility.Models.BaseEntity;

namespace Freedom.Utility.Models.BaseRTO
{
    public interface IShopRuleRTO : IShopRule
    {
        string CustomerName { get; set; }

        string OperTypeCashPurchaseName { get; set; }

        string OperTypeCashSaleName { get; set; }

        string OperTypeCreditPurchaseName { get; set; }

        string OperTypeCreditSaleName { get; set; }
    }
}