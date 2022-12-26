using Freedom.Utility.Models.BaseEntity;
using System;
using System.Collections.Generic;

namespace Freedom.Utility.Models.Dto
{
    [Serializable]
    public class SaleDto : ISale
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public DateTime SalesDate { get; set; }

        public long? Invoice { get; set; }

        public int ShopId { get; set; }

        public int BoxId { get; set; }

        public Guid UserId { get; set; }

        public int OperationTypeId { get; set; }

        public int MoneyId { get; set; }

        public int CustomerId { get; set; }

        public int CustomerAccountId { get; set; }

        public int PersonId { get; set; }

        public int EmployeeId { get; set; }

        public decimal Exchange { get; set; }

        public decimal TotalGross { get; set; }

        public decimal TotalCost { get; set; }

        public decimal TotalDiscount { get; set; }

        public decimal TotalTax { get; set; }

        public decimal TotalNet { get; set; }

        public bool Status { get; set; }

        public Guid SerialId { get; set; }

        public SaleAuthorizeDto SaleAuthorizeDto { get; set; }

        public IEnumerable<SaleDetailDto> SaleDetailsDtos { get; set; }

        public IEnumerable<SaleFeesDto> SaleFeesDtos { get; set; }
    }
}