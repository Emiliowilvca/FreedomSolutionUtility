using Freedom.Utility.Models.BaseEntity;
using System;

namespace Freedom.Utility.Models.Dto
{
    [Serializable]
    public class PriceDto : IPrice
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public int ProductId { get; set; }

        public int MoneyId { get; set; }

        public short Level { get; set; }

        public decimal ValuePrice { get; set; }

        /// <summary>
        /// price according to quantity
        /// </summary>
        public short QuantityPrice { get; set; }

        public byte TypePrice { get; set; }
    }
}