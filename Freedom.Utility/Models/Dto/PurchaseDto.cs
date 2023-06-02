﻿using Freedom.Utility.Models.BaseEntity;

namespace Freedom.Utility.Models.Dto
{
    [Serializable]
    public class PurchaseDto : IEntity, IPurchase
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public DateTime PurchaseDate { get; set; }

        public long InvoiceNum { get; set; }

        public int ProviderId { get; set; }

        public int OperationTypeId { get; set; }

        public int MoneyId { get; set; }

        public Guid UserId { get; set; }

        public int ShopId { get; set; }

        public int BoxId { get; set; }

        public int CarrierId { get; set; }

        public decimal Total { get; set; }

        public decimal TotalTax { get; set; }

        public decimal ImportExpence { get; set; }

        public bool ItsImport { get; set; }

        public decimal Exchange { get; set; }

        public bool Status { get; set; }

        public string Note { get; set; }

        public string Timbrado { get; set; }

        public ICollection<PurchaseDetailDto> PurchaseDetails { get; set; }

        public ICollection<PurchaseInstallmentDto> PurchaseInstallments { get; set; }
    }
}