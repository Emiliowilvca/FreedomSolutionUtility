using Freedom.Frontend.Models.AllPurpose;
using Freedom.Frontend.Models.BaseBindableInterface;
using Freedom.Utility.Bindable;

namespace Freedom.Frontend.Models.Bindable
{
    public class SaleCashFinishBind : BindableBase, ISaleCashFinish
    {
        private decimal _saleTotal;
        private decimal _cashAmount;
        private decimal _totalGross;
        private decimal _totalNet;
        private decimal _totalTaxed;
        private decimal _totalDiscount;
        private string _cashChange = "";
        private string _moneyName = "";
        private string _moneySymbol = "";
        private string _remark = "";
        private string _companyName = "";
        private string _shopName = "";
        private string _shopAddress = "";
        private string _shopPhone = "";
        private string _userName = "";
        private string _boxName = "";
        private string _customerName;

        public decimal SaleTotal { get => _saleTotal; set => SetProperty(ref _saleTotal, value); }

        public decimal CashAmount
        {
            get => _cashAmount;

            set
            {
                SetProperty(ref _cashAmount, value);

                if (CashAmount > TotalNet)
                {
                    var v = _cashAmount - TotalNet;
                    if (v > 0)
                        CashChange = v.ToString("N2");
                }
                else
                {
                    CashChange = 0.ToString("N2");
                }
            }
        }

        public string CashChange { get => _cashChange; set => SetProperty(ref _cashChange, value); }

        public string MoneyName { get => _moneyName; set => SetProperty(ref _moneyName, value); }

        public string MoneySymbol { get => _moneySymbol; set => SetProperty(ref _moneySymbol, value); }

        public string Remark { get => _remark; set => SetProperty(ref _remark, value); }

        public decimal TotalGross { get => _totalGross; set => SetProperty(ref _totalGross, value); }

        public decimal TotalNet { get => _totalNet; set => SetProperty(ref _totalNet, value); }

        public decimal TotalTaxed { get => _totalTaxed; set => SetProperty(ref _totalTaxed, value); }

        public decimal TotalDiscount { get => _totalDiscount; set => SetProperty(ref _totalDiscount, value); }

        public string CompanyName { get => _companyName; set => SetProperty(ref _companyName, value); }

        public string ShopName { get => _shopName; set => SetProperty(ref _shopName, value); }

        public string ShopAddress { get => _shopAddress; set => SetProperty(ref _shopAddress, value); }

        public string ShopPhone { get => _shopPhone; set => SetProperty(ref _shopPhone, value); }

        public string UserName { get => _userName; set => SetProperty(ref _userName, value); }

        public string BoxName { get => _boxName; set => SetProperty(ref _boxName, value); }

        public string CustomerName { get => _customerName; set => SetProperty(ref _customerName, value); }

        public void GetSaleFinish(SaleCashFinish sf)
        {
            this.CashAmount = sf.CashAmount;
            this.CashChange = sf.CashChange;
            this.MoneyName = sf.MoneyName;
            this.MoneySymbol = sf.MoneySymbol;
            this.Remark = sf.Remark;
            this.TotalGross = sf.TotalGross;
            this.TotalNet = sf.TotalNet;
            this.TotalTaxed = sf.TotalTaxed;
            this.TotalDiscount = sf.TotalDiscount;
            this.CompanyName = sf.CompanyName;
            this.ShopName = sf.ShopName;
            this.ShopAddress = sf.ShopAddress;
            this.ShopPhone = sf.ShopPhone;
            this.UserName = sf.UserName;
            this.BoxName = sf.BoxName;
            this.CustomerName = sf.CustomerName;
        }
    }
}