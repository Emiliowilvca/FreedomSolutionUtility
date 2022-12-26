using System;

namespace Freedom.Utility.Models.BaseRTO
{
    public interface IStockRTO
    {
        int Column { get; set; }
        int CompanyId { get; set; }
        DateTime Expiration { get; set; }
        int Id { get; set; }
        int Line { get; set; }
        string Lote { get; set; }
        DateTime Manufactory { get; set; }
        int ProductId { get; set; }
        decimal Quantity { get; set; }
        int SectorId { get; set; }
        int Shelving { get; set; }
        int ShopId { get; set; }
        int Side { get; set; }
    }
}