﻿namespace Freedom.Utility.Models.BaseEntity
{
    public interface IOperationType
    {
        int Id { get; set; }

        int CompanyId { get; set; }

        string Name { get; set; }

        int SubclassId { get; set; }

        string Intials { get; set; }
    }
}