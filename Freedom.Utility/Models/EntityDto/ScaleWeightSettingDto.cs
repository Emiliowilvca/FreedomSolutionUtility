using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.EntityDto
{
    /// <summary>
    /// Configuracion de balanza digital
    /// </summary>
    public class ScaleWeightSettingDto : IScaleWeightSetting
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public int ShopId { get; set; }

        public int MeasureId { get; set; }

        public int FlagValue { get; set; }

        public int FlagStartIndex { get; set; }

        public int FlagLength { get; set; }

        public int CodeStartIndex { get; set; }

        public int CodeLength { get; set; }

        public int WeightStartIndex { get; set; }

        public int WeightLength { get; set; }

        public decimal WeightConverter { get; set; }
    }
}