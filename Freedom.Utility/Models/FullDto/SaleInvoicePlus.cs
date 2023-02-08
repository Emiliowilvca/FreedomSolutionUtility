using Freedom.Utility.Models.RPT;

namespace Freedom.Utility.Models.FullDto
{
    public class SaleInvoicePlus : SaleInvoiceRpt
    {
        public string SaleDetailJson { get; set; }

        public string SaleExpressDetailJson { get; set; }
    }
}