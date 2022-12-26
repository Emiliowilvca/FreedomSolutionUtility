using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;
using System;
namespace Freedom.Frontend.Models.Bindable
{
    [Serializable]
    public class BoxBind : BindableBase, IBox, ISelectable
    {
        private int _id;
        private int _companyId;
        private int _shopId;
        private int _moneyId;
        private string _name;
        private long _creditNoteLastCreted;
        private long _creditNoteSince;
        private long _creditNoteUntil;
        private long _invoiceLastCreated;
        private long _invoiceSince;
        private long _invoiceUntil;
        private long _promissoryLastCreated;
        private long _promissorySince;
        private long _promissoryUntil;
        private long _receiptLastCreated;
        private long _receiptSince;
        private long _receiptUntil;
        private long _returnLastCreated;
        private long _returnSince;
        private long _returnUntil;
        private bool _isSelected;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public int ShopId { get => _shopId; set => SetProperty(ref _shopId, value); }

        public int MoneyId { get => _moneyId; set => SetProperty(ref _moneyId, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }

        public long CreditNoteLastCreted { get => _creditNoteLastCreted; set => SetProperty(ref _creditNoteLastCreted, value); }

        public long CreditNoteSince { get => _creditNoteSince; set => SetProperty(ref _creditNoteSince, value); }

        public long CreditNoteUntil { get => _creditNoteUntil; set => SetProperty(ref _creditNoteUntil, value); }

        public long InvoiceLastCreated { get => _invoiceLastCreated; set => SetProperty(ref _invoiceLastCreated, value); }

        public long InvoiceSince { get => _invoiceSince; set => SetProperty(ref _invoiceSince, value); }

        public long InvoiceUntil { get => _invoiceUntil; set => SetProperty(ref _invoiceUntil, value); }

        public long PromissoryLastCreated { get => _promissoryLastCreated; set => SetProperty(ref _promissoryLastCreated, value); }

        public long PromissorySince { get => _promissorySince; set => SetProperty(ref _promissorySince, value); }

        public long PromissoryUntil { get => _promissoryUntil; set => SetProperty(ref _promissoryUntil, value); }

        public long ReceiptLastCreated { get => _receiptLastCreated; set => SetProperty(ref _receiptLastCreated, value); }

        public long ReceiptSince { get => _receiptSince; set => SetProperty(ref _receiptSince, value); }

        public long ReceiptUntil { get => _receiptUntil; set => SetProperty(ref _receiptUntil, value); }

        public long ReturnLastCreated { get => _returnLastCreated; set => SetProperty(ref _returnLastCreated, value); }

        public long ReturnSince { get => _returnSince; set => SetProperty(ref _returnSince, value); }

        public long ReturnUntil { get => _returnUntil; set => SetProperty(ref _returnUntil, value); }

        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }

        public override void ResetEntity()
        {
            base.ResetEntity();
            Id = 0;
            CompanyId = 0;
            ShopId = 0;
            MoneyId = 0;
            Name = "";
            CreditNoteLastCreted = 0;
            CreditNoteSince = 0;
            CreditNoteUntil = 0;
            InvoiceLastCreated = 0;
            InvoiceSince = 0;
            InvoiceUntil = 0;
            PromissoryLastCreated = 0;
            PromissorySince = 0;
            PromissoryUntil = 0;
            ReceiptSince = 0;
            ReceiptUntil = 0;
            ReceiptLastCreated = 0;
            ReturnLastCreated = 0;
            ReturnSince = 0;
            ReturnUntil = 0;
            IsSelected = false;
        }

        public override object Clone()
        {
            BoxBind boxBind = (BoxBind)this.MemberwiseClone();
            return boxBind;
        }
    }
}