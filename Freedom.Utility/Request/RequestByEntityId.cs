using Freedom.Utility.RequestBase;

namespace Freedom.Utility.Request
{
    public class RequestByEntityId:IRequestId, IRequestCompanyId
    {
        public int CompanyId { get; set; }

        public int Id { get; set; }
    }
}