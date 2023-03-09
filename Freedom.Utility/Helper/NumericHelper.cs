using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Freedom.Utility
{
    public static class NumericHelper
    {
        public static int ExtractIntegerFromString(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }
            string numbersFromString = new string(input.Where(x => x >= '0' && x <= '9').ToArray());
            return string.IsNullOrEmpty(numbersFromString) ? 0 : Convert.ToInt32(numbersFromString);
        }

        public static long ExtractLongFromString(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }
            string numbersFromString = new string(input.Where(x => x >= '0' && x <= '9').ToArray());
            return string.IsNullOrEmpty(numbersFromString) ? 0 : Convert.ToInt64(numbersFromString);
        }

        public static decimal ToDecimal(this string value)
        {
            decimal result = 0m;
            if (string.IsNullOrEmpty(value))
            {
                return result;
            }

            string input = value.Trim();

            input = input.Replace(" ", "");

            if (string.IsNullOrEmpty(input))
            {
                return result;
            }
            // check if input has , and . for thousands separator and decimal place
            if (input.Contains(',') && input.Contains('.'))
            {
                // find the decimal separator, might be , or .
                int decimalpos = input.LastIndexOf(',') > input.LastIndexOf('.') ? input.LastIndexOf(',') : input.LastIndexOf('.');
                // uses | as a temporary decimal separator
                input = input.Substring(0, decimalpos) + "|" + input.Substring(decimalpos + 1);
                // formats the output removing the , and . and replacing the temporary | with .
                input = input.Replace(".", "").Replace(",", "").Replace("|", ".");
            }
            // replaces , with .
            if (input.Contains(','))
            {
                input = input.Replace(',', '.');
            }
            // checks if the input number has thousands separator and no decimal places
            if (input.Count(item => item == '.') > 1)
            {
                input = input.Replace(".", "");
            }

            // tries to convert input to decimal
            if (decimal.TryParse(input, out result) == true)
            {
                CultureInfo cultureInfo = new CultureInfo("en-US");
                result = decimal.Parse(input, NumberStyles.AllowLeadingSign |
                                              NumberStyles.AllowDecimalPoint |
                                              NumberStyles.AllowThousands, cultureInfo);
            }
            return result;
        }

        public static int ToInteger(this double value)
        {
            return (int)Math.Round(value);
        }

        public static int ToInteger(this string value)
        {
            if (string.IsNullOrEmpty(value)) return 0;

            return int.TryParse(value, out int result) ? result : 0;
        }

        public static long ToLong(this string value)
        {
            if (string.IsNullOrEmpty(value)) return 0;

            return long.TryParse(value, out long result) ? result : 0;
        }

        public static List<int> SplitStringToInt(this string input)
        {
            List<int> array = new List<int>();
            if (!string.IsNullOrEmpty(input))
            {
                List<int> gpInt = input.Split(',').Select(x => Convert.ToInt32(x)).ToList();
                if (gpInt.Count > 0)
                {
                    array.AddRange(gpInt);
                }
            }
            return array;
        }

        public static bool IsDecimals(this object obj)
        {
            if (obj == null) return false;

            switch (obj)
            {
                case float _: return true;
                case double _: return true;
                case decimal _: return true;
            }
            CultureInfo culture = new CultureInfo("en-US");
            string value = Convert.ToString(obj, culture);
            bool result = decimal.TryParse(value, NumberStyles.AllowCurrencySymbol | NumberStyles.Number, culture, out _);
            return result;
        }

        public static bool IsDecimals(this object obj, IFormatProvider formatProvider)
        {
            if (obj == null) return false;

            switch (obj)
            {
                case float _: return true;
                case double _: return true;
                case decimal _: return true;
            }
            string value = Convert.ToString(obj, CultureInfo.InvariantCulture);
            bool result = decimal.TryParse(value, NumberStyles.AllowCurrencySymbol | NumberStyles.Number, formatProvider, out _);
            return result;
        }

        public static bool IsInteger(this object obj)
        {
            if (obj == null) return false;

            if (string.IsNullOrEmpty(obj.ToString()))
                return false;
            switch (obj)
            {
                case sbyte _: return true;
                case byte _: return true;
                case short _: return true;
                case ushort _: return true;
                case int _: return true;
                case uint _: return true;
                case long _: return true;
                case ulong _: return true;
            }
            string numValue = Convert.ToString(obj, CultureInfo.InvariantCulture);
            return ulong.TryParse(numValue, NumberStyles.Integer, CultureInfo.InvariantCulture, out _);
        }

        public static byte ToByte(this bool value)
        {
            return Convert.ToByte(value);
        }

        public static bool ToBool(this int value)
        {
            return value != 0;
        }

        




    }
}