using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.EntityDto
{
    public class AlterStockDto : IAlterStock
    {
        public int Id { get; set; }

        public DateTime AlterDate { get; set; }

        public string SettingType { get; set; }

        public int CompanyId { get; set; }

        public decimal Decrease { get; set; }

        public DateTime Expiration { get; set; }

        public decimal Increase { get; set; }

        public string Lote { get; set; }

        public DateTime Manufactory { get; set; }

        public string NoteReason { get; set; }

        public int OperationTypeId { get; set; }

        public int ProductId { get; set; }

        public int ShopId { get; set; }

        public Guid UserId { get; set; }

        public int SectorId { get; set; }

        public int Shelving { get; set; }

        public int Side { get; set; }

        public int Column { get; set; }

        public int Line { get; set; }
    }
}