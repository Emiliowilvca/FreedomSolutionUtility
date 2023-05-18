namespace Freedom.Frontend.Models.AllPurpose
{
    public class PayOffCalculatorResult
    {
        public List<PaymentSchedule> PaymentSchedules { get; set; }

        public int AuthorizedStafId { get; set; }

        public int AuthorizingOfficerId { get; set; }
    }
}