﻿namespace Freedom.Utility.Models.BaseEntity
{
    public interface ITaxPayerStatus : IEntity
    {
        int CompanyId { get; set; }

        string Name { get; set; }
    }
}