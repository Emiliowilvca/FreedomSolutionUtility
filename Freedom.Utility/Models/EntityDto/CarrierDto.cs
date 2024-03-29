﻿using Freedom.Utility.Models.InterfaceEntity;
using System;
namespace Freedom.Utility.Models.EntityDto
{
    [Serializable]
    public class CarrierDto : IEntity, ICarrier
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public string Name { get; set; }

        public string Person { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Mobile { get; set; }
    }
}