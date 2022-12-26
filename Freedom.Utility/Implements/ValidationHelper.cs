using Freedom.Utility.Interfaces;
using Freedom.Utility.Variables;
using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Freedom.Utility.Implements
{
    //public class ValidationHelper : IValidationHelper
    //{
    //    private CultureInfo _cultureInfo;
    //    public ValidationHelper()
    //    {
    //        _cultureInfo = new CultureInfo("en-US");
    //    }

    //    public bool IsDecimals(object obj)
    //    {
    //        if (obj == null) return false;

    //        switch (obj)
    //        {
    //            case float _: return true;
    //            case double _: return true;
    //            case decimal _: return true;
    //        }

    //        decimal retNum;
    //        string value = Convert.ToString(obj, _cultureInfo);
    //        var result = decimal.TryParse(value, NumberStyles.Float, _cultureInfo, out retNum);
    //        return result;
    //    }

    //    public bool IsInteger(object obj)
    //    {
    //        if (obj == null) return false;

    //        switch (obj)
    //        {
    //            case sbyte _: return true;
    //            case byte _: return true;
    //            case short _: return true;
    //            case ushort _: return true;
    //            case int _: return true;
    //            case uint _: return true;
    //            case long _: return true;
    //            case ulong _: return true;
    //        }
    //        ulong retNum;
    //        string numValue = Convert.ToString(obj, _cultureInfo);
    //        return ulong.TryParse(numValue, NumberStyles.Integer, _cultureInfo, out retNum);
    //    }

    //    public bool IsValidPhone(string Phone)
    //    {
    //        try
    //        {
    //            if (string.IsNullOrEmpty(Phone))
    //                return false;
    //            var pattern = @"^[0-9-+]+$";
    //            return Regex.Match(Phone, pattern, RegexOptions.IgnoreCase).Success;
    //        }
    //        catch (Exception)
    //        {
    //            return false;
    //        }
    //    }

    //    public bool IsValidDate(string date)
    //    {
    //        return DateTime.TryParse(date, out DateTime tempDate);
    //    }

    //    public bool IsValidEmail(string email)
    //    {
    //        bool resp = Regex.IsMatch(email, GlobalStatic.EmailRegex);
    //        return resp;
    //    }
    //}
}