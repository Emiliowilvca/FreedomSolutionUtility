using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.EntityDto
{
    public class SaleSettingDto : ISaleSetting
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public int MoneyId { get; set; }

        public int CustomerId { get; set; }

        public int CustomerAccountId { get; set; }

        public int PersonId { get; set; }

        public int DefaultSaleCashId { get; set; }

        public int InvoiceRowQuantity { get; set; }

        public int ShopId { get; set; }

        public int OperTypeCashSale { get; set; }

        public int OperTypeCreditSale { get; set; }

        public int MaxItemInSale { get; set; }

        public decimal MaxDiscountPercent { get; set; }

        public int InstallmentPeriod { get; set; }

        public bool ModifyPriceInSales { get; set; }

        public bool ForceSaleIfStockIsZero { get; set; }
    }
}