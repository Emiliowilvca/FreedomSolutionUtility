using Freedom.Utility.Models.InterfaceEntity;
using System;

namespace Freedom.Utility.Models.EntityDto
{
    [Serializable]
    public class PaymentTypeDto : IEntity, IPaymentType
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public string Name { get; set; }
    }
}