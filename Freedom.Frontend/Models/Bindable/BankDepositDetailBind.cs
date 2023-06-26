using Freedom.Utility.Bindable;
using Freedom.Utility.Models.InterfaceRTO;

namespace Freedom.Frontend.Models.Bindable
{
    public class BankDepositDetailBind : BindableBase, IBankDepositDetailRTO
    {
        private string _sender;
        private string _bankName;
        private string _concept;
        private int _id;
        private int _bankDepositId;
        private decimal _amount;
        private long _checkNumber;
        private DateTime _checkDate;
        private string _conceptCheck;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public int BankDepositId { get => _bankDepositId; set => SetProperty(ref _bankDepositId, value); }

        public string Sender { get => _sender; set => SetProperty(ref _sender, value); }

        public string BankName { get => _bankName; set => SetProperty(ref _bankName, value); }

        public string Concept { get => _concept; set => SetProperty(ref _concept, value); }

        public string ConceptCheck { get => _conceptCheck; set => SetProperty(ref _conceptCheck, value); }

        public decimal Amount { get => _amount; set => SetProperty(ref _amount, value); }

        public long CheckNumber { get => _checkNumber; set => SetProperty(ref _checkNumber, value); }

        public DateTime CheckDate { get => _checkDate; set => SetProperty(ref _checkDate, value); }
    }
}