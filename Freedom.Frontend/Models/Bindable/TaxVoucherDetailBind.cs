using Freedom.Utility.Bindable;
using System;

namespace Freedom.Frontend.Models.Bindable
{
    [Serializable]
    public class TaxVoucherDetailBind : BindableBase
    {
        private decimal _quantity;
        private decimal _price;
        private decimal _taxRate;
        private string _description;
        private string _code;

        public string Code { get => _code; set => SetProperty(ref _code, value); }

        public string Description { get => _description; set => SetProperty(ref _description, value); }

        public decimal Quantity
        {
            get => _quantity;
            set
            {
                SetProperty(ref _quantity, value);
                RefreshField();
            }
        }

        public decimal Price
        {
            get => _price;
            set
            {
                SetProperty(ref _price, value);
                RefreshField();
            }
        }

        /// <summary>
        /// Porcentaje de impuesto ej: 5%, 10%, exenta
        /// </summary>
        public decimal TaxRate
        {
            get => _taxRate;
            set
            {
                SetProperty(ref _taxRate, value);
                RefreshField();
            }
        }

        /// <summary>
        /// valor total de impuesto ej. Tax * quantity
        /// </summary>
        public decimal TaxTotal
        {
            get
            {
                // los tipos a calcular deben ser iguales Ej, Todos son Decimal
                return Quantity * (Price - (Price / ((Convert.ToDecimal(TaxRate) / 100) + 1)));
            }
        }

        public decimal SubTotal
        {
            get
            {
                return _price * _quantity;
            }
        }

        private void RefreshField()
        {
            RaisePropertyChanged(nameof(SubTotal));
            RaisePropertyChanged(nameof(TaxTotal));
        }

        public override void ResetEntity()
        {
            base.ResetEntity();
            Code = "";
            Description = "";
            Price = 0.0M;
            TaxRate = 0;
        }
    }
}