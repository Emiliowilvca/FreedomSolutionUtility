using Freedom.Utility.RequestBase;

namespace Freedom.Utility.Request
{
    [Obsolete]
    public class RequestBySearchText : IRequestSearchText, IRequestCompanyId, IRequestNavigate
    {
        public string SearchText { get; set; }

        public int CompanyId { get; set; }

        public int OffSet { get; set; }

        public int Limit { get; set; }
    }
}