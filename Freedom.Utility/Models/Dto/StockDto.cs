using System;
using Freedom.Utility.Models.BaseEntity;

namespace Freedom.Utility.Models.Dto
{
    [Serializable]
    public class StockDto : IStock
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public int ProductId { get; set; }

        public int ShopId { get; set; }

        public decimal Quantity { get; set; }

        public string Lote { get; set; }

        public DateTime Manufactory { get; set; }

        public DateTime Expiration { get; set; }

        public int SectorId { get; set; }

        public int Shelving { get; set; }

        public int Side { get; set; }

        public int Column { get; set; }

        public int Line { get; set; }
    }
}