using System.Globalization;

namespace Freedom.Utility.Helper
{
    public static class DecimalExtension
    {
        public static string ToSqlDecimal(this decimal value)
        {
            return Math.Round(value, value.GetNumberDecimalPlaces()).ToString(CultureInfo.GetCultureInfo("en-US"));
        }

        public static string ToSqlDecimal(this decimal value, int rounds)
        {
            return Math.Round(value, rounds).ToString(CultureInfo.GetCultureInfo("en-US"));
        }

        public static string ToBaseCurrencySql(this decimal value, decimal exchange)
        {
            decimal div = exchange == 0 ? 1 : exchange;
            decimal monBase = value / div;
            return Math.Round(monBase, 6).ToString(CultureInfo.GetCultureInfo("en-US"));
        }

        public static decimal ToBaseCurrency(this decimal value, decimal exchange)
        {
            decimal div = exchange == 0 ? 1 : exchange;
            decimal monBase = value / div;
            return monBase;
        }

        public static decimal ToLocalCurrency(this decimal value, decimal exchange)
        {
            decimal div = exchange == 0 ? 1 : exchange;
            return value * div;
        }

        public static int GetNumberDecimalPlaces(this decimal source)
        {
            string[] parts = source.ToString(CultureInfo.InvariantCulture).Split('.');
            if (parts.Length < 2)
                return 0;
            return parts[1].TrimEnd('0').Length;
        }
    }
}