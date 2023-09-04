using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.EntityDto
{
    [Serializable]
    public class CompanyDto : IEntity, ICompany
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string CompanyOwner { get; set; }

        public string Email { get; set; }

        public string Ruc { get; set; }

        public DateTime TimbradoInit { get; set; }

        public DateTime TimbradoExpire { get; set; }

        public string FacebookAdress { get; set; }

        public string WhatsappPhoneNumber { get; set; }

        public string PhoneNumber { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string Address { get; set; }

        public bool IsAvailable { get; set; }

        public DateTime Registered { get; set; }

        public int TrialDay { get; set; }
    }
}