﻿using Freedom.Utility.Models.InterfaceRTO;

namespace Freedom.Utility.Models.InterfacePlus
{
    public interface IProductPlus : IProductRTO
    {
        public string PricesJson { get; set; }

        public string StockJson { get; set; }

        public string ApplyJson { get; set; }

        public string DrugJson { get; set; }

        public string WayAdminJson { get; set; }

        public string ImagesNamesJson { get; set; }
    }
}