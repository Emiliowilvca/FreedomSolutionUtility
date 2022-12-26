namespace Freedom.Utility.Models.BaseEntity
{
    public interface ICity
    {
        int CompanyId { get; set; }

        int Id { get; set; }

        string Name { get; set; }

        int StateId { get; set; }

    }
}