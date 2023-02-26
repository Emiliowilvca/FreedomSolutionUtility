using System;

namespace Freedom.Utility
{
    public static class GuidExtensions
    {
        public static bool IsGuid(this string value)
        {
            try
            {
                return Guid.TryParse(value, out Guid output);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool BeAValidGuid(Guid unValidatedGuid)
        {
            try
            {
                if (unValidatedGuid == Guid.Empty)
                {
                    return false;
                }
                return Guid.TryParse(unValidatedGuid.ToString(), out Guid validatedGuid);
            }
            catch (Exception)
            {
               return false;
            }
        }
    }
}