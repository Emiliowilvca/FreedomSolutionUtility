using Freedom.Utility.Interfaces;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Freedom.Utility.Implements
{
    //public class StringHelper : IStringHelper
    //{
    //    public string BuildQueryString<T>(T obj)
    //    {
    //        var queryString = HttpUtility.ParseQueryString(string.Empty);

    //        foreach (var property in TypeDescriptor.GetProperties(typeof(T)).Cast<PropertyDescriptor>())
    //        {
    //            var value = (property.GetValue(obj) ?? "").ToString();
    //            queryString.Add(property.Name, value);
    //        }
    //        return queryString.ToString();
    //    }

    //    public string GetSubString(string currentText, int length = 50)
    //    {
    //        return currentText.Length > length ? currentText.Substring(0, length) : currentText;
    //    }

    //    public string NullIfEmpty(string s)
    //    {
    //        return string.IsNullOrEmpty(s) ? null : s;
    //    }

    //    public string NullIfWhiteSpace(string s)
    //    {
    //        return string.IsNullOrWhiteSpace(s) ? null : s;
    //    }
    //}

   
}