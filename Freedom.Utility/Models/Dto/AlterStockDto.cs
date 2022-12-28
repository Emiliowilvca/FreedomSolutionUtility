using Freedom.Utility.Models.BaseEntity;

namespace Freedom.Utility.Models.Dto
{
    public class AlterStockDto : IAlterStock
    {
        public int Id { get; set; }

        public DateTime AlterDate { get; set; }

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
    }
}