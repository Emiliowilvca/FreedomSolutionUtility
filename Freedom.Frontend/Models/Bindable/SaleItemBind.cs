using Freedom.Utility.Bindable;
using System;
using System.ComponentModel;

namespace Freedom.Frontend.Models.Bindable
{
    //gravada: significa producto que paga iva
    public class SaleItemBind : BindableBase, IEditableObject
    {
        private Guid _id;
        private string _code;
        private string _name;
        private decimal _quantity;
        private decimal _salePrice;
        private decimal _discountPercent;
        private decimal _taxRate;
        private Guid _userId;
        private decimal _costPrice;
        private bool _isPopulate;

        public Guid Id { get => _id; set => SetProperty(ref _id, value); }

        public int ProductId { get => _productId; set => SetProperty(ref _productId, value); }

        public bool IsPopulate { get => _isPopulate; set => SetProperty(ref _isPopulate, value); }

        public string Code
        {
            get => _code; set 
            {
                var text = value;
                if (!string.IsNullOrEmpty(text))
                {
                    if (text.Contains("'") ||
                          text.Contains("`") ||
                          text.Contains("´") ||
                          text.Contains("~"))
                    {
                        text = text.Replace("'", "-")
                            .Replace("`", "-")
                            .Replace("´", "-")
                            .Replace("~", "-");
                        value = text;
                    }                
                }
                SetProperty(ref _code, value);
            }
        }

        public string Name { get => _name; set => SetProperty(ref _name, value); }

        public Guid UserId { get => _userId; set => SetProperty(ref _userId, value); }

        public decimal CostPrice { get => _costPrice; set => SetProperty(ref _costPrice, value); }

        public int MoneyId { get => _moneyId; set => SetProperty(ref _moneyId, value); }

        public decimal Quantity
        {
            get => _quantity;
            set
            {
                SetProperty(ref _quantity, value);
                Refresh();
            }
        }

        public decimal SalePrice
        {
            get => _salePrice;
            set
            {
                SetProperty(ref _salePrice, value);
                Refresh();
            }
        }

        public decimal MaximumDiscount
        {
            get => _maximumDiscount;
            set => _maximumDiscount = value;
        }

        public decimal Discount
        {
            get
            {
                decimal discountPercent = (this.DiscountPercent > MaximumDiscount) ? MaximumDiscount : this.DiscountPercent;
                decimal percent = (discountPercent / 100) + 1;
                return SalePrice - (SalePrice / percent);
            }
        }

        public decimal DiscountPercent
        {
            get => _discountPercent;
            set
            {
                SetProperty(ref _discountPercent, value > MaximumDiscount ? MaximumDiscount : value);
                Refresh();
            }
        }

        public decimal TaxRate { get => _taxRate; set => SetProperty(ref _taxRate, value); }

        public decimal TaxIvaValue
        {
            get
            {
                decimal taxValue = 0;
                if (TaxRate != 0)
                {
                    var taxpercent = (TaxRate / 100) + 1;
                    taxValue = SalePrice - (SalePrice / taxpercent);
                }
                return taxValue;
            }
        }

        public decimal SubTotal => (SalePrice - Discount) * Quantity;

        private void Refresh()
        {
            RaisePropertyChanged(nameof(this.Discount));
            RaisePropertyChanged(nameof(this.SubTotal));
        }

        #region IEditableObject

        private bool _inEdit;

        private SaleItemBind _backupCopy;
        private decimal _maximumDiscount = 5;
        private int _productId;
        private int _moneyId;

        //TODO:Delete tmp disconunt value
        public void BeginEdit()
        {
            if (_inEdit) return;
            _inEdit = true;
            _backupCopy = this.MemberwiseClone() as SaleItemBind;
        }

        public void CancelEdit()
        {
            if (!_inEdit) return;
            _inEdit = false;
            IsPopulate = true;
        }

        public void EndEdit()
        {
            if (!_inEdit) return;
            _inEdit = false;
            _backupCopy = null;
        }

        #endregion IEditableObject
    }
}