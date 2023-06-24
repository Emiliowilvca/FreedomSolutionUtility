using Freedom.Utility.Models.EntityRPT;

namespace Freedom.Utility.Models.EntityPlus
{
    public class SaleInvoicePlus : SaleInvoiceRpt
    {
        public string SaleDetailJson { get; set; }

        public string SaleExpressDetailJson { get; set; }
    }
}