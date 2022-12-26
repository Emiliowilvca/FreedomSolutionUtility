using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;

namespace Freedom.Frontend.Models.Bindable
{
    public class PosDocumentBind : BindableBase, IPosDocument
    {
        private int _id;
        private int _companyId;
        private string _name;
        private long _invoiceLastCreated;
        private long _invoiceSince;
        private long _invoiceUntil;
        private long _creditNoteLastCreted;
        private long _creditNoteSince;
        private long _creditNoteUntil;
        private long _promissoryLastCreated;
        private long _promissorySince;
        private long _promissoryUntil;
        private long _receiptLastCreated;
        private long _receiptSince;
        private long _receiptUntil;
        private long _returnLastCreated;
        private long _returnSince;
        private long _returnUntil;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }

        public long InvoiceLastCreated { get => _invoiceLastCreated; set => SetProperty(ref _invoiceLastCreated, value); }

        public long InvoiceSince { get => _invoiceSince; set => SetProperty(ref _invoiceSince, value); }

        public long InvoiceUntil { get => _invoiceUntil; set => SetProperty(ref _invoiceUntil, value); }

        public long CreditNoteLastCreted { get => _creditNoteLastCreted; set => SetProperty(ref _creditNoteLastCreted, value); }

        public long CreditNoteSince { get => _creditNoteSince; set => SetProperty(ref _creditNoteSince, value); }

        public long CreditNoteUntil { get => _creditNoteUntil; set => SetProperty(ref _creditNoteUntil, value); }

        public long PromissoryLastCreated { get => _promissoryLastCreated; set => SetProperty(ref _promissoryLastCreated, value); }

        public long PromissorySince { get => _promissorySince; set => SetProperty(ref _promissorySince, value); }

        public long PromissoryUntil { get => _promissoryUntil; set => SetProperty(ref _promissoryUntil, value); }

        public long ReceiptLastCreated { get => _receiptLastCreated; set => SetProperty(ref _receiptLastCreated, value); }

        public long ReceiptSince { get => _receiptSince; set => SetProperty(ref _receiptSince, value); }

        public long ReceiptUntil { get => _receiptUntil; set => SetProperty(ref _receiptUntil, value); }

        public long ReturnLastCreated { get => _returnLastCreated; set => SetProperty(ref _returnLastCreated, value); }

        public long ReturnSince { get => _returnSince; set => SetProperty(ref _returnSince, value); }

        public long ReturnUntil { get => _returnUntil; set => SetProperty(ref _returnUntil, value); }
    }
}