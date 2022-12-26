using System;

namespace Freedom.Utility.Models.NoSql
{
    public class Order : IEntityNosql
    {
        public Guid Id { get; set; }

        public DateTime DeliveryDate { get; set; }

        public DateTime Date { get; set; }

        public int CustomerId { get; set; }

        public double TotalOrder { get; set; }
    }
}