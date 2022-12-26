using Freedom.Utility.RequestBase;

namespace Freedom.Utility.Request
{
    public class UserSettingRequest : IRequestEmail
    {
        public string Email { get; set; }

        public int UserSettingId { get; set; }
    }
}