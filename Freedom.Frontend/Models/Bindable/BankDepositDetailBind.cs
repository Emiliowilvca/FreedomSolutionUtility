using Freedom.Utility.Bindable;

namespace Freedom.Frontend.Models.Bindable
{
    public class BankDepositDetailBind : BindableBase
    {
        private string _amount;
        private string _checkNumber;
        private string _checkDate;
        private string _sender;
        private string _bankName;
        private string _concept;
        private int _id;
        private int _bankDepositId;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public int BankDepositId { get => _bankDepositId; set => SetProperty(ref _bankDepositId, value); }

        public string Amount { get => _amount; set => SetProperty(ref _amount, value); }

        public string CheckNumber { get => _checkNumber; set => SetProperty(ref _checkNumber, value); }

        public string CheckDate { get => _checkDate; set => SetProperty(ref _checkDate, value); }

        public string Sender { get => _sender; set => SetProperty(ref _sender, value); }

        public string BankName { get => _bankName; set => SetProperty(ref _bankName, value); }

        public string Concept { get => _concept; set => SetProperty(ref _concept, value); }
    }
}