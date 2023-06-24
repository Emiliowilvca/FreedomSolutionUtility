namespace Freedom.Utility.Models.InterfaceEntity
{
    public interface ICustomerPaymentDetail
    {
        long Id { get; set; }

        int CustomerPaymentId { get; set; }

        int SaleId { get; set; }

        int SaleFeesId { get; set; }

        byte NumberFees { get; set; }

        decimal Interest { get; set; }

        decimal ValuePayment { get; set; }

        decimal Exchange { get; set; }
    }
}