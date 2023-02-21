using Freedom.Utility.RequestBase;

namespace Freedom.Utility.Request
{
    [Obsolete]
    public class RequestTimbrado : IRequestCompanyId, IRequestProviderId
    {
        public int CompanyId { get; set; }

        public int ProviderId { get; set; }
    }
}