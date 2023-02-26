using Freedom.Utility.Models.AllPurpose;

namespace Freedom.Utility.Interfaces
{
    public interface IEnumExtension
    {
        List<EnumItem> GetEnumAttibuteToList(Type type);
    }
}