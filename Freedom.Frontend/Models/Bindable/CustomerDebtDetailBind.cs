using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseRTO;
using System;

namespace Freedom.Frontend.Models.BindableINFO
{
    public class CustomerDebtDetailBind : BindableBase, ICustomerDebtDetailRTO
    {
        private int _saleId;
        private int _saleFeesId;
        private long? _invoice;
        private int _shopId;
        private string _shopName;
        private int _boxId;
        private string _boxName;
        private decimal _exchange;
        private DateTime _saleDate;
        private int _moneyId;
        private string _moneyName;
        private string _moneySymbol;
        private int _employeeId;
        private string _employeeName;
        private string _userName;
        private decimal _totalTax;
        private decimal _totalNet;
        private decimal _totalGross;
        private decimal _totalDiscount;
        private int _promissoryNote;
        private decimal _feesvalue;
        private decimal _partialPayment;
        private decimal _balanceFees;
        private DateTime _expirate;
        private byte _numberFees;
        private decimal _daysLate;
        private decimal _interestOnArrears;
        private decimal _imputValue;

        public int SaleId { get => _saleId; set => SetProperty(ref _saleId, value); }

        public int SaleFeesId { get => _saleFeesId; set => SetProperty(ref _saleFeesId, value); }

        public long? Invoice { get => _invoice; set => SetProperty(ref _invoice, value); }

        public int ShopId { get => _shopId; set => SetProperty(ref _shopId, value); }

        public string ShopName { get => _shopName; set => SetProperty(ref _shopName, value); }

        public int BoxId { get => _boxId; set => SetProperty(ref _boxId, value); }

        public string BoxName { get => _boxName; set => SetProperty(ref _boxName, value); }

        public decimal Exchange { get => _exchange; set => SetProperty(ref _exchange, value); }

        public DateTime SaleDate { get => _saleDate; set => SetProperty(ref _saleDate, value); }

        public int MoneyId { get => _moneyId; set => SetProperty(ref _moneyId, value); }

        public string MoneyName { get => _moneyName; set => SetProperty(ref _moneyName, value); }

        public string MoneySymbol { get => _moneySymbol; set => SetProperty(ref _moneySymbol, value); }

        public int EmployeeId { get => _employeeId; set => SetProperty(ref _employeeId, value); }

        public string EmployeeName { get => _employeeName; set => SetProperty(ref _employeeName, value); }

        public string UserName { get => _userName; set => SetProperty(ref _userName, value); }

        public decimal TotalTax { get => _totalTax; set => SetProperty(ref _totalTax, value); }

        public decimal TotalNet { get => _totalNet; set => SetProperty(ref _totalNet, value); }

        public decimal TotalGross { get => _totalGross; set => SetProperty(ref _totalGross, value); }

        public decimal TotalDiscount { get => _totalDiscount; set => SetProperty(ref _totalDiscount, value); }

        public int PromissoryNote { get => _promissoryNote; set => SetProperty(ref _promissoryNote, value); }

        public decimal Feesvalue { get => _feesvalue; set => SetProperty(ref _feesvalue, value); }

        public decimal PartialPayment { get => _partialPayment; set => SetProperty(ref _partialPayment, value); }

        public byte NumberFees { get => _numberFees; set => SetProperty(ref _numberFees, value); }

        public decimal DaysLate { get => _daysLate; set => SetProperty(ref _daysLate, value); }

        public DateTime Expirate { get => _expirate; set => SetProperty(ref _expirate, value); }

        public decimal BalanceFees { get => _balanceFees; set => SetProperty(ref _balanceFees, value); }

        public decimal InterestOnArrears { get => _interestOnArrears; set => SetProperty(ref _interestOnArrears, value); }

        public decimal ImputValue
        {
            get => _imputValue;
            set
            {
                if (value < 0)
                    value = 0;
                if (value > _balanceFees)
                    value = _balanceFees;
                SetProperty(ref _imputValue, value);
            }
        }

        public override void ResetEntity()
        {
            base.ResetEntity();

            SaleId = 0;
            SaleFeesId = 0;
            Invoice = null;
            ShopId = 0;
            ShopName = "";
            BoxId = 0;
            BoxName = "";
            Exchange = 0m;
            SaleDate = DateTime.MinValue;
            MoneyId = 0;
            MoneyName = "";
            MoneySymbol = "";
            EmployeeId = 0;
            EmployeeName = "";
            UserName = "";
            TotalTax = 0;
            TotalNet = 0;
            TotalGross = 0;
            TotalDiscount = 0;
            PromissoryNote = 0;
            Feesvalue = 0;
            PartialPayment = 0;
            BalanceFees = 0;
            Expirate = DateTime.MinValue;
            NumberFees = 0;
            DaysLate = 0;
            InterestOnArrears = 0;
            ImputValue = 0;
        }
    }
}