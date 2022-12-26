namespace Freedom.Utility.Models.BaseRTO
{
    public interface IOperationTypeRTO
    {
        int Id { get; set; }

        string Name { get; set; }

        int SubclassId { get; set; }

        string SubClassName { get; set; }

        string Intials { get; set; }
    }
}