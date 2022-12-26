using Freedom.Utility.Interfaces;
using Freedom.Utility.Variables;
using System.Text.RegularExpressions;

namespace Freedom.Utility.Implements
{
    public class ValidatePassword : IValidatePassword
    {
        public bool CheckPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
                return false;
            Regex reg = new Regex(GlobalStatic.PasswordRegex);

            return reg.IsMatch(password);
        }

        public bool CheckPassword(string password, string pattern)
        {
            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(pattern))
                return false;

            Regex reg = new Regex(pattern);

            return reg.IsMatch(password);
        }
    }
}