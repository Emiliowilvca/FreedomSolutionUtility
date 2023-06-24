using System;

namespace Freedom.Utility.Models.InterfaceEntity
{
    public interface IStock
    {
        int Id { get; set; }

        int CompanyId { get; set; }

        int ProductId { get; set; }

        int ShopId { get; set; }

        decimal Quantity { get; set; }

        string Lote { get; set; }

        DateTime Manufactory { get; set; }

        DateTime Expiration { get; set; }

        int SectorId { get; set; }

        int Shelving { get; set; }

        int Side { get; set; }

        int Column { get; set; }

        int Line { get; set; }
    }
}