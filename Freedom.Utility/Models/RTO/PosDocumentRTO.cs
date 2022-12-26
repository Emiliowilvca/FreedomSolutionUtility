using Freedom.Utility.Models.BaseEntity;

namespace Freedom.Utility.Models.RTO
{
    public class PosDocumentRTO : IEntity, IPosDocument
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public string Name { get; set; }

        public long InvoiceLastCreated { get; set; }

        public long InvoiceSince { get; set; }

        public long InvoiceUntil { get; set; }

        public long CreditNoteLastCreted { get; set; }

        public long CreditNoteSince { get; set; }

        public long CreditNoteUntil { get; set; }

        public long PromissoryLastCreated { get; set; }

        public long PromissorySince { get; set; }

        public long PromissoryUntil { get; set; }

        public long ReceiptLastCreated { get; set; }

        public long ReceiptSince { get; set; }

        public long ReceiptUntil { get; set; }

        public long ReturnLastCreated { get; set; }

        public long ReturnSince { get; set; }

        public long ReturnUntil { get; set; }
    }
}