using System.ComponentModel;

namespace Freedom.Utility
{
    public static class EnumHelper
    {
        public static string GetEnumDescription<TEnum>(this TEnum value) where TEnum : Enum
        {
            var field = value.GetType().GetField(value.ToString());

            if (field != null)
            {
                var descriptionAttribute = (DescriptionAttribute)field
                    .GetCustomAttributes(typeof(DescriptionAttribute), false)
                    .FirstOrDefault();
                return descriptionAttribute?.Description ?? value.ToString();
            }
            return value.ToString();
        }
    }
}