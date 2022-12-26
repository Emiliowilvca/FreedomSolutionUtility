using Freedom.Utility.RequestBase;

namespace Freedom.Utility.Request
{
    public class TokenRequest : IRequestEmail
    {
        public string Email { get; set; }

        public string Password { get; set; }
    }
}