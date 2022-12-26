using Freedom.Utility.Models.RTO;
using System;

namespace Freedom.Utility.Responses
{
    public class TokenResponse
    {
        public UserRTO UserRTO { get; set; }

        public ShopRTO ShopRTO { get; set; }

        public ShopRuleRTO ShopRuleRTO { get; set; }

        public BoxRTO BoxRTO { get; set; }

        public UserSettingRTO UserSettingRTO { get; set; }

        public CompanyRTO CompanyRTO { get; set; }

        public CityRTO CityRTO { get; set; }

        public EmployeeRTO EmployeeRTO { get; set; }

        public MoneyRTO MoneyRTO { get; set; }

        public CustomerAccountRTO CustomerAccountRTO { get; set; }

        public PersonRTO PersonRTO { get; set; }

        public DateTime ExpireToken { get; set; }

        public string Token { get; set; }

        public bool Success { get; set; }

        public string ResultMessage { get; set; }

        public string ResourceKey { get; set; }
    }
}