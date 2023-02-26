﻿using Freedom.Utility.Models.BaseRTO;

namespace Freedom.Utility.Models.RTO
{
    public class TownRTO : ITownRTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CityId { get; set; }

        public string CityName { get; set; }

        public int StateId { get; set; }

        public string StateName { get; set; }

        public int CountryId { get; set; }

        public string CountryName { get; set; }
    }
}