namespace Freedom.Utility.Models.InterfaceEntity
{
    public interface ICompany : IEntity
    {
        string Address { get; set; }

        string City { get; set; }

        string Name { get; set; }

        string CompanyOwner { get; set; }

        string Country { get; set; }

        string Email { get; set; }
        string Ruc { get; set; }

        DateTime TimbradoInit { get; set; }

        DateTime TimbradoExpire { get; set; }

        string FacebookAdress { get; set; }

        bool IsAvailable { get; set; }

        string PhoneNumber { get; set; }

        DateTime Registered { get; set; }

        string State { get; set; }

        int TrialDay { get; set; }

        string WhatsappPhoneNumber { get; set; }
    }
}