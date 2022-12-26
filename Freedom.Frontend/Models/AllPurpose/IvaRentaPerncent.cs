using Freedom.Utility.Bindable;
using System;
using System.Collections.ObjectModel;

namespace Freedom.Frontend.Models.AllPurpose
{
    [Serializable]
    public class IvaRentaPerncent : BindableBase
    {
        private ObservableCollection<decimal> _withholdingIva5Percent;
        private ObservableCollection<decimal> _withholdingIva10Percent;
        private ObservableCollection<decimal> _withholdingRentaPercent;

        public IvaRentaPerncent()
        {
            WithholdingIva5Percent = new ObservableCollection<decimal>() { 0m, 0.90909m, 10m, 30m, 50m, 70m, 100m };
            WithholdingIva10Percent = new ObservableCollection<decimal>() { 0m, 0.90909m, 30m, 50m, 70m, 100m };
            WithholdingRentaPercent = new ObservableCollection<decimal>() { 0m, 0.4m, 0.5m, 1m, 1.5m, 2m, 2.4m, 3m, 4.5m, 8m, 10m, 15m, 20m, 30m };
        }

        public ObservableCollection<decimal> WithholdingIva5Percent
        {
            get => _withholdingIva5Percent;
            set => SetProperty(ref _withholdingIva5Percent, value);
        }

        public ObservableCollection<decimal> WithholdingIva10Percent
        {
            get => _withholdingIva10Percent;
            set => SetProperty(ref _withholdingIva10Percent, value);
        }

        public ObservableCollection<decimal> WithholdingRentaPercent
        {
            get => _withholdingRentaPercent;
            set => SetProperty(ref _withholdingRentaPercent, value);
        }
    }
}