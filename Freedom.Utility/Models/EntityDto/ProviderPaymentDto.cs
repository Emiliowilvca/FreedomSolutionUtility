using Freedom.Utility.Models.InterfaceEntity;
using System;

namespace Freedom.Utility.Models.EntityDto
{
    [Serializable]
    public class ProviderPaymentDto : IEntity, IProviderPayment
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public DateTime DatePayment { get; set; }

        public int ProviderId { get; set; }

        public int MoneyId { get; set; }

        public Guid UserId { get; set; }

        public int ShopId { get; set; }

        public int OperationTypeId { get; set; }

        public int BoxId { get; set; }

        public int EmployeeId { get; set; }

        public long ReceiptNum { get; set; }

        public string Remark { get; set; }

        public decimal TotalPayment { get; set; }

        public decimal TotalInterest { get; set; }

        public decimal Exchange { get; set; }

        public bool Status { get; set; }
    }
}