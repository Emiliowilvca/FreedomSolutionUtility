﻿using Freedom.Utility.RequestBase;

namespace Freedom.Utility.Request
{
    public class RequestByLimit : IRequestCompanyId, IRequestNavigate
    {
        public int CompanyId { get; set; }

        public int OffSet { get; set; }

        public int Limit { get; set; }
    }
}