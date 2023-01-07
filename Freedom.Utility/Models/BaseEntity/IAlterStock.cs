namespace Freedom.Utility.Models.BaseEntity
{
    public interface IAlterStock
    {
        int Id { get; set; }

        DateTime AlterDate { get; set; }

        /// <summary>
        /// tipo de ajuste (aumentar o disminuir)
        /// </summary>
        string SettingType { get; set; }

        int CompanyId { get; set; }

        decimal Decrease { get; set; }

        DateTime Expiration { get; set; }

        decimal Increase { get; set; }

        string Lote { get; set; }

        DateTime Manufactory { get; set; }

        string NoteReason { get; set; }

        int OperationTypeId { get; set; }

        int ProductId { get; set; }

        int ShopId { get; set; }

        Guid UserId { get; set; }

        int SectorId { get; set; }

        int Shelving { get; set; }

        int Side { get; set; }

        int Column { get; set; }

        int Line { get; set; }
    }
}