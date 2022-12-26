using Freedom.Utility.RequestBase;

namespace Freedom.Utility.Request
{
    public class RequestByDocNumber : IRequestCompanyId, IRequestDocNumber
    {
        public int CompanyId { get; set; }

        public long DocumentNumber { get; set; }
    }
}