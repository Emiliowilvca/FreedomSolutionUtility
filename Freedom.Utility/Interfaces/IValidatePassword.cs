namespace Freedom.Utility.Interfaces
{
    public interface IValidatePassword
    {
        bool CheckPassword(string password);

        bool CheckPassword(string password, string pattern);
    }
}