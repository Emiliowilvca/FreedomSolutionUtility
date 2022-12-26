using Freedom.Utility.RequestBase;

namespace Freedom.Utility.Request
{
    public class ConfirmEmailRequest : IRequestEmail
    {
        public long VerificationCode { get; set; }

        public string Email { get; set; }
    }
}