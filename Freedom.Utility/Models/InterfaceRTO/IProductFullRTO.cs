using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.InterfaceRTO
{

    [Obsolete("use model IProductFull")]
    public interface IProductFullRTO : IProduct 
    {
        /* names */
        string SubGroupName { get; set; }

        string MeasureName { get; set; }

        string PackageName { get; set; }

        string PriorityName { get; set; }

        string SourceName { get; set; }

        string BrandName { get; set; }

        string GroupName { get; set; }

        //prices

        short PriceLevel { get; set; }

        /// <summary>
        /// Price per Quantity
        /// </summary>
        short PriceQuantity { get; set; }

        byte TypePrice { get; set; }

        string MoneyName { get; set; }

        // stock

        int StockId { get; set; }

        string Lote { get; set; }

        DateTime Manufactory { get; set; }

        DateTime Expiration { get; set; }

        int ShelvingSectorId { get; set; }

        int Shelving { get; set; }

        int ShelvingSide { get; set; }

        int ShelvingColumn { get; set; }

        int ShelvingLine { get; set; }
    }
}