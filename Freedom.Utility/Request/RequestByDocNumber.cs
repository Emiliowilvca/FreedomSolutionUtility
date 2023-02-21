using Freedom.Utility.RequestBase;

namespace Freedom.Utility.Request
{
    [Obsolete]
    public class RequestByDocNumber : IRequestCompanyId, IRequestDocNumber
    {
        public int CompanyId { get; set; }

        public long DocumentNumber { get; set; }
    }
}