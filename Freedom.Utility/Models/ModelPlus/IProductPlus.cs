namespace Freedom.Utility.Models.ModelPlus
{
    public interface IProductPlus : IProductFull
    {
        public string PricesJson { get; set; }

        public string StockJson { get; set; }

        public string ApplyJson { get; set; }

        public string DrugJson { get; set; }

        public string WayAdminJson { get; set; }

        public string ImagesNamesJson { get; set; }
    }
}