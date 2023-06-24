namespace Freedom.Utility.Models.InterfaceEntity
{
    public interface IProvider
    {
        int Id { get; set; }

        int CompanyId { get; set; }

        string Name { get; set; }

        string Address { get; set; }

        string Contact { get; set; }

        string Phone { get; set; }

        string Email { get; set; }

        string Ruc { get; set; }

        int ProviderTypeID { get; set; }

        int CityId { get; set; }

        int PaymentTypeId { get; set; }

        DateTime Authorization { get; set; }

        DateTime Expiration { get; set; }

        string Timbrado { get; set; }

        string BankName { get; set; }

        string BankAccountNum { get; set; }
    }
}