using Freedom.Utility.RequestBase;

namespace Freedom.Utility.Request
{
    public class EmailRequest : IRequestEmail
    {
        public string Email { get; set; }
    }
}