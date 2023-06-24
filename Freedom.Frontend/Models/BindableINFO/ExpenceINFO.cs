using Freedom.Utility.Bindable;
using Freedom.Utility.Models.InterfaceEntity;
using Freedom.Utility.Models.InterfaceRTO;
using System;

namespace Freedom.Frontend.Models.BindableINFO
{
    public class ExpenceINFO : BindableBase, IExpenceRTO, ISelectable
    {
        private int _id;
        private int _companyId;
        private DateTime _dateExpence;
        private long _invoiceNum;
        private string _remark;
        private int _providerId;
        private int _operationTypeId;
        private int _moneyId;
        private Guid _userId;
        private int _shopId;
        private int _boxId;
        private int _expenceTypeId;
        private decimal _totalIva;
        private decimal _totalExenta;
        private decimal _totalGravada;
        private decimal _totalNeto;
        private decimal _exchange;
        private short _taxtype;
        private bool _isSelected;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public DateTime DateExpence { get => _dateExpence; set => SetProperty(ref _dateExpence, value); }

        public long InvoiceNum { get => _invoiceNum; set => SetProperty(ref _invoiceNum, value); }

        public string Remark { get => _remark; set => SetProperty(ref _remark, value); }

        public int ProviderId { get => _providerId; set => SetProperty(ref _providerId, value); }

        public int OperationTypeId { get => _operationTypeId; set => SetProperty(ref _operationTypeId, value); }

        public int MoneyId { get => _moneyId; set => SetProperty(ref _moneyId, value); }

        public Guid UserId { get => _userId; set => SetProperty(ref _userId, value); }

        public int ShopId { get => _shopId; set => SetProperty(ref _shopId, value); }

        public int BoxId { get => _boxId; set => SetProperty(ref _boxId, value); }

        public int ExpenceTypeId { get => _expenceTypeId; set => SetProperty(ref _expenceTypeId, value); }

        public decimal TotalIva { get => _totalIva; set => SetProperty(ref _totalIva, value); }

        public decimal TotalExenta { get => _totalExenta; set => SetProperty(ref _totalExenta, value); }

        public decimal TotalGravada { get => _totalGravada; set => SetProperty(ref _totalGravada, value); }

        public decimal TotalNeto { get => _totalNeto; set => SetProperty(ref _totalNeto, value); }

        public decimal Exchange { get => _exchange; set => SetProperty(ref _exchange, value); }

        public short Taxtype { get => _taxtype; set => SetProperty(ref _taxtype, value); }

        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }
    }
}