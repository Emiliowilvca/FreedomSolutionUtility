namespace Freedom.Utility.Models.BaseRTO
{
    public interface ICompanyRTO
    {
        int Id { get; set; }

        string Name { get; set; }

        string Email { get; set; }

        string PhoneNumber { get; set; }

        string City { get; set; }
    }
}