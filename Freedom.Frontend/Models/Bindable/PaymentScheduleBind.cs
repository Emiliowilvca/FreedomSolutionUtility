using Freedom.Frontend.Models.BaseBindableInterface;
using Freedom.Utility.Bindable;

namespace Freedom.Frontend.Models.Bindable
{
    public class PaymentScheduleBind : BindableBase, IPaymentSchedule
    {
        private int _fee;
        private DateTime _expire;
        private int _daysLate;
        private decimal _amount;
        private decimal _interest;
        private decimal _balance;
        private string _money;

        public int Fee { get => _fee; set => SetProperty(ref _fee, value); }

        public DateTime Expire { get => _expire; set => SetProperty(ref _expire, value); }

        public int DaysLate { get => _daysLate; set => SetProperty(ref _daysLate, value); }

        public decimal Amount { get => _amount; set => SetProperty(ref _amount, value); }

        public decimal Interest { get => _interest; set => SetProperty(ref _interest, value); }

        public decimal Balance { get => _balance; set => SetProperty(ref _balance, value); }

        public string Money { get => _money; set => SetProperty(ref _money, value); }
    }
}