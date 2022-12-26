using Freedom.Utility.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;


namespace Freedom.Utility.Implements
{
    //public class NumericHelper : INumericHelper
    //{


    //    public int ExtractIntNumbersFromString(string input)
    //    {
    //        if (string.IsNullOrEmpty(input))
    //        {
    //            return 0;
    //        }
    //        string numbersFromString = new string(input.Where(x => x >= '0' && x <= '9').ToArray());
    //        return string.IsNullOrEmpty(numbersFromString) ? 0 : Convert.ToInt32(numbersFromString);
    //    }

    //    public long ExtractNumbersFromString(string input)
    //    {
    //        if (string.IsNullOrEmpty(input))
    //        {
    //            return 0;
    //        }
    //        string numbersFromString = new string(input.Where(x => x >= '0' && x <= '9').ToArray());
    //        return string.IsNullOrEmpty(numbersFromString) ? 0 : Convert.ToInt64(numbersFromString);
    //    }

    //    public List<int> SplitStringToInt(string input)
    //    {
    //        List<int> array = new List<int>();
    //        if (!string.IsNullOrEmpty(input))
    //        {
    //            List<int> gpInt = input.Split(',').Select(x => Convert.ToInt32(x.ToString())).ToList();
    //            if (gpInt.Count > 0)
    //            {
    //                array.AddRange(gpInt);
    //            }
    //        }
    //        return array;
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
    //        CultureInfo _cultureInfo = new CultureInfo("en-US");
    //        string numValue = Convert.ToString(obj, _cultureInfo);
    //        return ulong.TryParse(numValue, NumberStyles.Integer, _cultureInfo, out _);
    //    }


    //}
}