using Freedom.Utility.Variables;
using System.Text.RegularExpressions;

namespace Freedom.Utility
{
    public static class EmailHelper
    {
        public static bool IsValidEmail(string email)
        {
            if(string.IsNullOrEmpty(email))
                return false;
            bool resp = Regex.IsMatch(email, GlobalStatic.EmailRegex);
            return resp;
        }
    }
}