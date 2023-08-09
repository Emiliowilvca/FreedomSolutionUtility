namespace Freedom.Utility.Models.InterfaceEntity
{

    /// <summary>
    /// Setting Barcode Balanza
    /// </summary>
    public interface IScaleWeightSetting : IEntity
    {
        int CompanyId { get; set; }

        int ShopId { get; set; }

        /// <summary>
        /// define si el peso se convierte en unidad
        /// </summary>
        int MeasureId { get; set; }

        /// <summary>
        /// valor de inicio de la balanza, ej: 22
        /// </summary>
        int FlagValue { get; set; }

        int FlagStartIndex { get; set; }

        int FlagLength { get; set; }

        int CodeStartIndex { get; set; }

        int CodeLength { get; set; }

        int WeightStartIndex { get; set; }

        int WeightLength { get; set; }

        /// <summary>
        /// valor extraido se divide para convertir a peso
        /// </summary>
        decimal WeightConverter { get; set; } 

    }
}