namespace Freedom.Utility.Models.BaseEntity
{
    public interface IPosDocument
    {
        int Id { get; set; }

        int CompanyId { get; set; }

        string Name { get; set; }

        long InvoiceLastCreated { get; set; }

        long InvoiceSince { get; set; }

        long InvoiceUntil { get; set; }

        long CreditNoteLastCreted { get; set; }

        long CreditNoteSince { get; set; }

        long CreditNoteUntil { get; set; }

        long PromissoryLastCreated { get; set; }

        long PromissorySince { get; set; }

        long PromissoryUntil { get; set; }

        long ReceiptLastCreated { get; set; }

        long ReceiptSince { get; set; }

        long ReceiptUntil { get; set; }

        long ReturnLastCreated { get; set; }

        long ReturnSince { get; set; }

        long ReturnUntil { get; set; }
    }
}