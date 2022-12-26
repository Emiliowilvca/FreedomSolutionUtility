using System;
using System.Text.RegularExpressions;

namespace Freedom.Utility
{
    public static class PhoneHelper
    {
        public static bool IsValidPhone(this string Phone)
        {
            try
            {
                if (string.IsNullOrEmpty(Phone))
                    return false;
                string pattern = @"^[0-9-+]+$";
                return Regex.Match(Phone, pattern, RegexOptions.IgnoreCase).Success;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}