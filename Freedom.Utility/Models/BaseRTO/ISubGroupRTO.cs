namespace Freedom.Utility.Models.BaseRTO
{
    public interface ISubGroupRTO
    {
        int Id { get; set; }

        string Name { get; set; }
         
        int GroupId { get; set; }

        string GroupName { get; set; }  
    }
}