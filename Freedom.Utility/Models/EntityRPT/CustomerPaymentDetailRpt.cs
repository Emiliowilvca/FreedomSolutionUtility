using Freedom.Utility.Models.InterfaceEntity;
using System;

namespace Freedom.Utility.Models.EntityRPT
{
    public class CustomerPaymentDetailRpt : ICustomerPaymentDetail
    {
        public long Id { get; set; }

        public int CustomerPaymentId { get; set; }

        public int SaleId { get; set; }

        public int SaleFeesId { get; set; }

        public byte NumberFees { get; set; }

        public decimal Interest { get; set; }

        public decimal ValuePayment { get; set; }

        public decimal Exchange { get; set; }

        public long? Invoice { get; set; }

        public DateTime SalesDate { get; set; }
    }
}