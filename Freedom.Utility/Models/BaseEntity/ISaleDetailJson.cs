namespace Freedom.Utility.Models.BaseEntity
{
    public interface ISaleDetailJson : ISaleDetail
    {
        string Code { get; set; }

        string Description { get; set; }

    }
}